using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConfigurationJSONData
{
    public class ConfigurationHelper
    {

        private static JObject _configurationData;
        public ConfigurationHelper()
        {
            if (_configurationData == null)
                _configurationData = JObject.Parse(File.ReadAllText("ConfigurationData.json"));
        }
        public Dictionary<byte, string> DictionaryCollection
        {
            get
            {
                return _configurationData["DictionaryCollection"].ToObject<Dictionary<byte, string>>();
            }
        }

        public User User
        {
            get
            {
                return _configurationData["User"].ToObject<User>();
            }
        }

        public Address UserAddress
        {
            get
            {
                return _configurationData["User"]["Address"].ToObject<Address>(); ;
            }
        }

        public List<Address> Countries
        {
            get
            {
                return _configurationData["Countries"].ToObject<List<Address>>();
            }
        }

        public string Version
        {
            get
            {
                //return _configurationData["Version"].ToString();
                //or
                return _configurationData["Version"].ToObject<string>();
            }
        }

        public DateTime ReleaseDate
        {
            get
            {
                return DateTime.Parse(_configurationData["ReleaseDate"].ToString());
            }
        }
    }
}
