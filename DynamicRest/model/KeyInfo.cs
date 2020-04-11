using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicRest
{
    public class KeyInfo
    {
        private string _key;
        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }

        private string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public static string GetJson(BindingList<KeyInfo> arrKeys)
        {
            string result = "";
            int i = 0;
            foreach(KeyInfo keyInfo in arrKeys)
            {
                string key = keyInfo.Key;
                string value = keyInfo.Value;
                string jsonObj = string.Format(", \"{0}\":\"{1}\"", key, value);
                if (i == 0)
                {
                    jsonObj = string.Format("\"{0}\":\"{1}\"", key, value);
                }
                result += jsonObj;
                i++;
            }

            result = "{" + result + "}"; 
            return result;
        }

        public static BindingList<KeyInfo> GetBindingList(string json)
        {
            BindingList<KeyInfo> bindingList = new BindingList<KeyInfo>();

            if (string.IsNullOrEmpty(json))
            {
                return bindingList;
            }

            
            var dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            int i = 0;
            foreach (var kv in dict)
            {
                KeyInfo keyInfo = new KeyInfo();
                keyInfo._key = kv.Key;
                keyInfo.Value = kv.Value;

                bindingList.Add(keyInfo);
            }

            return bindingList;
        }
    }
}
