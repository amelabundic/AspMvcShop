﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;



namespace AspMvcShop.Models
{
    [Table("Proizvod")]
    public partial class Proizvod
    {
        public Proizvod()
        {
            Stavke = new HashSet<Stavka>();
        }

        [Key]
        public int ProizvodId { get; set; }
        [StringLength(100)]
        public string Kategorija { get; set; }
        [StringLength(100)]
        public string Naziv { get; set; }
        [StringLength(100)]
        public string Opis { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Cijena { get; set; }

        [InverseProperty("Proizvod")]
        public virtual ICollection<Stavka> Stavke { get; set; }
    }
}