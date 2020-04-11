using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicRest
{
    public enum DEF_REQUEST_METHOD : int
    {
        REQUEST_GET = 0,
        REQUEST_POST
    }

    public class RestInfo
    {
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private DEF_REQUEST_METHOD _requestMethod = DEF_REQUEST_METHOD.REQUEST_GET;
        public DEF_REQUEST_METHOD RequestMethod
        {
            get { return _requestMethod; }
            set { _requestMethod = value; }
        }

        private string _path;
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        private string _param;
        public string Param
        {
            get { return _param; }
            set { _param = value; }
        }

        private string _result;
        public string Result
        {
            get { return _result; }
            set { _result = value; }
        }

        public string GetRequestMethod()
        {
            if (_requestMethod == DEF_REQUEST_METHOD.REQUEST_GET)
            {
                return RequestFunc.DEF_METHOD_GET;
            } else if (_requestMethod == DEF_REQUEST_METHOD.REQUEST_POST)
            {
                return RequestFunc.DEF_METHOD_POST;
            }

            return RequestFunc.DEF_METHOD_GET;
        }

        public void SetRequestMethod(string method)
        {
            if (method.Equals(RequestFunc.DEF_METHOD_GET))
            {
                _requestMethod = DEF_REQUEST_METHOD.REQUEST_GET;
            } else
            {
                _requestMethod = DEF_REQUEST_METHOD.REQUEST_POST;
            }
        }

        public string GetQuery()
        {
            string result = "";
            if (string.IsNullOrEmpty(_param))
            {
                return result;
            }                                   

            var dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(_param);
            int i = 0;
            foreach (var kv in dict)
            {
                string param = string.Format("{0}={1}", kv.Key, kv.Value);
                if (i > 0)
                {
                    param = "&" + param;
                }
                result += param;
                i++;
            }

            
            return result;
        }

        public Dictionary<string, string> GetFormUrlEncodedContent()
        {
            string result = "";
            if (string.IsNullOrEmpty(_param))
            {
                return null;
            }

            var dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(_param);

            return dict;
        }



    }
}
