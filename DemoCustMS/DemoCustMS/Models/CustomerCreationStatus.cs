using System.ComponentModel.DataAnnotations.Schema;

namespace DemoCustMS.Models
{
    public class CustomerCreationStatus
    {
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Message { get; set; }
    }
}
