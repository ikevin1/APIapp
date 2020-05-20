using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace QuizApp1.Models
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class QuizData
    {
        [JsonProperty(PropertyName = "id")]
        public  int ID { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
