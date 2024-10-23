using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Youshow.Ace.Domain.Models;

namespace BlogSystem.Domain.NewsInfo
{
    public class Reply : BaseModel<int>
    {
        public int UserId{ get; set; }
        public String NickName{ get; set;}
        public String ReplyTitel{ get; set;}
        public String ReplyContent{ get; set;}
        public int NewsId{ get; set; }
        public DateTime ReplyDate{ get; set; }

    }
}