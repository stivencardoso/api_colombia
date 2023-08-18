using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace colombiapi
{
    class program
    {
        static void Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                string url = "https://api-colombia.com/api/v1/Country/Colombia";
                client.DefaultRequestHeaders.Clear();
                var response = client.GetAsync(url).Result;
                var res = response.Content.ReadAsStringAsync().Result;
                dynamic r = res;

                Console.WriteLine(r);
            }
        }
    }
}
