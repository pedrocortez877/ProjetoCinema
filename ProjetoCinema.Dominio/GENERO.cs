namespace ProjetoCinema.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GENERO")]
    public partial class GENERO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GENERO()
        {
            GENERO_FILME = new HashSet<GENERO_FILME>();
        }

        [Key]
        public int ID_Genero { get; set; }

        [Required]
        [StringLength(20)]
        public string Nome_Genero { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GENERO_FILME> GENERO_FILME { get; set; }
    }
}
