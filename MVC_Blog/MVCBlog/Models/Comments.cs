using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBlog.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Post Post { get; set; }
    }
}