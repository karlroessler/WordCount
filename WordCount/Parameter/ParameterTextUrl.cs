using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Parameter
{
    public class IsTextUrl
    {
        public static string IsTextUrlAdress(string[] args)
        {
            var url = "";
            string urltext = null;
            foreach (var arg in args)
            {
                if (arg.StartsWith("-texturl"))
                {
                    int idx = arg.LastIndexOf('=');
                    url = arg.Substring(idx + 1);
                    HttpWebRequest request = null;
                    try
                    {
                        request = (HttpWebRequest)WebRequest.Create(url);
                        request.Timeout = 15000;
                        HttpWebResponse response;
                        try
                        {
                            response = (HttpWebResponse)request.GetResponse();
                            var content = response.GetResponseStream();
                            var reader = new StreamReader(content);
                            urltext = reader.ReadToEnd();
                        }
                        catch (Exception)
                        {
                            Console.Write($"File {url} is not found \r\n");
                        }
                    }
                    catch (Exception)
                    {
                        Console.Write($"File {url} is not a correct url \r\n");
                    }
                }
            }
            return urltext;
        }
    }
}
