using CarServiceManagementSystem.Data.Models;
using CarServiceManagementSystem.ViewModels.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.Services.Interfaces
{
    public interface IOrdersService
    {
        void AddOrder(NewOrderInputModel model, string userName);
    }
}
