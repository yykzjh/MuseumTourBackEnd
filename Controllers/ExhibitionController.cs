using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MuseumTourBackEnd.Models;

namespace MuseumTourBackEnd.Controllers
{
    [Route("Exhibition")]
    [ApiController]
    public class ExhibitionController : Controller
    {
        public string Index()
        {
            return "This id Exhibition Controller";
        }
        private readonly MuseumContext _museumContext;

        public ExhibitionController(MuseumContext museumContext)
        {
            _museumContext = museumContext;
        }
        //Get: MuseumTourBackEnd/Exhibition/AllExhibitions 返回所有的展览
        [HttpGet]
        [Route("AllExhibitions")]
        public JsonResult AllExhibitions()
        {
            return Json(new {_museumContext.Exhibition });
        }
        //Post: MuseumTourBackEnd/Exhibition/ExhibitionsOfMidex 根据博物馆id查询该馆展览
        [HttpPost]
        [Route("ExhibitionsOfMidex")]
        public JsonResult ExhibitionsOfMidex([FromBody] Exhibition E)
        {
            var search = _museumContext.Exhibition.Where(e => e.Midex == E.Midex);
            return Json(new { search });
        }
        //Post: MuseumTourBackEnd/Exhibition/SearchByEid 根据展览id查询该展览其他信息
        [HttpPost]
        [Route("SearchByEid")]
        public JsonResult SearchByEid([FromBody] Exhibition E)
        {
            int Midex = 0;
            var Ename = "Not found";
            var Eintro = "Not found";
            var search = _museumContext.Exhibition.FirstOrDefault(m => m.Eid == E.Eid);
            if (search != null)
            {
                Midex = search.Midex;
                Ename = search.Ename;
                Eintro = search.Eintro;
            }
            return Json(new { midex = Midex, ename = Ename, eintro = Eintro });
        }
        //Get: MuseumTourBackEnd/Exhibition/SearchByName 根据关键字模糊查询所有名称符合的展览
        [HttpGet]
        [Route("SearchByName")]
        public JsonResult SearchByName([FromBody] Exhibition E)
        {
            var search = _museumContext.Exhibition.Where(e => e.Ename.Contains(E.Ename));
            return Json(new { search });
        }
    }
}
