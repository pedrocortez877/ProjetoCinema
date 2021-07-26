namespace ProjetoCinema.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SESSAO")]
    public partial class SESSAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SESSAO()
        {
            INGRESSO = new HashSet<INGRESSO>();
        }

        [Key]
        public int ID_Sessao { get; set; }

        [StringLength(20)]
        public string Horario { get; set; }

        [Column(TypeName = "date")]
        public DateTime Dt_Sessao { get; set; }

        public int ID_Sala { get; set; }

        public int ID_Filme { get; set; }

        public virtual FILME FILME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INGRESSO> INGRESSO { get; set; }

        public virtual SALA SALA { get; set; }
    }
}
