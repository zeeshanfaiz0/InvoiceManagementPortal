﻿using System.ComponentModel.DataAnnotations;

namespace InvoiceManagementPortal.Models
{
    public class ServiceCategory
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
    }
}
