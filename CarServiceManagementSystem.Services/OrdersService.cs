using CarServiceManagementSystem.Data;
using CarServiceManagementSystem.Data.Models;
using CarServiceManagementSystem.Services.Interfaces;
using CarServiceManagementSystem.ViewModels.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ICarService carService;

        public OrdersService(ApplicationDbContext dbContext, ICarService carService)
        {
            this.dbContext = dbContext;
            this.carService = carService;
        }

        public void AddOrder(NewOrderInputModel model, string userName)
        {
            var user = dbContext.Users
                .Where(u => u.UserName == userName)
                .FirstOrDefault();

            Car car = carService.AddNewCar(model, user);

            Order newOrder = new Order()
            {
                Date = model.Date,
                IssueDescription = model.IssueDescription,
                PhoneNumber = model.PhoneNumber,
                Car = car,
                User = (ApplicationUser)user,
                Status = Data.Enums.Status.Pending
            };

            dbContext.Add(newOrder);
            dbContext.SaveChanges();
        }
    }
}
