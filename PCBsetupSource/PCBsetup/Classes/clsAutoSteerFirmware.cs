using Newtonsoft.Json.Linq;
using PCBsetup.Forms;
using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PCBsetup.Classes
{
    public class clsAutoSteerFirmware
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private string cAutoSteerVersion;
        private string HexFileURL = "https://github.com/SK21/AOG_AutoSteer/releases/latest/download/AutoSteerTeensyRVC.ino.hex";
        private frmMain mf;
        private string VersionLocation;
        private string VersionsURL = "https://github.com/SK21/AOG_AutoSteer/releases/latest/download/Versions.json";

        public clsAutoSteerFirmware(frmMain CalledFrom)
        {
            mf = CalledFrom;
            VersionLocation = mf.Tls.FirmwareDir() + "\\AutoSteerVersion.json";
            LoadFromFile(VersionLocation);
        }

        public string AutoSteerVersion
        { get { return cAutoSteerVersion; } }

        public async Task<bool> GetHex()
        {
            bool Result = false;
            string SavePath = mf.Tls.FirmwareDir() + "\\AutoSteerTeensyRVC.ino.hex";
            try
            {
                using (var cts = new CancellationTokenSource(TimeSpan.FromMinutes(2)))
                {
                    using (var response = await _httpClient.GetAsync(
                               HexFileURL,
                               HttpCompletionOption.ResponseHeadersRead,
                               cts.Token))
                    {
                        response.EnsureSuccessStatusCode();

                        using (var contentStream = await response.Content.ReadAsStreamAsync())
                        using (var fileStream = new FileStream(
                                   SavePath,
                                   FileMode.Create,
                                   FileAccess.Write,
                                   FileShare.None,
                                   bufferSize: 81920,
                                   useAsync: true))
                        {
                            await contentStream.CopyToAsync(fileStream, 81920, cts.Token);
                        }
                    }
                    Result = true;
                }
            }
            catch (Exception ex)
            {
                mf.Tls.ShowHelp("Hex update failed: " + ex.Message);
            }
            return Result;
        }

        public async Task<bool> HasVersionChanged()
        {
            bool Result = true;
            try
            {
                string NewJson = await _httpClient.GetStringAsync(VersionsURL);

                if (File.Exists(VersionLocation))
                {
                    string ExistingJson = File.ReadAllText(VersionLocation);
                    Result = (ExistingJson != NewJson);
                }

                if (Result)
                {
                    File.WriteAllText(VersionLocation, NewJson);
                    LoadFromFile(VersionLocation);
                }
            }
            catch (Exception ex)
            {
                mf.Tls.ShowHelp("Version update failed: " + ex.Message);
            }
            return Result;
        }

        private void LoadFromFile(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                JObject jsonObj = JObject.Parse(json);
                cAutoSteerVersion = null;
                if (jsonObj["0"] != null && jsonObj["0"]["version"] != null)
                {
                    cAutoSteerVersion = (string)jsonObj["0"]["version"];
                }
            }
        }
    }
}