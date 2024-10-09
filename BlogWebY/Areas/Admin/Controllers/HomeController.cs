using BlogWebY.Entity.Entities;
using BlogWebY.Service.Services.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BlogWebY.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IArticleService articleService;

        public HomeController(IArticleService articleService)
        {
            this.articleService = articleService;
        }
        public async Task<IActionResult> Index()
        {
            var articles=await articleService.GetAllArticlesWithCategoryNonDeletedAsync();

            return View(articles);
        }
    }
}
