using CarServiceManagementSystem.Services.Interfaces;
using CarServiceManagementSystem.ViewModels.Orders;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceManagementSystem.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrdersService orderService;

        public OrdersController(IOrdersService orderService)
        {
            this.orderService = orderService;
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(NewOrderInputModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            this.orderService.AddOrder(model, User.Identity.Name);

            return Redirect("/");
        }
    }
}
