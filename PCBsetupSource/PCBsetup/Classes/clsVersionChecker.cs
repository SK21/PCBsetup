using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PCBsetup.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PCBsetup.Classes
{
    public class clsVersionChecker
    {
        private string FileLocation;
        private frmMain mf;
        private Dictionary<int, ModuleInfo> Modules = new Dictionary<int, ModuleInfo>();
        private RCappInfo RCapp = null;
        private string VersionsURL = "https://github.com/SK21/AOG_RC/releases/latest/download/Versions.json";

        public clsVersionChecker(frmMain CalledFrom)
        {
            mf = CalledFrom;
            FileLocation = mf.Tls.FirmwareDir() + "\\versionCache.json";
            LoadFromFile(FileLocation);
        }

        public DateTime RCappDate => RCapp?.Date ?? DateTime.MinValue;

        public string RCappLatest => RCapp?.Version ?? "N/A";

        public DateTime ModuleDate(int ModuleID) =>
            Modules.TryGetValue(ModuleID, out var info) ? info.Date : DateTime.MinValue;

        public string ModuleDescription(int ModuleID) =>
            Modules.TryGetValue(ModuleID, out var info) ? info.Description : "Unknown";

        public async Task Update()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(VersionsURL);

                    var jsonObj = JsonConvert.DeserializeObject<Dictionary<string, JObject>>(json);
                    if (jsonObj == null)
                        return;

                    var modulesUpdate = new Dictionary<int, ModuleInfo>();
                    RCappInfo rcappUpdate = null;

                    foreach (var kvp in jsonObj)
                    {
                        if (kvp.Key == "RCapp")
                        {
                            rcappUpdate = kvp.Value.ToObject<RCappInfo>();
                        }
                        else if (int.TryParse(kvp.Key, out int moduleId))
                        {
                            var module = kvp.Value.ToObject<ModuleInfo>();
                            modulesUpdate[moduleId] = module;
                        }
                    }

                    // Apply updates
                    RCapp = rcappUpdate;
                    Modules = modulesUpdate;

                    // Build flat structure for saving
                    var saveObj = new JObject();

                    saveObj["RCapp"] = JObject.FromObject(RCapp);

                    foreach (var kvp in Modules)
                    {
                        saveObj[kvp.Key.ToString()] = JObject.FromObject(kvp.Value);
                    }

                    // Write to file
                    File.WriteAllText(FileLocation, saveObj.ToString(Formatting.Indented));
                }
                catch (Exception ex)
                {
                    mf.Tls.ShowHelp("Update failed: " + ex.Message);
                }
            }
        }

        private void LoadFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                var doc = JsonDocument.Parse(json);

                RCapp = null;
                Modules.Clear();

                foreach (var property in doc.RootElement.EnumerateObject())
                {
                    if (property.Name == "RCapp")
                    {
                        RCapp = JsonConvert.DeserializeObject<RCappInfo>(property.Value.GetRawText());
                    }
                    else if (int.TryParse(property.Name, out int key))
                    {
                        var info = JsonConvert.DeserializeObject<ModuleInfo>(property.Value.GetRawText());
                        Modules[key] = info;
                    }
                }
            }
        }

        private class ModuleInfo
        {
            public DateTime Date { get; set; }
            public string Description { get; set; }
        }

        private class RCappInfo
        {
            public DateTime Date { get; set; }
            public string Version { get; set; }
        }
    }
}