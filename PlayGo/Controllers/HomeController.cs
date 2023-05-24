using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlayGo.Infrastructure.Repositories.Interfaces;
using PlayGo.Models;
using PlayGo.Models.Abstract;
using PlayGo.Models.DTO_s;
using System.Diagnostics;

namespace PlayGo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryRepository _categoryRepo;
        private readonly IProductRepository _productRepo;

        public HomeController(ILogger<HomeController> logger, ICategoryRepository categoryRepo, IProductRepository productRepo)
        {
            _logger = logger;
            _categoryRepo = categoryRepo;
            _productRepo = productRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> CategoryList()
        {
            var categories = await _categoryRepo.GetFilteredList
                (
                select: x => new CategoryListVM
                {
                    Id = x.Id,
                    Name = x.Name,
                    Image = x.Image,
                },
                where: x => x.Status != Status.Passive
                ); 
            return View(categories);
        }

        public async Task<IActionResult> ProductList()
        {
            var products = await _productRepo.GetFilteredList
                (
                    select: x => new ProductListVM
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Image = x.Image,
                        Status = x.Status,
                        
                    },
                    where: x => x.Status != Status.Passive
                );

            return View(products);
        }
        public async Task<IActionResult> ProductDetail(int id)
        {
            var product = await _productRepo.GetByIdAsync(id);
            var category = await _categoryRepo.GetByIdAsync(product.CategoryId);
            ProductDetailVM detailVM = new ProductDetailVM
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                UnitPrice = product.UnitPrice,
                CreatedDate = product.CreatedDate,
                Image = product.Image,
                Status = product.Status,
                CategoryName = category.Name
            };
            return View(detailVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}