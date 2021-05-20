using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace SDNetEksamen.Models
{
    public class Category : IIdentification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [JsonIgnore]
        public virtual List<Product> Products { get; set; }
    }
}
