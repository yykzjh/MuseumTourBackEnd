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
    [Route("Comment")]
    [ApiController]
    public class CommentController : Controller
    {
        private readonly MuseumContext _museumContext;

        public CommentController(MuseumContext museumContext)
        {
            _museumContext = museumContext;
        }

        //GET: MuseumTourBackEnd/Collection/AllCommentDetails
        [HttpGet]
        [Route("AllCommentDetails")]
        public JsonResult AllCommentDetails([FromQuery] int Midex)
        {
            return Json(_museumContext.Comment.Where(m => m.Midex == Midex).ToList());
        }

        //POST: MuseumTourBackEnd/Collection/Create
        [HttpPost]
        [Route("Create")]
        public JsonResult Create([FromBody] Comment newComment)
        {
            var searchComment = _museumContext.Comment
                .FirstOrDefault(m => m.Midex == newComment.Midex && m.Userid == newComment.Userid);
            int flag = 1;
            if (searchComment != null)
            {
                flag = 0;
            }
            else
            {
                _museumContext.Comment.Add(newComment);
                _museumContext.SaveChanges();
            }
            return Json(new { status = flag });
        }
    }
}
