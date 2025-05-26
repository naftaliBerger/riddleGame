//הקוד קצת לא מסודר ,סליחה
//מה שעם הערה זה שאלה 1 ומה שבלי זה 2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;

namespace http

{
    public class CatData
    {
        public int userId { get; set; }
        public int id { get; set; }

        public string title { get; set; }
        public string body { get; set; }

    }
    //    public string url { get; set; }
    

        internal class Program
        {
            static async Task Main(string[] args)
            {
                //HttpClient clint = new HttpClient();
                //string url = "https://api.thecatapi.com/v1/images/search";
                //var r = await clint.GetAsync(url);
                //string ansewer = await r.Content.ReadAsStringAsync();
                //Console.WriteLine(ansewer);
                //CatData[] json = JsonSerializer.Deserialize<CatData[]>(ansewer);
                //Console.WriteLine(json[0].id);
                //Console.WriteLine(json[0].url);




            Console.WriteLine("enter a number(1 - 100): ");
            int num = int.Parse(Console.ReadLine());
            HttpClient client = new HttpClient();
            string url = "https://jsonplaceholder.typicode.com/posts";

            //var content = new StringContent(num, Encoding.UTF8, "string");
            //var reqwest = await client.PostAsync(url, content);
            if (num <= 100 && num > 0)
            {
                var respons = await client.GetAsync(url + $"?id={num}");
                string ansewer = await respons.Content.ReadAsStringAsync();
                CatData[] json = JsonSerializer.Deserialize<CatData[]>(ansewer);
                Console.WriteLine($"title: {json[0].title}");
                Console.WriteLine();
                Console.WriteLine($"body: {json[0].body}");


            }
            else
            {
                Console.WriteLine("Try again");
            }


            //for (int i = 0;i < 5;i++) 
            //{
            //   Console.WriteLine(json[i].title);
            //}




        }
        }
    
}


