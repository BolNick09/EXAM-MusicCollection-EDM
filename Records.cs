namespace EXAM_MusicCollection_EDM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Xml.Linq;

    public partial class Records
    {
        [Key]
        public int RecordID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        public int ArtistID { get; set; }

        [Required]
        [StringLength(100)]
        public string Publisher { get; set; }

        public int TracksCount { get; set; }

        public int GenreID { get; set; }

        public int YearID { get; set; }

        public decimal Cost { get; set; }

        public decimal SalePrice { get; set; }

        public int StockCount { get; set; }

        public bool IsOnSale { get; set; }

        public virtual Artists Artists { get; set; }

        public virtual Genres Genres { get; set; }

        public virtual Years Years { get; set; }

        public override string ToString()
        {
            return Title;

        }
    }
}
