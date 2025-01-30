namespace EXAM_MusicCollection_EDM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Artists
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Artists()
        {
            Records = new HashSet<Records>();
        }

        [Key]
        public int ArtistID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Records> Records { get; set; }

        public override string ToString()
        {
            return Name;

        }
    }
    public class ArtistsViewModel
    {
        public int ArtistID { get; set; }
        public string Name { get; set; }

        public ArtistsViewModel(Artists art)
        {
            ArtistID = art.ArtistID;
            Name = art.Name;
        }
    }
}
