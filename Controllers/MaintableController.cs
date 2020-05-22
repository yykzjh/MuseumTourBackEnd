using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MuseumTourBackEnd.Models;

namespace MuseumTourBackEnd.Controllers
{
    [Route("Maintable")]
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

        //Post: MuseumTourBackEnd/Maintable/MuseumFirstPageId 根据博物馆id查name和base
        [HttpPost]
        [Route("MuseumFirstPageId")]
        public JsonResult MuseumFirstPageId([FromBody] Maintable maintable)
        {
            var mbase = "Not found";
            var mname = "Not found";
            var searchMuseum = _museumContext.Maintable.FirstOrDefault(m => m.Midex == maintable.Midex);

            if (searchMuseum != null)
            {
                mname = searchMuseum.Mname;
                mbase = searchMuseum.Mbase;
            }
            var returnMesg = new { Mname = mname, Mbase = mbase };
            return Json(returnMesg);
        }

        //Get: MuseumTourBackEnd/Maintable/AllMuseums 返回所有博物馆的id+name+base
        [HttpGet]
        [Route("AllMuseums")]
        public JsonResult AllMuseums()
        {
            return Json(new { _museumContext.Maintable });
        }
        //Get: MuseumTourBackEnd/Maintable/MuseumFirstPageName 根据关键字模糊查询博物馆信息
        [HttpGet]
        [Route("MuseumFirstPageName")]
        public JsonResult MuseumFirstPageName([FromBody] Maintable maintable)
        {

            var searchMuseum = _museumContext.Maintable.Where(m => m.Mname.Contains(maintable.Mname));
            return Json(new { searchMuseum });
        }
    }
}
