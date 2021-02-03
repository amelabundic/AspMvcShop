using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using AspMvcShop.Models;

namespace AspMvcShop.Extensions
{
    public static class EkstenzijaSesije
    {
        public static void SerijalizujKorpu(this ISession sesija, string kljuc, Korpa korpa)
        {
            sesija.SetString(kljuc, JsonConvert.SerializeObject(korpa));
        }


        public static Korpa DeserijalizujKorpu(this ISession sesija, string kljuc)
        {
            string jsonString = sesija.GetString(kljuc);
            if (jsonString != null)
            {
                return JsonConvert.DeserializeObject<Korpa>(jsonString);
            }
            else
            {
                return null;
            }
        }
    }
}
