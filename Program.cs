// See https://aka.ms/new-console-template for more information
using AsyncImageDownload;
using System;

string imageUrl = "https://dfstudio-d420.kxcdn.com/wordpress/wp-content/uploads/2019/06/digital_camera_photo-980x653.jpg";
List<string> imagesUrls = new List<string>
{
    "https://cdn.pixabay.com/photo/2024/05/26/10/15/bird-8788491_1280.jpg",
    "https://buffer.com/library/content/images/size/w1200/2023/10/free-images.jpg",
    "https://t4.ftcdn.net/jpg/02/56/10/07/360_F_256100731_qNLp6MQ3FjYtA3Freu9epjhsAj2cwU9c.jpg",
    "https://fps.cdnpk.net/images/home/subhome-ai.webp?w=649&h=649"
};
string savePath = "C:\\Users\\Tsuni\\Desktop\\Test\\";

var Downloader = new ImageDownloader();
//try
//{
//    var imageData = await Downloader.DownloadImageAsync(imageUrl);
//    Console.WriteLine("Изображение успешно скачано");
//    await Downloader.SaveImageAsync(savePath + imageUrl.Split('/').Last().Split(".")[0] + ".jpg", imageData);
//    Console.WriteLine("Изображение успешно сохранено.");
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}

try
{
    await Downloader.DownloadAndSaveImagesAsyn(savePath, imagesUrls);
    Console.WriteLine("All images saved");
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}