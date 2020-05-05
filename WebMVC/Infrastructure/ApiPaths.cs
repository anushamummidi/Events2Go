using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVC.Infrastructure
{
    public class ApiPaths
    {
        public static class Catalog
        {
            public static string GetAllCatalogItems(string baseUri, int page, int take, int? type ,int? location)
            {
                var filterQs = string.Empty;
                if (type.HasValue || location.HasValue)
                {
                    var typeQs = (type.HasValue) ? type.Value.ToString() : "null";
                    var locationQs = (location.HasValue) ? location.Value.ToString() : "null";
                    filterQs = $"/type/{typeQs}/location/{locationQs}";
                }
                    return $"{baseUri}items{filterQs}?pageIndex={page}&pageSize={take}";
            }
            public static string GetAllTypes(string baseUri)
            {
                return $"{baseUri}eventtypes";
            }
            public static string GetAllLocations(string baseUri)
            {
                return $"{baseUri}eventlocations";
            }

        }

        public static class Basket
        {

            public static string GetBasket(string baseUri, string basketId)
            {
                return $"{baseUri}/{basketId}";
            }

            public static string UpdateBasket(string baseUri)
            {
                return baseUri;
            }

            public static string CleanBasket(string baseUri, string basketId)
            {
                return $"{baseUri}/{basketId}";
            }

        }

        public static class Order
        {
            public static string GetOrder(string baseUri, string orderId)
            {
                return $"{baseUri}/{orderId}";
            }

            //public static string GetOrdersByUser(string baseUri, string userName)
            //{
            //    return $"{baseUri}/userOrders?userName={userName}";
            //}
            public static string GetOrders(string baseUri)
            {
                return baseUri;
            }
            public static string AddNewOrder(string baseUri)
            {
                return $"{baseUri}/new";
            }
        }


    }

}
