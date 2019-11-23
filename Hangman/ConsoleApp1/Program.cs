using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Url = "https://jsonplaceholder.typicode.com/todos/1";
            // Create the http request
            var webRequest = WebRequest.Create(Url);

            // Send the http request and wait for the response
            var responseStream = webRequest.GetResponse().GetResponseStream();

            // Displays the response stream text
            if (responseStream != null)
            {
                using (var streamReader = new StreamReader(responseStream))
                {
                    // Return next available character or -1 if there are no characters to be read
                    while (streamReader.Peek() > -1)
                    {
                        //JsonConvert.parse(streamReader.ReadLine());
                        Console.WriteLine(streamReader.ReadLine());
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
