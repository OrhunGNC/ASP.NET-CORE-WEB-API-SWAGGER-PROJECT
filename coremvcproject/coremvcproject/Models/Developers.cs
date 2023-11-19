﻿using System.ComponentModel.DataAnnotations;

namespace coremvcproject.Models
{
    public class Developers
    {
        [Key]
        public int DevelopersId {  get; set; }
        public string? DeveloperName { get; set;}
        public DateTime FoundationDate { get; set; }
        public decimal DeveloperValue { get; set; }
    }
}
