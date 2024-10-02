using AutoMapper;
using BlogWebY.Data.UnitOfWorks;
using BlogWebY.Entity.DTOs.Articles;
using BlogWebY.Entity.Entities;
using BlogWebY.Service.Services.Abstractions;

namespace BlogWebY.Service.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public ArticleService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<List<ArticleDto>> GetAllArticleAsync()
        { 
           var articles=await unitOfWork.GetRepository<Article>().GetAllAsync();

           var map = mapper.Map<List<ArticleDto>>(articles);

            return map;
        }
    }
}
