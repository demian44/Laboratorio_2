using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading;
using System.Net.Http.Headers;
using System.IO;
using static System.Environment;

namespace PruebaHTTP
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(Program.HttpGet);
            thread.Start();
            //Thread thread2 = new Thread(Program.HttpPost);
            //thread2.Start();

            //Console.ReadKey();
        }

        public async static void HttpGet()
        {
            //   Thread.Sleep(8000);

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    using (HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("http://localhost:57569/api/Continents"))
                    {
                        using (HttpContent content = httpResponseMessage.Content)
                        {
                            HttpContentHeaders headers = content.Headers;
                            string myContent = await content.ReadAsStringAsync();
                            Console.Write(myContent);
                            Console.Write(headers);
                            
                        }

                    }
                }
            }
            catch (HttpRequestException exception)
            {
                Thread hilo = new Thread(SaveCoso);
                hilo.Start(exception.Message);
            }
            catch (Exception exception)
            {
                Thread hilo = new Thread(SaveCoso);
                hilo.Start(exception.Message);
            }
        }


        public async static void HttpPost()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
                    {
                        new KeyValuePair<string, string>("Name", "NachoNente2")
                    };

                HttpContent postContent = new FormUrlEncodedContent(queries);
                using (HttpResponseMessage httpResponseMessage = await httpClient.PostAsync("http://localhost:57569/api/Continents", postContent))
                {
                    using (HttpContent content = httpResponseMessage.Content)
                    {

                        string myContent = await content.ReadAsStringAsync();
                        Console.WriteLine(myContent);
                      
                        //Console.WriteLine(Headers);

                    }

                }
            }
        }

        public static void SaveCoso(object messege)
        {
            Thread.Sleep(1000);
            StreamWriter writer = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//coso.txt");
            writer.WriteLine(messege);
            writer.Close();
        }
    }
}


