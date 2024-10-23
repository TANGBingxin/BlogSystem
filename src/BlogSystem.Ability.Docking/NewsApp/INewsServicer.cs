using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSystem.Ability.Docking.NewsApp.Dto;
using Youshow.Ace.Ability.Services;

namespace BlogSystem.Ability.Docking.NewsApp
{
    public interface INewsServicer : IAbilityServicer
    {
        public Task<List<NewsDto>> GetNewsDtoAysnc();
    }
}