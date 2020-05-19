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

        //POST: MuseumTourBackEnd/User/Loogin
        [HttpPost]
        [Route("Login")]
        public JsonResult Login([FromBody] JObject jsonObj)
        {
            //序列化JObject对象为Json字符串
            var jsonStr = JsonConvert.SerializeObject(jsonObj);
            //反序列化Json字符串为动态Object
            var objParams = JsonConvert.DeserializeObject<dynamic>(jsonStr);

            string Userid = objParams.Userid;
            string Userpwd = objParams.Userpwd;
            var searchUser = _museumContext.User.FirstOrDefault(
                m => m.Userid == Userid );

            if (searchUser != null)
            {
                return Json(new {status = 1});
            }
            else
            {
                return Json(new {status = 0});
            }
            
        }

        //GET: MuseumTourBackEnd/User/Details
        [HttpGet]
        [Route("Details")]
        public JsonResult Details([FromQuery] string Userid)
        {
            var searchUser = _museumContext.User.FirstOrDefault(
                m => m.Userid == Userid);
            if (searchUser != null)
            {
                return Json(new
                {
                    status = 1,
                    id = searchUser.Userid,
                    pwd = searchUser.Userpwd,
                    coright = searchUser.Coright
                });
            }
            else
            {
                return Json(new { status = 0 });
            }
        }

        //GET: MuseumTourBackEnd/User/AllDetails
        [HttpGet]
        [Route("AllDetails")]
        public JsonResult AllDetails()
        {
            return Json(_museumContext.User);
        }

        //POST: MuseumTourBackEnd/User/Modify
        [HttpPost]
        [Route("Modify")]
        public JsonResult Modify([FromBody] User changeUser)
        {
            var searchUser = _museumContext.User.Find(changeUser.Userid);
            int flag = 1;
            if (searchUser == null)
            {
                flag = 0;
            }
            else
            {
                searchUser.Nickname = changeUser.Nickname;
                searchUser.Userpwd = changeUser.Userpwd;
                _museumContext.SaveChanges();
            }
            return Json(new { status = flag });
        }

        //GET: MuseumTourBackEnd/User/Delete
        [HttpGet]
        [Route("Delete")]
        public JsonResult Delete([FromQuery] string Userid)
        {
            var searchUser = _museumContext.User.Find(Userid);
            int flag = 1;
            if (searchUser != null)
            {
                _museumContext.User.Remove(searchUser);
                _museumContext.SaveChanges();
            }
            else
            {
                flag = 0;
            }
            return Json(new { status = flag });
        }

        //GET: MuseumTourBackEnd/User/Index
        [HttpGet]
        [Route("")]
        public string Index()
        {
            return "dajfdjfsdbfj";
        }
    }

    
}
