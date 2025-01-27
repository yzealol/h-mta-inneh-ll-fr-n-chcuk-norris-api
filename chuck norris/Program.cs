using System.Net.Http;
using System.Text.Json;

class Program{
static async Task Main(){
JsonSerializerOptions options = new JsonSerializerOptions{WriteIndented = true};
using(HttpClient goblin = new HttpClient()){
goblin.BaseAddress = new Uri("https://api.chucknorris.io");
try{
  HttpResponseMessage response = await goblin.GetAsync("jokes/random");
  response.EnsureSuccessStatusCode();
  string responeseBody = await response.Content.ReadAsStringAsync();
  string jsonstring = JsonSerializer.Serialize(responeseBody,options);
  Console.WriteLine(jsonstring);
}
catch(HttpRequestException e){
Console.WriteLine(e.Message);
}
}
}

}

