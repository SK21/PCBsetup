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
            FileLocation = mf.Tls.FirmwareDir() + "\\RateControlVersions.json";
            LoadFromFile(FileLocation);
        }

        public DateTime RCappDate => RCapp?.Date ?? DateTime.MinValue;

        public string RCappLatest => RCapp?.Version ?? "N/A";

        public string Version(int ModuleID) =>
            Modules.TryGetValue(ModuleID, out var info) ? info.Version : "N/A";

        public string ModuleDescription(int ModuleID) =>
            Modules.TryGetValue(ModuleID, out var info) ? info.Description : "Unknown";

        public async Task Update()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync(VersionsURL);
                    File.WriteAllText(FileLocation, json);
                    LoadFromFile(FileLocation);
                }
                catch (Exception ex)
                {
                    mf.Tls.ShowHelp("Version update failed: " + ex.Message);
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
            public string Version { get; set; }
            public string Description { get; set; }
        }

        private class RCappInfo
        {
            public DateTime Date { get; set; }
            public string Version { get; set; }
        }
    }
}