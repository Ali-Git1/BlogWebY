using BlogWebY.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebY.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>,IEntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid ImageId { get; set; } = Guid.Parse("6EDD6CA6-6EEB-43B2-9FB8-D9D44669AD8A");
        public Image Image { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
