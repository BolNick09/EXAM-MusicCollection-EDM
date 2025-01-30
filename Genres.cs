namespace EXAM_MusicCollection_EDM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Xml.Linq;

    public partial class Genres
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Genres()
        {
            Records = new HashSet<Records>();
        }

        [Key]
        public int GenreID { get; set; }

        [Required]
        [StringLength(50)]
        public string GenreName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Records> Records { get; set; }
        public override string ToString()
        {
            return GenreName;

        }

    }
    public class GenresViewModel
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }
        public GenresViewModel(Genres gen)
        {
            GenreID = gen.GenreID;
            GenreName = gen.GenreName;
        }
    }
}
