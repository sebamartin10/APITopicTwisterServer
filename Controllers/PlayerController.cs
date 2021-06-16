﻿using APITopicTwister.Model;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITopicTwister.Controllers
{
    public class PlayerController : Controller
    {
        [HttpPost]
        public Player CreatePlayer(string name) {
            PlayerService playerService = new PlayerService();
            Player player = playerService.CreatePlayer(name);
            return player;
           
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
