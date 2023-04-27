using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NewJwtLogin.Models
{
    public class Cart
    {
        //primary key
     
        public int CartId { get; set; }

        //foreign key
        public string Email { get; set; }
        public string Username { get; set; }
        public string Product_Name { get; set; }
        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }


    }
}