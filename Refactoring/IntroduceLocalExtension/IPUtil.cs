using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Refactoring.Libs;

namespace Refactoring.IntroduceLocalExtension
{
    public class IPUtil
    {
        static readonly HttpCli _httpCli;

        static IPUtil()
        {
            _httpCli = new HttpCli();
        }

        public static async Task<string> GetCity(string ip)
        {
            var uri = new Uri($"http://ip-api.com/json/{ip}?lang=en");
            var response = await _httpCli.SendAsync("GET", uri);
            var content = await response.Content.ReadAsStringAsync();

            using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(content)))
            {
                var serializer = new DataContractJsonSerializer(typeof(IPValue));
                return (serializer.ReadObject(stream) as IPValue)?.City;
            }
        }
    }

    [DataContract]
    class IPValue
    {
        [DataMember(Name = "city")]
        public string City { get; set; }
    }
}