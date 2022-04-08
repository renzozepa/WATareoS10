namespace WATareoS10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MARCACION_PERSONAL
    {
        public int ID { get; set; }

        [StringLength(80)]
        public string ID_TAREADOR { get; set; }

        [StringLength(80)]
        public string PROYECTO { get; set; }

        [StringLength(8)]
        public string CODOBRERO { get; set; }

        [StringLength(80)]
        public string PERSONAL { get; set; }

        [StringLength(20)]
        public string DNI { get; set; }

        public int? TIPO_MARCACION { get; set; }

        public DateTime? FECHA_MARCACION { get; set; }

        [StringLength(15)]
        public string HORA { get; set; }

        public DateTime? FECHA_REGISTRO { get; set; }

        public int? SINCRONIZADO { get; set; }

        public DateTime? FECHA_SINCRONIZADO { get; set; }

        [StringLength(255)]
        public string TOKEN { get; set; }

        [StringLength(3)]
        public string ID_SUCURSAL { get; set; }

        public int? ORIGEN { get; set; }

        public Guid NroEsquemaPlanilla { get; set; }
        public string CodInsumo { get; set; }
        public string Insumo { get; set; }

        public string CodOcupacion { get; set; }
        public string Ocupacion { get; set; }
    }
}
