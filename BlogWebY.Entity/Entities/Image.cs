using BlogWebY.Core.Entities;

namespace BlogWebY.Entity.Entities
{
    public class Image : EntityBase, IEntityBase
    {
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }

        public ICollection<Article> Articles { get; set; }


    }
}
