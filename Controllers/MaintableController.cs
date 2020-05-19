using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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

        // /MuseumTourBackEnd/Maintable/MuseumFirstPage
        [HttpPost]
        [Route("MuseumFirstPage")]
        public JsonResult MuseumFirstPage([FromBody] Maintable maintable)//int midex
        {
            //返回midex对应的mname和mbase
            var searchMuseum = _museumContext.Maintable.FirstOrDefault(
                m => m.Midex == maintable.Midex);
            var mname = "Not found";
            var mbase = "Not found";
            if (searchMuseum != null)
            {
                mname = searchMuseum.Mname;
                mbase = searchMuseum.Mbase;
            }
            var returnMesg = new { Mname = mname, Mbase = mbase };
            return Json(returnMesg);
        }
    }
}