using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceManagementSystem.Common
{
    public static class GlobalConstants
    {
        public const string TooLongText = "{0} is too long, should be no more than {1} symbols!";

        public const string InvalidPhoneNumber = "Invalid number!";

        public const string InvalidManufacturerLength = "Manufacturer name must be between {2} and {1} characters!";

        public const string InvalidVehicleModelLength = "Vehicle model must be between {2} and {1} characters!";

        public const string InvalidVehicleProductionYear = "Vehicle must be manufactuered between {1} and {2} year!";

        public const string InvalidMonth = "Invalid month!";

        public const string InvalidVehicleRegistrationPlate = "Invalid registration plate! Example for valid registration plate - XX1111XX.";

        public const string InvalidVinNumber = "Invalid VIN number!";

        public const string InvalidEngineDisplacement = "Engine Displacement cannot be less than {1} and more than {2} cubic centimeters!";

        public const string InvalidEngineHorsePower = "Engine Horsepower must be a positive number, no higher than {2}!";

        public const string InvalidEngineCode = "Engine code must be no longer than {1} characters!";

        public const string InvalidEngineCylinderCount = "Invalid cylinder count!";
    }
}
