namespace ProjetoCinema.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLASS_INDICATIVA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLASS_INDICATIVA()
        {
            FILME = new HashSet<FILME>();
        }

        [Key]
        public int ID_Class { get; set; }

        [Required]
        [StringLength(20)]
        public string Nome_Class { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FILME> FILME { get; set; }
    }
}
