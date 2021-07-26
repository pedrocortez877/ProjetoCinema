namespace ProjetoCinema.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INGRESSO")]
    public partial class INGRESSO
    {
        [Key]
        public int ID_Ingresso { get; set; }

        public int ID_Assento_Sala { get; set; }

        public int ID_Tipo { get; set; }

        public int ID_Compra { get; set; }

        [Column(TypeName = "money")]
        public decimal Valor { get; set; }

        public int ID_Sessao { get; set; }

        public virtual ASSENTO_SALA ASSENTO_SALA { get; set; }

        public virtual COMPRA COMPRA { get; set; }

        public virtual SESSAO SESSAO { get; set; }

        public virtual TIPO_INGRESSO TIPO_INGRESSO { get; set; }
    }
}
