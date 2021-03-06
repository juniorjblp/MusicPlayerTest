using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUteis
{
    public class iTunesReturn
    {
        public static string GetItunesReturn(string ArtistName)
        {
            HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create("https://itunes.apple.com/search?term=" + ArtistName + "/json/");
            HttpWebResponse resposta = (HttpWebResponse)requisicao.GetResponse();
            int cont;
            byte[] buffer = new byte[1000];
            StringBuilder sb = new StringBuilder();
            string temp;
            Stream stream = resposta.GetResponseStream();
            do
            {
                cont = stream.Read(buffer, 0, buffer.Length);
                temp = Encoding.UTF8.GetString(buffer, 0, cont).Trim();
                sb.Append(temp);

            } while (cont > 0);
            return sb.ToString();
        }
    }
}
