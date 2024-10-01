using BlogWebY.Core.Entities;

namespace BlogWebY.Entity.Entities
{
    public class Category :EntityBase,IEntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
