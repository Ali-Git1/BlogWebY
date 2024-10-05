using BlogWebY.Core.Entities;

namespace BlogWebY.Entity.Entities
{
    public class Category :EntityBase,IEntityBase
    {
        public Category()
        {
            
        }

        public Category(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
