using CarServiceManagementSystem.Data;
using CarServiceManagementSystem.Data.Models;
using CarServiceManagementSystem.Services.Interfaces;
using CarServiceManagementSystem.ViewModels.Orders;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.Services
{
    public class CarService : ICarService
    {
        private readonly ApplicationDbContext dbContext;

        public CarService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Car AddNewCar(NewOrderInputModel model, IdentityUser user)
        {
            Engine newEngine = new Engine()
            {
                Displacement = model.Displacement,
                HorsePower = model.HorsePower,
                EngineCode = model.EngineCode,
                CylindersCount = model.CylindersCount,
                FuelType = model.FuelType,
            };

            Car newCar = new Car()
            {
                Make = model.CarMake,
                Model = model.CarModel,
                Year = model.Year,
                Month = model.Month,
                LicencePlate = model.LicencePlate,
                VinNumber = model.VinNumber,
                FuelType = model.FuelType,
                Engine = newEngine,
                User = (ApplicationUser)user,
            };

            return newCar;
        }
    }
}
