using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Car Added";
        public static string CarListed = "Cars Listed";
        public static string CarDeleted= "Car Deleted";
        public static string CarUpdated= "Car Updated";
        public static string CarNameInvalid= "Car Name Invalid";
        public static string CarListedByBrand = "Cars Listed By Brand";
        public static string CarListedByColor = "Cars Listed By Color";
        public static string RentalAdded = "Rental Added";
        public static string RentalInvalid = "Rental is Invalid.";
        internal static string CarImageLimitExceeded="Car Image Limit Exceeded.";
        internal static string CarImageIsNotExists="Car Imgaes Is Not Exists.";
        internal static string AuthorizationDenied="Authorization was denied.";
        internal static string UserRegistered;
        internal static User UserNotFound;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
        internal static User PasswordError;
    }
}
