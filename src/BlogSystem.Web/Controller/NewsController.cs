using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSystem.Ability.Docking.NewsApp;
using BlogSystem.Ability.Docking.NewsApp.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BlogSystem.Web.Controller
{
    public class NewsController : BaseController
    {
        public INewsServicer newsServicer { get; set; }
        [HttpGet]
        public async Task<List<NewsDto>> GetNewsDtoAysnc()
        {
            return await newsServicer.GetNewsDtoAysnc();
        }
    }
}