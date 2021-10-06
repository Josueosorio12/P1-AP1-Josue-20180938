using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_ap1_josueosorio_20180938.Entidades
{
    public class AportesEntidades
    {
        [Key]
        public int AporteID { get; set; }
        public DateTime FechaIngreso { get; set; } = DateTime.Now;
        public string Persona { get; set; }
        public string Concepto { get; set; }

        public int Monto { get; set; }
        public int Conteo { get; set; }

        public int Total { get; set; }
    }
}
