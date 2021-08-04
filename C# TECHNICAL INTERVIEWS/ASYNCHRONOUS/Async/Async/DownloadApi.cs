using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Async
{
    public class DownloadApi
    {
        public DownloadApi()
        {
            
        }
        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"c:\Projects\result.html"))
            {
                await streamWriter.WriteLineAsync(html);
            }
        }


    }
}