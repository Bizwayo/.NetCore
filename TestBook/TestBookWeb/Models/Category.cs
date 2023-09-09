﻿using System.ComponentModel.DataAnnotations;

namespace TestBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Name { get; set; }
        public int DisplayOrder{ get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}