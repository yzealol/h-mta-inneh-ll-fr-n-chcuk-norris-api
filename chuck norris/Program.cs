using System.Net.Http;

class Program{
static async Task Main(){
using(HttpClient goblin = new HttpClient()){
goblin.BaseAddress = new Uri("https://api.chucknorris.io");
try{
  HttpResponseMessage response = await goblin.GetAsync("jokes/random");
  response.EnsureSuccessStatusCode();
  string responeseBody = await response.Content.ReadAsStringAsync();
  Console.WriteLine(responeseBody);
}
catch(HttpRequestException e){
Console.WriteLine(e.Message);
}
}
}

}

