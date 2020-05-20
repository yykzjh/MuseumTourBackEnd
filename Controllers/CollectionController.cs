using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MuseumTourBackEnd.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MuseumTourBackEnd.Controllers
{
    [Route("MuseumTourBackEnd/Collection")]
    [ApiController]
    public class CollectionController:Controller
    {
        private readonly MuseumContext _museumContext;

        public CollectionController(MuseumContext museumContext)
        {
            _museumContext = museumContext;
        }

        //GET:  MuseumTourBackEnd/Collection/CollectionList
        [HttpGet]
        [Route("CollectionList")]
        public JsonResult CollectionList([FromQuery] int Midex)
        {
            return Json(_museumContext.Collection.Where(m => m.Midex == Midex)
                .Select(m => new { oid = m.Oid, oname = m.Oname }).ToList());
        }

        //GET: MuseumTourBackEnd/Collection/SingleColleciotnInstruction
        [HttpGet]
        [Route("SingleColleciotnInstruction")]
        public JsonResult SingleColleciotnInstruction([FromQuery] int Oid)
        {
            return Json(_museumContext.Collection.FirstOrDefault(m => m.Oid == Oid));
        }

        //GET: MuseumTourBackEnd/Collection/CollectionAllDetails
        [HttpGet]
        [Route("CollectionAllDetails")]
        public JsonResult CollectionAllDetails([FromQuery] int Midex)
        {
            return Json(_museumContext.Collection.Where(m => m.Midex == Midex).ToList());
        }
    }
}
