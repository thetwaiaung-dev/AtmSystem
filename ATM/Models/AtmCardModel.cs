using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATM.Models
{
    [Table("atm-card")]
    public class AtmCardModel
    {
        [Key]
        public int Id { get; set; }
        public string CardNo { get; set; }
        public int Amount { get; set; }

        public int UserId { get; set; }
    }
}
