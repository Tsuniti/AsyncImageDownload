using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AsyncImageDownload;

public  class ImageDownloader
{
    HttpClient client = new HttpClient();

    public async Task<byte[]> DownloadImageAsync(string url) => await client.GetByteArrayAsync(url);


    public async Task SaveImageAsync(string savePath, byte[] imageData) => await File.WriteAllBytesAsync(savePath, imageData);
    
    public async Task DownloadAndSaveImagesAsyn(string savePath, IEnumerable<string> urls)
    {
        foreach (string url in urls)
        {
            await SaveImageAsync(savePath + url.Split('/').Last().Split(".")[0] + ".jpg", await DownloadImageAsync(url));
        }
    }
}
