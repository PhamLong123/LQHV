﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Eproject_RealtorsPortal.Models
{
    [Table("Image")]
    public partial class Image
    {
        [Key]
        [Column("image_id")]
        public long ImageId { get; set; }
        [Column("image_path")]
        [StringLength(100)]
        [Unicode(false)]
        public string ImagePath { get; set; } = null!;
        [Column("product_id")]
        public long ProductId { get; set; }

        [ForeignKey("ProductId")]
        [InverseProperty("Images")]
        public virtual Product Product { get; set; } = null!;
        public long NewsId { get; set; }

        [ForeignKey("NewsId")]
        [InverseProperty("Images")]
        public virtual News News { get; set; } = null!;
    }
    public class ManyImage
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public byte[] Data { get; set; }
    }
}
