namespace ProjetoCinema.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GENERO_FILME
    {
        [Key]
        public int ID_Gen_Filme { get; set; }

        public int ID_Filme { get; set; }

        public int ID_Genero { get; set; }

        public virtual FILME FILME { get; set; }

        public virtual GENERO GENERO { get; set; }
    }
}
