using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebToDoList.Models
{
    public class ListTask
    {
        public string Id { get; set; }
        //mapping the title
        [JsonPropertyName("title")]
        public string Title{ get; set; }
        [JsonPropertyName("description")]
        public string Description  { get; set; }
        public bool Complete { get; set; }
        public bool Cancel { get; set; }
        public string Date { get; set; }

        public override string ToString() => JsonSerializer.Serialize(this);
        

    }
}
