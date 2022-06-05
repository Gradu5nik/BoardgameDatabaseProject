﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BoardgameDatabase
{
    public partial class Adress
    {
        public Adress()
        {
            BoardgameKeeperNavigations = new HashSet<Boardgame>();
            BoardgameOwnerNavigations = new HashSet<Boardgame>();
        }

        [Key]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Column("Adress", TypeName = "ntext")]
        public string Street { get; set; }
        [Required]
        [StringLength(50)]
        public string City { get; set; }
        [Required]
        [StringLength(50)]
        public string Country { get; set; }
        [Required]
        [StringLength(16)]
        public string PostCode { get; set; }

        [InverseProperty(nameof(Boardgame.KeeperNavigation))]
        public virtual ICollection<Boardgame> BoardgameKeeperNavigations { get; set; }
        [InverseProperty(nameof(Boardgame.OwnerNavigation))]
        public virtual ICollection<Boardgame> BoardgameOwnerNavigations { get; set; }
    }
}