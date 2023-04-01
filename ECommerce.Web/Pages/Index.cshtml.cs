
using ECommerce.Contracts.Categories;
using ECommerce.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.WebSockets;

namespace NeilMacabulos.Prelim2ndSem_.Pages
{
    public class Index : PageModel
    {
        private readonly ILogger<Index> _logger;
        private readonly ICategoriesService _categoriesService;
        public Index(ILogger<Index> logger, ICategoriesService categoriesService)
        {
            _logger = logger;
            _categoriesService = categoriesService;
        }

        public void OnGet()
        {

            this.Categories = _categoriesService.GetAll();

        }

        public List<CategoriesDto> Categories { get; set; }
    }
}