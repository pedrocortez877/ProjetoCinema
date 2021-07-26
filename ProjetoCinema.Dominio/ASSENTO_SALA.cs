namespace ProjetoCinema.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ASSENTO_SALA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ASSENTO_SALA()
        {
            INGRESSO = new HashSet<INGRESSO>();
        }

        [Key]
        public int ID_Assento_Sala { get; set; }

        public int ID_Sala { get; set; }

        public int Posicao_Assento { get; set; }

        public virtual SALA SALA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INGRESSO> INGRESSO { get; set; }
    }
}
