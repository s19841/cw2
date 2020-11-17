using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace cw2.Models
{
    [Serializable]
    public class ActiveStudies
    {
        [XmlElement(elementName: "name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [XmlElement(elementName: "numberOfStudents")]
        [JsonPropertyName("numberOfStudents")]
        public int NumberOfStudents { get; set; }
    }
}
