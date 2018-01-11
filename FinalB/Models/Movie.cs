namespace FinalB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Movie
    {
        [Key]
        public int MovieID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public int? Year { get; set; }

        public int? Revenue { get; set; }

        public int StudioID { get; set; }

        [StringLength(100)]
        public string Poster { get; set; }

        public virtual Studio Studio { get; set; }
    }
}
