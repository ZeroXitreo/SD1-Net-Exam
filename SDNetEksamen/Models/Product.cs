using Newtonsoft.Json;

namespace SDNetEksamen.Models
{
    public class Product : IIdentification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }

        public int CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category Category { get; set; }

        public int SupplierId { get; set; }
        [JsonIgnore]
        public virtual Supplier Supplier { get; set; }
    }
}
