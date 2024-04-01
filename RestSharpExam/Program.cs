using System;
using Newtonsoft.Json.Linq;
using RestSharp;

class Program
{
    static async Task Main(string[] args)
    {
        var client = new RestClient("https://simple-books-api.glitch.me");
        var request = new RestRequest("/books", Method.Get);
        var response = await client.ExecuteAsync(request);
        Console.WriteLine(response.StatusCode);
        
        if ((int)response.StatusCode == 200)
        {
            Console.WriteLine("Status code is 200");
            JArray books = JArray.Parse(response.Content);

            if (books.Count > 0 && books[0]["id"] != null)
            {
                Console.WriteLine("Response body contains 'id' for book 1");
            }

            if (books.Count > 1 && books[1]["name"] != null)
            {
                Console.WriteLine("Response body contains 'name' for book 2");
            }

            if (books.Count > 2 && books[2]["type"] != null)
            {
                Console.WriteLine("Response body contains 'type' for book 3");
            }

            foreach (JObject book in books)
            {
                if ((string)book["name"] == "Just as I Am")
                {
                    bool available = (bool)book["available"];
                    if (!available)
                    {
                        Console.WriteLine("Response body contains the book 'Just as I Am' as Unavailable");
                    }
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Failed to get a successful response from the API: " + response.StatusCode);
        }
    }
}
