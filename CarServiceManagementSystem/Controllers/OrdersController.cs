using CarServiceManagementSystem.ViewModels.Orders;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceManagementSystem.Controllers
{
    public class OrdersController : Controller
    {
        public OrdersController()
        {

        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(NewOrderInputModel model)
        {
            return null;
        }
    }
}
