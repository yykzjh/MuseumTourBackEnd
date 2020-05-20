using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MuseumTourBackEnd.Models;

namespace MuseumTourBackEnd.Controllers
{
    [Route("MuseumTourBackEnd/[controller]")]
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
        // MuseumTourBackEnd/Exhibition/AllExhibitions 返回所有的展览
        [HttpGet]
        [Route("AllExhibitions")]
        public JsonResult AllExhibitions()
        {
            return Json(new { status = 1, _museumContext.Exhibition });
        }
        // MuseumTourBackEnd/Exhibition/ExhibitionsOfMidex 根据博物馆id查询该馆展览
        [HttpPost]
        [Route("ExhibitionsOfMidex")]
        public JsonResult ExhibitionsOfMidex([FromBody] Exhibition E)
        {
            int flag = 0;
            var search = _museumContext.Exhibition.Where(e => e.Midex == E.Midex);
            if (search != null) flag = 1;
            return Json(new { status = flag,  search});
        }
        // MuseumTourBackEnd/Exhibition/SearchByEid 根据展览id查询该展览其他信息
        [HttpPost]
        [Route("SearchByEid")]
        public JsonResult SearchByEid([FromBody] Exhibition E)
        {
            int flag = 0;
            int Midex = 0;
            var Ename = "Not found";
            var Eintro = "Not found";
            var search = _museumContext.Exhibition.FirstOrDefault(m => m.Eid == E.Eid);
            if (search != null)
            {
                flag = 1;
                Midex = search.Midex;
                Ename = search.Ename;
                Eintro = search.Eintro;
            }
            return Json(new { status = flag, midex = Midex, ename = Ename, eintro = Eintro });
        }
        // MuseumTourBackEnd/Exhibition/SearchByName 根据关键字模糊查询所有名称符合的展览
        [HttpGet]
        [Route("SearchByName")]
        public JsonResult SearchByName([FromBody] Exhibition E)
        {
            int flag = 0;
            var search = _museumContext.Exhibition.Where(e => e.Ename.Contains(E.Ename));
            if (search != null && search.Count() != 0)
            {
                flag = 1;
            }
            return Json(new { status = flag, search });
        }
    }
}
