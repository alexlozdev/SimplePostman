using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace DynamicRest
{
    public class RequestFunc
    {        
        private static string _userAgent = @"Mozilla/5.0 (Windows; Windows NT 6.1) AppleWebKit/534.23 (KHTML, like Gecko) Chrome/11.0.686.3 Safari/534.23";
        public static string DEF_METHOD_GET = "GET";
        public static string DEF_METHOD_POST = "POST";

        private readonly HttpClient _httpClient = new HttpClient();
        private static RequestFunc _requestFunc;

        public static RequestFunc GetInstance()
        {
            if (_requestFunc == null)
            {
                _requestFunc = new RequestFunc();
            }

            return _requestFunc;
        }


        public string SendRequest(RestInfo restInfo)
        {
            string result = "";
            if (restInfo == null)
            {
                return result;
            }

            if (restInfo.RequestMethod == DEF_REQUEST_METHOD.REQUEST_GET)
            {
                try
                {
                    Task<string> task = RequestGetAsync(restInfo);
                    task.Wait();
                    return task.Result;
                } catch (Exception e)
                {
                    return e.Message;
                }
                
            } else
            {
                try
                {
                    Task<string> task = RequestPostAsync(restInfo);
                    task.Wait();
                    return task.Result;
                } catch (Exception e)
                {
                    return e.Message;
                }
                
            }            
        }

        public static string RequestGet(RestInfo restInfo)
        {
            string result = "";
            if (restInfo == null)
            {
                return result;
            }

            string path = string.Format("{0}?{1}", restInfo.Path, restInfo.GetQuery());
            if (string.IsNullOrEmpty(restInfo.Param))
            {
                path = string.Format("{0}", restInfo.Path);
            } 

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(restInfo.Path);            
            request.Method = "GET";
            request.Accept = "*/*";
            request.ContentType = "application/x-www-form-urlencoded";

            // response
            WebResponse response = request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());

            return result;
        }

        public static string RequestPost1(RestInfo restInfo)
        {
            string result = "";
            if (restInfo == null)
            {
                return result;
            }

            string path = string.Format("{0}", restInfo.Path);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(restInfo.Path);
            //CookieContainer cookieContainer = new CookieContainer();
            //request.CookieContainer = cookieContainer;
            request.UserAgent = _userAgent;
            request.Method = "POST";
            request.Accept = "*/*";
            request.ContentType = "application/x-www-form-urlencoded";

            StreamWriter requestWriter = new StreamWriter(request.GetRequestStream());
            requestWriter.Write(restInfo.GetQuery());
            requestWriter.Close();

            // response
            try
            {
                HttpWebResponse response = (HttpWebResponse) request.GetResponse();
                StreamReader streamReader = new StreamReader(response.GetResponseStream());
                result = streamReader.ReadToEnd();
            }
            catch (WebException ex)
            {
                using (var stream = ex.Response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    result = reader.ReadToEnd();                    
                }
            }  catch (Exception e)
            {
                result = "network error";
            }            

            return result;
        }

        private async Task<string> RequestPostAsync(RestInfo restInfo)
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Post, restInfo.Path);
            var data = restInfo.GetFormUrlEncodedContent();

            if (data != null)
            {
                requestMessage.Content = new FormUrlEncodedContent(data);
            }
            
            var response = await _httpClient.SendAsync(requestMessage).ConfigureAwait(false);
            var responseString = await response.Content.ReadAsStringAsync();
            //JContainer jsonResult = JObject.Parse(responseString);
            return responseString;
        }

        private async Task<string> RequestGetAsync(RestInfo restInfo)
        {
            string path = string.Format("{0}?{1}", restInfo.Path, restInfo.GetQuery());
            if (string.IsNullOrEmpty(restInfo.Param))
            {
                path = string.Format("{0}", restInfo.Path);
            }

            var response = await _httpClient.GetStringAsync(path);
            
            //JContainer jsonResult = JObject.Parse(response);
            return response;
        }

    }
}
