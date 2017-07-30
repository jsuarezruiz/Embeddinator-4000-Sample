using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;

namespace NetflixRoulette
{
    public class NetflixRouletteFetcher
    {
        public string Name { get; private set; }

        public NetflixRouletteFetcher(string movie)
        {
            Name = movie;
        }

        public NetflixRouletteResult GetMovie()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Name))
                    return null;

                string url = "http://netflixroulette.net/api/api.php?";

                var response = DownloadString(string.Format("{0}title={1}", url, Name));
                var movie = Activator.CreateInstance<NetflixRouletteResult>();

                using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(response)))
                {
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(movie.GetType());
                    movie = (NetflixRouletteResult)serializer.ReadObject(ms);
                    ms.Dispose();
                }

                return movie;
            }
            catch
            {
                return null;
            }
        }

        private string DownloadString(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)GetResponse(request);
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                string data = reader.ReadToEnd();

                return data;
            }
        }

        private WebResponse GetResponse(WebRequest request)
        {
            AutoResetEvent autoResetEvent = new AutoResetEvent(false);
            IAsyncResult asyncResult = request.BeginGetResponse(r => autoResetEvent.Set(), null);
            autoResetEvent.WaitOne();
            return request.EndGetResponse(asyncResult);
        }
    }
}