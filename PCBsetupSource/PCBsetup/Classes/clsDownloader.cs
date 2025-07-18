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
            using (var cts = new CancellationTokenSource(TimeSpan.FromMinutes(2)))
            {
                using (var response = await _httpClient
                           .GetAsync(HexFilesURL, HttpCompletionOption.ResponseHeadersRead, cts.Token))
                {
                    response.EnsureSuccessStatusCode();

                    using (var contentStream = await response.Content.ReadAsStreamAsync())
                    using (var fileStream = new FileStream(
                               mf.Tls.FirmwareDir(),
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

            // extract
            string SourceFile = mf.Tls.FirmwareDir() + "\\ModulesHex.zip";
            if (Directory.Exists(mf.Tls.HexDir()) && mf.Tls.IsPathSafeToDelete(mf.Tls.HexDir()))
            {
                Directory.Delete(mf.Tls.HexDir(), true);
            }
            ZipFile.ExtractToDirectory(SourceFile, mf.Tls.HexDir());
        }
    }
}