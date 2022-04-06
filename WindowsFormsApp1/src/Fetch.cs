using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace WindowsFormsApp1
{
    public class Fetch
    {
        public async void FetchData()
        {
            Logger.Start();

            // URL guide: https://stackoverflow.com/questions/65818633/how-to-download-a-raw-file-from-github-in-c-sharp-net
            // WebClient.DownloadFile
            const string url = "https://raw.githubusercontent.com/HoRockx2/winform_practice/master/sample/sample_data.dat";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync(url))
                    {
                        using (HttpContent content = res.Content)
                        {
                            var data = await content.ReadAsStringAsync();

                            if(data == null)
                            {
                                Logger.Info("data is null!");
                                return; 
                            }

                            Logger.Info(data);
                        }
                    }
                }
            }
            catch(Exception e)
            {

            }
        }
    }
}
