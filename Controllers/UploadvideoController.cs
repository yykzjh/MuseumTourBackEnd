using Microsoft.AspNetCore.Mvc;
using MuseumTourBackEnd.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Net.Http.Headers;
using System.Collections.Generic;

namespace MuseumTourBackEnd.Controllers
{
    [Route("MuseumTourBackEnd/UploadVideo")]
    [ApiController]
    public class UploadVideoController : Controller
    {
        private readonly MuseumContext _museumContext;
        public UploadVideoController(MuseumContext museumContext)
        {
            _museumContext = museumContext;
        }

        [HttpPost]
        [Route("Uploading")]
        public JsonResult Uploading([FromQuery] int Oid, [FromForm] IFormFile file)
        {
            if (file.Length > 0)
            {
                //声明新实体
                Uploadvideo newVideo = new Uploadvideo();
                newVideo.OriginName = file.FileName;//加入原文件名

                //分离出文件后缀
                string[] getarr = newVideo.OriginName.Split('.');

                string newFileName = Path.GetRandomFileName();//随机生成新文件名
                string[] getAry = newFileName.Split('.');//分离出错误后缀

                //加上正确后缀
                newFileName = getAry[0] + "." + getarr[1];

                newVideo.Address = Path.Combine(@".\UploadVideo",
                       newFileName);//生成新存储路径
                newVideo.Status = -1;
                newVideo.Oid = Oid;

                _museumContext.Uploadvideo.Add(newVideo);
                _museumContext.SaveChanges();//加入数据库
                using (var stream = System.IO.File.Create(newVideo.Address))
                {
                    file.CopyTo(stream);
                    stream.Flush();//保存到本地

                }
                return Json(new
                {
                    status = 1,
                    filename = newVideo.OriginName,
                    pathname = newVideo.Address
                });
            }
            else
            {
                return Json(new { status = 0 });
            }
        }

        [HttpGet]
        [Route("DownVideo")]
        public JsonResult DownVideo([FromQuery] int Oid)
        {

        }
    }

}
