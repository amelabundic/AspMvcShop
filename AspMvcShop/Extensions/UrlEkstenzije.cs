using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AspMvcShop.Extensions
{
    public static class UrlEkstenzije
    {
        public static string PutanjaQueryString(this HttpRequest zahtjev)
        {
            if (zahtjev.QueryString != null)
            {
                return $"{zahtjev.Path}{zahtjev.QueryString}";
            }
            else
            {
                return zahtjev.Path.ToString();
            }
        }
    }
}
