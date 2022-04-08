namespace WATareoS10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Listar_Personal_S10
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string CodObrero { get; set; }

        [StringLength(120)]
        public string Descripcion { get; set; }

        [StringLength(20)]
        public string DNI { get; set; }

        public Guid NroEsquemaPlanilla { get; set; }

        public string CodProyecto { get; set; }

        [StringLength(8)]
        public string CodIdentificador { get; set; }

        public bool Activo { get; set; }

        public string CodInsumo { get; set; }
        public string Insumo { get; set; }

        public string CodOcupacion { get; set; }
        public string Ocupacion { get; set; }     
    }
}
