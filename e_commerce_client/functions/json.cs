using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace e_commerce_client.functions
{
    class json
    {
        private static string json_path = "data.json";
        public static void json_save(Dictionary<string, string> log_info)
        {
            string json = JsonConvert.SerializeObject(log_info);
            File.WriteAllText(json_path, json);
        }

        public static Dictionary<string, string> json_load()
        {
            string json = File.ReadAllText(json_path);
            Dictionary<string, string> log_info = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
            return log_info;
        }
    }
}
