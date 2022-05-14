using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace MyJSON
{
    public class JSONHelper
    {
        JObject jo = null;
        public JSONHelper(String jsonText)
        {
            jo = (JObject)JsonConvert.DeserializeObject(jsonText);
        }

        public string GetParamValue(string ParamName)
        {
            if (jo != null)
            {
                try
                {
                    return jo[ParamName].ToString();
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
