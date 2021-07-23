<<<<<<< HEAD
﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
=======
﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
>>>>>>> 627b3ef1aea05dfbd713aa6e3f87673f5da5840c
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductsListed = "Ürünler Listelendi";
<<<<<<< HEAD

        public static string ProductCountOfCategory = "Kategoride olan ürün sayısı 10'u geçemez";
        public static string ProductNameAlreadyExists = "Bu isim de zaten başka bir ürün var";
        public static string CategoryLimitExceded ="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        internal static string UserRegistered;
        internal static User UserNotFound;
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
=======
>>>>>>> 627b3ef1aea05dfbd713aa6e3f87673f5da5840c
    }
}
