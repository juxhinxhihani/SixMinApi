﻿using System.ComponentModel.DataAnnotations;

namespace SixMinApi.DTO
{
    public class CommandUpdateDTO
    {
        [Required]
        public string? HowTO { get; set; }
        [Required]
        [MaxLength(5)]
        public string? Platform { get; set; }
        [Required]
        public string? CommandLine { get; set; }
    }
}
