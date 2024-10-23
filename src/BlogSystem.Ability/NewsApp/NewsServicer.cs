using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BlogSystem.Ability.Docking.NewsApp;
using BlogSystem.Ability.Docking.NewsApp.Dto;
using BlogSystem.Domain.NewsInfo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Youshow.Ace.Ability;
using Youshow.Ace.Domain.Repository;

namespace BlogSystem.Ability.NewsApp
{
    public class NewsServicer : AbilityServicer, INewsServicer
    {
        public required IRepository<News> NewsRepo { get; set; }
        public async Task<List<NewsDto>> GetNewsDtoAysnc()
        {
            var newsList = await NewsRepo.OrderByDescending(e => e.PublishTime).ToListAsync();
            var newsDtos = ModelMapper.Map<List<News>, List<NewsDto>>(newsList);
            return newsDtos;
        }
    }
}