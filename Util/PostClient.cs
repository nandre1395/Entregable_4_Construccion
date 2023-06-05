using Entregable4.Model;
using System.Text.Json;

namespace Entregable4.Util
{
    public class PostClient
    {
        public HttpClient Client {get; set;}

        public PostClient(HttpClient client){
            this.Client = client;
        }

        public async Task<PostDTO>? GetUser(string id){
            var response = await this.Client.GetAsync($"https://jsonplaceholder.typicode.com/users/{id}");

            var content = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<PostDTO>(content);

        }

    }
    
}