﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace AspMvcShop.Models
{
    [Table("Kupac")]
    public partial class Kupac
    {
        
        public Kupac()
        {
            Porudzbine = new HashSet<Porudzbina>();
        }

        [Key]
        public string KupacId { get; set; }
        [Required]
        [StringLength(30)]
        public string Ime { get; set; }
        [Required]
        [StringLength(30)]
        public string Prezime { get; set; }
        [Required]
        [StringLength(30)]
        public string Drzava { get; set; }
        [Required]
        [StringLength(30)]
        public string Grad { get; set; }
        [Required]
        [StringLength(100)]
        public string Adresa { get; set; }

        [InverseProperty("Kupac")]
        public virtual ICollection<Porudzbina> Porudzbine { get; set; }
    }
}