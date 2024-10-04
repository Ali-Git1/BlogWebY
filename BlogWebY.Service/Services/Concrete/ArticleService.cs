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

        public async Task CreateArticleAsync(ArticleAddDto articleAddDto)
        {
            var userId = Guid.Parse("CEF5328A-BB41-4F5A-91F6-A8514570E453");

            var article = new Article
            {
                Title = articleAddDto.Title,
                Content = articleAddDto.Content,
                CategoryId = articleAddDto.CategoryId,
                UserId=userId
            };

            await unitOfWork.GetRepository<Article>().AddAsync(article);
            await unitOfWork.SaveAsync();
        }

        public async Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync(x => !x.IsDeleted,x=>x.Category);
            var map = mapper.Map<List<ArticleDto>>(articles);

            return map;
        }
    }
}
