﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //static turde newlenmiyor

        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Bakım zamanı.";
        public static string ProductsListed = "Ürünler listeleniyor..";
        public static string ProductDeleted = "Ürün silindi.";
        public static string ProductUpdated = "Ürün güncellendi.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Aynı isimde ürün eklenemez.";
        public static string CategoryLimitExceded = "Kategori limit sayisi 15'e ulasildi.";

        public static string OrderUpdated = "Sipariş güncellendi.";
        public static string OrderDeleted = "Sipariş silindi.";
        public static string OrderAdded = "Sipariş eklendi";
        public static string AuthorizationDenied="Yetki yok !";
    }
}
