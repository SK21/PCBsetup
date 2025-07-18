using PCBsetup.Forms;
using System;
using System.IO;
using System.IO.Compression;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace PCBsetup.Classes
{
    public class clsDownloader
    {
        private static readonly HttpClient _httpClient = new HttpClient();
        private string HexFilesURL = "https://github.com/SK21/AOG_RC/releases/latest/download/ModulesHex.zip";
        private frmMain mf;

        public clsDownloader(frmMain CalledFrom)
        {
            mf = CalledFrom;
        }

        public async Task Download()
        {
            string firmwareDir = mf.Tls.FirmwareDir();
            string hexDir = mf.Tls.HexDir();
            string zipPath = Path.Combine(firmwareDir, "ModulesHex.zip");

            try
            {
                using (var cts = new CancellationTokenSource(TimeSpan.FromMinutes(2)))
                {
                    using (var response = await _httpClient.GetAsync(
                               HexFilesURL,
                               HttpCompletionOption.ResponseHeadersRead,
                               cts.Token))
                    {
                        response.EnsureSuccessStatusCode();

                        using (var contentStream = await response.Content.ReadAsStreamAsync())
                        using (var fileStream = new FileStream(
                                   zipPath,
                                   FileMode.Create,
                                   FileAccess.Write,
                                   FileShare.None,
                                   bufferSize: 81920,
                                   useAsync: true))
                        {
                            await contentStream.CopyToAsync(fileStream, 81920, cts.Token);
                        }
                    }
                }

                if (Directory.Exists(hexDir) && mf.Tls.IsPathSafeToDelete(hexDir)) Directory.Delete(hexDir, recursive: true);
                ZipFile.ExtractToDirectory(zipPath, firmwareDir);
            }
            catch (OperationCanceledException)
            {
                mf.Tls.ShowHelp("Download canceled or timed out.");
            }
            catch (Exception ex)
            {
                mf.Tls.ShowHelp("Failed to update firmware.  " + ex.Message, "Help", 5000, true);
            }
        }
    }
}