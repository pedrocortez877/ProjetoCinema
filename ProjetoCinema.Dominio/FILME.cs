using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace ProjetoCinema.Dominio
{
    [Table("FILME")]
    public partial class FILME
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FILME()
        {
            GENERO_FILME = new HashSet<GENERO_FILME>();
            SESSAO = new HashSet<SESSAO>();
        }

        [Key]
        public int ID_Filme { get; set; }

        [Required]
        [StringLength(30)]
        public string Titulo { get; set; }

        [StringLength(400)]
        public string Sinopse { get; set; }

        public int ID_Class { get; set; }

        public int Duracao { get; set; }

        public string Capa { get; set; }

        public virtual CLASS_INDICATIVA CLASS_INDICATIVA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GENERO_FILME> GENERO_FILME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SESSAO> SESSAO { get; set; }
    }
}
