using AutoMapper;
using BlogWebY.Entity.DTOs.Articles;
using BlogWebY.Entity.Entities;

namespace BlogWebY.Service.AutoMapper.Articles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleDto, Article>().ReverseMap();
            CreateMap<ArticleUpdateDto, Article>().ReverseMap();
            CreateMap<ArticleUpdateDto, ArticleDto>().ReverseMap();
        }
    }
}
