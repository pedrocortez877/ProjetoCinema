namespace ProjetoCinema.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLIENTE")]
    public partial class CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTE()
        {
            COMPRA = new HashSet<COMPRA>();
        }

        [Key]
        public int ID_Cliente { get; set; }

        public long CPF { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome_Cliente { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Dt_Nasc { get; set; }

        [StringLength(30)]
        public string Senha { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRA> COMPRA { get; set; }
    }
}
