namespace ProjetoCinema.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_INGRESSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_INGRESSO()
        {
            INGRESSO = new HashSet<INGRESSO>();
        }

        [Key]
        public int ID_Tipo { get; set; }

        [Required]
        [StringLength(20)]
        public string Nome_Tipo { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INGRESSO> INGRESSO { get; set; }
    }
}
