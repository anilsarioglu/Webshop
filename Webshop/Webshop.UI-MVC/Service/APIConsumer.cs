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
    }
}