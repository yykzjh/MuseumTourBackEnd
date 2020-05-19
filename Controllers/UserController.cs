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
    public class UserController : Controller
    {
        private readonly MuseumContext _museumContext;

        public UserController(MuseumContext museumContext)
        {
            _museumContext = museumContext;
        }

        //POST: MuseumTourBackEnd/Create
        [HttpPost]
        [Route("Create")]
        public JsonResult Create([FromBody] User newUser)
        {
            var searchUser = _museumContext.User.FirstOrDefault(
                m => m.Userid == newUser.Userid);
            int flag = 1;
            if (searchUser == null)
            {
                newUser.Coright = 1;
                _museumContext.Add(newUser);
                _museumContext.SaveChanges();
            }
            else
            {
                flag = 0;
            }
            var returnMesg = new { status = flag };
            return Json(returnMesg);
        }

        //GET MuseumTourBackEnd/User/Index
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "dajfdjfsdbfj";
        }
    }

    
}
