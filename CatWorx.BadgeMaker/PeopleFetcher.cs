using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
    class PeopleFetcher
    {
        async public static Task<List<Employee>> GetFromApi()
        {
            List<Employee> employees = new List<Employee>();

            using (HttpClient client = new HttpClient())
            {
                string response = await client.GetStringAsync("https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture");
            }
            return employees;
        }
    }
}