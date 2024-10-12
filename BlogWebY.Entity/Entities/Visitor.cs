using BlogWebY.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebY.Entity.Entities
{
    public class Visitor : IEntityBase
    {
        public Visitor() { }
        
            
        
        public Visitor(string ipAdress,string userAgent)
        {
            IpAdress = ipAdress;
            UserAgent = userAgent;
        }

        public int Id { get; set; }
        public string IpAdress { get; set; }
        public string UserAgent { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public ICollection<ArticleVisitor> ArticleVisitors { get; set; }


    }
}
