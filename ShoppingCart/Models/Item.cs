using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models
{
    public class Item
    {
        public String Code { get; set; }
        public String Description { get; set; }
        [Display(Name = "Price (€):")]
        public double Price { get; set; }

        public Item(string _code, string _description, double _price)
        {
            Code = _code;
            Description = _description;
            Price = _price;
        }

        public Item() { }
        
    }
}
