using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotnetAPI_Hello_World.Models;

namespace DotnetAPI_Hello_World.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrueController : Controller
    {
        [HttpGet]
        public JsonResult Test()
        {
            var name = new List<names>
            {
                new names {username = "rialaq98",    password = "1415168rd" },
                new names {username = "miguel_rojas98",     password = "rojasPower" },
                new names {username = "starling",   password = "MLebron" },
                new names {username = "pacoman",     password = "reylore" }

            };
            return Json(name);
        }
    }
}