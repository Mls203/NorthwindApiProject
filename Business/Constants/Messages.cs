using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "the product has been added";
        public static string ProductNameInvalid = "the product is invalid";
        public static string  MaintenanceTime="MaintenanceTime";
        public static string ProductListed = "product has been listed";
        public static string ProductCountOfCategoryError="Onşy 10 products from the same category can be added";
        public static string ProductNameAlreadyExists = "Product name is already exists";
        public static string ProductCategoryLimitExceded = "Category Limit is exceded";
        public static string AuthorizationDenied= "AuthorizationDenied";
        public static string UserAlreadyExists= "UserAlreadyExists";
        public static string AccessTokenCreated= "AccessTokenCreated";
        public static string PasswordError = "PasswordError";
        public static string SuccessfulLogin = "SuccessfulLogin";
        public static string UserNotFound = "UserNotFound";
        public static string UserRegistered = "UserRegistered";
    }
}
