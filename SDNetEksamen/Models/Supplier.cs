using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SDNetEksamen.Models
{
    public class Supplier : IIdentification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Zipcode { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }

        [JsonIgnore]
        public virtual List<Product> Products { get; set; }
    }
}
