using BlogWebY.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebY.Data.Mapping
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {

                Id = Guid.Parse("6EDD6CA6-6EEB-43B2-9FB8-D9D44669AD8A"),
                FileName = "images/testimage",
                FileType = "jpg",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false

            },
            new Image
            {
                 
                    Id = Guid.Parse("103D6C6B-7542-4A13-AFB0-F7E9F0E386B5"),
                    FileName = "images/vstest",
                    FileType = "png",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                
            });

        }
    }
}
