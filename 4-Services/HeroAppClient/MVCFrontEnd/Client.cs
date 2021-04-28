using MVCFrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;

namespace MVCFrontEnd
{
    public class Client
    {
        string url = "https://localhost:44315/api/superHeroDb/";
        public IEnumerable<SuperHero> GetAllSuperHeroes()
        {
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

        public async void UpdateSuperHero(SuperHero sh)
        {
        }

        public SuperHero GetSuperHeroById(int id)
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(url+id);
            var response = client.GetAsync("");
            response.Wait();

            var result = response.Result;// this holds the output

            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsAsync<SuperHero>();
                readTask.Wait();

                var superHeroes = readTask.Result;
                return superHeroes;
            }
            else
                return null;
        }
    
        public async void AddSuperHero(SuperHero superHero) {
            var json=JsonConvert.SerializeObject(superHero);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using var client = new HttpClient();
            var response=await client.PostAsync(url, data);
            var result=response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
        }

        public async void DeleteSuperHero(int id)
        {
        }
    }
}
