using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using MuseumTourBackEnd.Models;
namespace MuseumTourBackEnd.Controllers
{
    [Route("MuseumTourBackEnd/[controller]")]
    [ApiController]
    public class MaintableController : Controller
    {
        //[HttpGet]
        //[Route("")]
        public string Index()
        {
            return "This is MaintableController";
        }
        private readonly MuseumContext _museumContext;

        public MaintableController(MuseumContext museumContext)
        {
            _museumContext = museumContext;
        }

        // MuseumTourBackEnd/Maintable/MuseumFirstPageId 根据博物馆id查name和base
        [HttpPost]
        [Route("MuseumFirstPageId")]
        public JsonResult MuseumFirstPageId([FromBody] Maintable maintable)
        {
            int flag = 0;
            var mbase = "Not found";
            var mname = "Not found";
            var searchMuseum = _museumContext.Maintable.FirstOrDefault(m => m.Midex == maintable.Midex);

            if (searchMuseum != null)
            {
                mname = searchMuseum.Mname;
                mbase = searchMuseum.Mbase;
                flag = 1;
            }
            var returnMesg = new { status = flag, Mname = mname, Mbase = mbase };
            return Json(returnMesg);
        }

        // MuseumTourBackEnd/Maintable/AllMuseums 返回所有博物馆的id+name+base
        [HttpGet]
        [Route("AllMuseums")]
        public JsonResult AllMuseums()
        {
            return Json(new { status = 1, _museumContext.Maintable });
        }
        // MuseumTourBackEnd/Maintable/MuseumFirstPageName 根据关键字模糊查询博物馆信息
        [HttpGet]
        [Route("MuseumFirstPageName")]
        public JsonResult MuseumFirstPageName([FromBody] Maintable maintable)
        {
            int flag = 0;
            var searchMuseum = _museumContext.Maintable.Where(m => m.Mname.Contains(maintable.Mname));
            if (searchMuseum != null && searchMuseum.Count() != 0)
            {
                flag = 1;
            }
            return Json(new { status = flag, searchMuseum });
        }
    }
}
