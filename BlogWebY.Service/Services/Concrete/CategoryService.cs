using AutoMapper;
using BlogWebY.Data.UnitOfWorks;
using BlogWebY.Entity.DTOs.Categories;
using BlogWebY.Entity.Entities;
using BlogWebY.Service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWebY.Service.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CategoryService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<List<CategoryDto>> GetAllCategoriesNonDeleted()
        {
            var categories= await unitOfWork.GetRepository<Category>().GetAllAsync(x=>!x.IsDeleted);
            var map=mapper.Map<List<CategoryDto>>(categories);

            return map;
        }
    }
}
