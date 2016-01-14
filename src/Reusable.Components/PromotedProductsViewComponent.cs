using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace Reusable.Components
{
    [ViewComponent(Name = "PromotedProducts")]
    public class PromotedProductsViewComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public PromotedProductsViewComponent()
        {
            _productService = new ProductService();
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = await _productService.GetPromotedProducts();
            return View(products);
        }
    }

}
