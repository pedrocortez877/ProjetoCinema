namespace ProjetoCinema.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SALA")]
    public partial class SALA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SALA()
        {
            ASSENTO_SALA = new HashSet<ASSENTO_SALA>();
            SESSAO = new HashSet<SESSAO>();
        }

        [Key]
        public int ID_Sala { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome_Sala { get; set; }

        public int Capacidade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ASSENTO_SALA> ASSENTO_SALA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SESSAO> SESSAO { get; set; }
    }
}
