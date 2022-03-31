using CarServiceManagementSystem.Data.Models;
using CarServiceManagementSystem.ViewModels.Orders;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.Services.Interfaces
{
    public interface ICarService
    {
        Car AddNewCar(NewOrderInputModel model, IdentityUser user);
    }
}
