using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Youshow.Ace.Domain.Models;

namespace BlogSystem.Domain.NewsInfo
{
    public class News : BaseModel<int>
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

        //敏感词过滤
        public void ContentFiltre()
        {

        }
    }
}