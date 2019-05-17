namespace r2bw.Data
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public class Purchase
    {
        public int Id { get; set; }

        [Required]
        public string TypeName { get; set; }

        public PurchaseType Type { get; set; }

        [Required]
        [DisplayName("Purchased On")]
        [DataType(DataType.Date)]
        public DateTime PurchasedOn { get; set; }

        [Required]
        public double Amount { get; set; }

        public string Vendor { get; set; }

        public bool Active { get; set; }

        [Required]
        public int ParticipantId { get; set; }

        public Participant Participant { get; set; }
    }
}