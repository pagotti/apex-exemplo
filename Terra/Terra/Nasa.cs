using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Terra
{
    class Nasa
    {
        public static Image GetImage(string source)
        {
            using (HttpClient client = new HttpClient())
            {
                using (var response = client.GetAsync(source).Result)
                {
                    Stream stream = response.Content.ReadAsStreamAsync().Result;
                    return Bitmap.FromStream(stream);
                }
            }

        }
    }
}
