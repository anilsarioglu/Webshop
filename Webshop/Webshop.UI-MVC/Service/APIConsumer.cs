using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Script.Serialization;

namespace Webshop.UI_MVC
{
    internal static class APIConsumer<T> where T : class
    {
        internal static IEnumerable<T> GetAPI(string path)
        {
            IEnumerable<T> objects = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44366/api/");
                var responseTask = client.GetAsync(path);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readJob = result.Content.ReadAsStringAsync();
                    JavaScriptSerializer JSserializer = new JavaScriptSerializer();
                    objects = JSserializer.Deserialize<IEnumerable<T>>(readJob.Result);
                }
                return objects;
            }
        }
    internal static void AddObject<T>(string path , T t)
    {
      using (var client = new HttpClient())
      {
        client.BaseAddress = new Uri("https://localhost:44366/api/");

        //HTTP POST
        var postTask = client.PostAsJsonAsync<T>(path, t);
        postTask.Wait();

        var result = postTask.Result;
      }
    }
    internal static void EditObject<T>(string path, string id, T t)
    {
      using (var client = new HttpClient())
      {
        client.BaseAddress = new Uri("https://localhost:44366/api/");

        //HTTP POST
        var postTask = client.PutAsJsonAsync<T>(path , t);
        postTask.Wait();

        var result = postTask.Result;

      }
    }
  }
}
