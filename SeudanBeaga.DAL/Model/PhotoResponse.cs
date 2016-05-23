using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace SeudanBeaga.DAL.Model
{
    [JsonObject(MemberSerialization.OptIn)]
    public class PhotoResponse
    {
        [JsonProperty]
        public int photoId { get; set; }
        [JsonProperty]
        public string owner { get; set; }
    }
}
