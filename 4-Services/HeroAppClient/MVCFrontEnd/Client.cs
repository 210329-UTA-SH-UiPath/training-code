using MVCFrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVCFrontEnd
{
    public class Client
    {
        public IEnumerable<SuperHero> GetAllSuperHeroes(string url= "https://localhost:44315/api/superHeroDb")
        {
            //url = https://localhost:44315/api/superHeroDb
            using var client =new HttpClient();
            client.BaseAddress = new Uri(url);
            var response=client.GetAsync("");
            response.Wait();

            var result =response.Result;// this holds the output

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<SuperHero[]>();
                readTask.Wait();

                var superHeroes = readTask.Result;
                return superHeroes;
            }
            else
                return null;            
        }
    }
}
