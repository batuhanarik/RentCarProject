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
        public static string CarImageLimitExceeded="Car Image Limit Exceeded.";
        public static string CarImageIsNotExists="Car Imgaes Is Not Exists.";
        public static string AuthorizationDenied="Authorization was denied.";
        public static string UserRegistered="Başarıyla Kayıt Olundu";
        public static string UserNotFound = "Kullanıcı Bulunamadı.";
        public static string SuccessfulLogin = "Başarıyla Giriş Yapıldı";
        public static string UserAlreadyExists="Kullanıcı zaten mevcut.";
        public static string AccessTokenCreated="Erişim tokeni oluşturuldu.";
        public static string PasswordError = "Şifre hatalı";
    }
}
