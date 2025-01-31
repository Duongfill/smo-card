﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoCard.Core.Domain.Content
{
    [Table("Customers")]
    
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {  get; set; }

        public string? Phone_Number {  get; set; }
        public string? Email { get; set; }
        
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
