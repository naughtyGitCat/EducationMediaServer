
using System.Net;
using System.Runtime.Serialization;
using System.IO;
using System;
using System.Net.Http;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace EductationMediaServer.Controllers;


[Route("api/[controller]")]
public class VideoController : ControllerBase
{
    [HttpGet]
 public object Get()
 {
    var filename="cawd-112.mp4";
    var filesteam = System.IO.File.OpenRead($"E:/迅雷下载/cawd-112/{filename}");
    return Results.File(filesteam, "video/mp4", fileDownloadName: filename, enableRangeProcessing: true);
 }
}