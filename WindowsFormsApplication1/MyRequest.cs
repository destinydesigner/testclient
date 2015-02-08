using System;
using System.Net;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class MyRequest
    {
        private WebRequest request;
        private string url;
        public string Method { get; set; }
        public string Parameters { get; set; }
        public int LoadingTime { get; set; }

        public MyRequest(string url)
        {
            this.url = url;
        }

        public HttpWebResponse DoRequest()
        {
            Trace.WriteLine(this.Method);
            Trace.WriteLine(this.url + "?" + this.Parameters);
            if (this.Method.Equals("GET"))
            {
                this.request = (HttpWebRequest)WebRequest.Create(url + "/?" + Parameters);
                this.request.Method = Method;
            }
            else if (this.Method.Equals("POST"))
            {
                this.request = (HttpWebRequest)WebRequest.Create(url);
                this.request.Method = Method;

                this.request.ContentType = "application/x-www-form-urlencoded";

                var data = Encoding.ASCII.GetBytes(this.Parameters);
                this.request.ContentLength = data.Length;

                using (var stream = this.request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }

            System.Diagnostics.Stopwatch timer = new Stopwatch();
            timer.Start();

            HttpWebResponse response = (HttpWebResponse)this.request.GetResponse();

            timer.Stop();

            LoadingTime = timer.Elapsed.Milliseconds;

            return response;
        }
    }
}
