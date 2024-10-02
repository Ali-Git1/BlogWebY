using BlogWebY.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebY.Service.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<Article>> GetAllArticleAsync();
    }
}
