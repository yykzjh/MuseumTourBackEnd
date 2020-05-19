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
            var mni = "Not found";
            var mbase = "Not found";
            if (maintable.Mname == null)//根据midex查找对应的mname和mbase
            {
                var searchMuseum = _museumContext.Maintable.FirstOrDefault(m => m.Midex == maintable.Midex);
           
                if (searchMuseum != null)
                {
                    mni = searchMuseum.Mname;
                    mbase = searchMuseum.Mbase;
                }
                var returnMesg = new { Mname = mni, Mbase = mbase };
                return Json(returnMesg);
            }
            else//根据mname查找对应的midex和mbase 根据名字查看博物馆简介
            {
                var searchMuseum = _museumContext.Maintable.FirstOrDefault(m => m.Mname == maintable.Mname);
                
                if (searchMuseum != null)
                {
                    mni = searchMuseum.Midex.ToString();
                    mbase = searchMuseum.Mbase;

                }
                var returnMesg = new { Midex = mni, Mbase = mbase };
                return Json(returnMesg);
            }
        }

        // /MuseumTourBackEnd/Maintable/AllMuseums 返回所有博物馆的id和name（和base）超级慢
        [HttpPost]
        [Route("AllMuseums")]
        public JsonResult AllMuseums()
        {
            var data = new List<Object>();
            int id=1;
            var searchMuseum = _museumContext.Maintable.FirstOrDefault(m => m.Midex == id);
            data.Add(new
            {
                midex = searchMuseum.Midex,
                mname = searchMuseum.Mname,
                //mbase = searchMuseum.Mbase//too big
            });
            id++;
            while (true)
            {
                searchMuseum = _museumContext.Maintable.FirstOrDefault(m => m.Midex == id);
                if (searchMuseum == null)
                {
                    break;
                }
                data.Add(new
                {
                    midex = searchMuseum.Midex,
                    mname = searchMuseum.Mname,
                    //mbase = searchMuseum.Mbase,
                    //NU= searchMuseum.Mname==null?1:0
                });
                id++;
            }
            //return Json(data);//这个最外面没有{ } 返回一个[ ]
            return Json(new { Museums = data });
        }
    }
}
