using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SmoCard.Core.SeedWorks.Constants.Permissions;

namespace SmoCard.Core.Domain.Content
{
    [Table("Cards")]
    public class Card
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Customer")]
        public int Id_Customer { get; set; }

        public string? Name { get; set; }
        public string? Title { get; set; }
        public string? Company { get; set; }
        public string? Introduce { get; set; }
        public string PhoneNumber { get; set; }
        public string? Fb_Link { get; set; }
        public string? Zalo_Link { get; set; }
        public string? Tiktok_Link { get; set; }
        public string? Youtube_Link { get; set; }
        public string? Website_Link { get; set; }
        public string? Instagram_Link { get; set; }
        public string? Messenger_Link { get; set; }
        public string? Email { get; set; }
        public string? Linkedln_Link { get; set; }
        public string? Map_Link { get; set; }
        public string? Bank { get; set; }
        public string? Account_Bank { get; set; }
        public string? Video { get; set; }
        public string? Image_Avatar1 { get; set; }
        public string? Image_Avatar2 { get; set; }

        // Navigation property
        public Customer Customer { get; set; }
    }
}
