﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DniFruitsKart.UI.AdventureWorks
{
    [Table("AWBuildVersion")]
    public partial class AwbuildVersion
    {
        [Column("SystemInformationID")]
        public byte SystemInformationId { get; set; }
        [Required]
        [Column("Database Version")]
        [MaxLength(25)]
        public string DatabaseVersion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime VersionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
    }
}
