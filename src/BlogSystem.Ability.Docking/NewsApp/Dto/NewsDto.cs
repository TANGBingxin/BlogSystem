using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Youshow.Ace.Ability.Dtos;

namespace BlogSystem.Ability.Docking.NewsApp.Dto
{
    public class NewsDto : BaseModelDto<int>
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string key { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int Hit { get; set; }
        public int ReplyCount { get; set; }
        public DateTime PublishTime { get; set; }
    }
}