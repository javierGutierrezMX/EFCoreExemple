using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreExemple
{
    public class Blog
    {
        public int id { get; set; }
        public string Url { get; set; }
        public List<Post> Posts { get; set; }
    }
}
