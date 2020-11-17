using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace cw2.Models
{
    [Serializable]
    public class Studies
    {
        [XmlElement(elementName:"name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [XmlElement(elementName:"mode")]
        [JsonPropertyName("mode")]
        public string Mode { get; set; }

    }
}
