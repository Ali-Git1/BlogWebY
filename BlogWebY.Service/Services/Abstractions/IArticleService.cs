using BlogWebY.Entity.DTOs.Articles;

namespace BlogWebY.Service.Services.Abstractions
{
    public interface IArticleService
    {
        Task<List<ArticleDto>> GetAllArticlesWithCategoryNonDeletedAsync();
    }
}
