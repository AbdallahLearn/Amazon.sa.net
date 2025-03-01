using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AmazonSA.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
    }
}
