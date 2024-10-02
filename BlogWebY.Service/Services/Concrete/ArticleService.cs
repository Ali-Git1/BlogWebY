﻿using BlogWebY.Data.UnitOfWorks;
using BlogWebY.Entity.Entities;
using BlogWebY.Service.Services.Abstractions;

namespace BlogWebY.Service.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;

        public ArticleService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<Article>> GetAllArticleAsync()
        {
            return await unitOfWork.GetRepository<Article>().GetAllAsync();
        }
    }
}
