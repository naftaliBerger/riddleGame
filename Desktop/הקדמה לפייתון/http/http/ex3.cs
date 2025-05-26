using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public class PostData
{
    public int userId { get; set; }
    public int id { get; set; }
    public string title { get; set; }
    public string body { get; set; }
}

class Program
{
    static async Task Main()
    {
        
        Console.Write("Enter userId: ");
        int userId = int.Parse(Console.ReadLine());

        Console.Write("Enter id: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("Enter title: ");
        string title = Console.ReadLine();

        Console.Write("Enter body: ");
        string body = Console.ReadLine();

     
        PostData newPost = new PostData
        {
            userId = userId,
            id = id,
            title = title,
            body = body
        };

        
        string jsonContent = JsonSerializer.Serialize(newPost);
        var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

        
        HttpClient client = new HttpClient();
        string url = "https://jsonplaceholder.typicode.com/posts";

        var response = await client.PostAsync(url, httpContent);

        // בדיקה אם הצליח
        //if (response.IsSuccessStatusCode)
        //{
        //    string responseBody = await response.Content.ReadAsStringAsync();
        //    var createdPost = JsonSerializer.Deserialize<PostDataWithId>(responseBody);
           Console.WriteLine($"New post created with ID: {createdPost.id}");
        //}
        //else
        //{
        //    Console.WriteLine("Failed to create post.");
        //}
    }
}

// מחלקה מורחבת – כוללת גם את ה-id של הפוסט שהשרת מחזיר
//public class PostDataWithId : PostData
//{
//    public int id { get; set; }
//}
