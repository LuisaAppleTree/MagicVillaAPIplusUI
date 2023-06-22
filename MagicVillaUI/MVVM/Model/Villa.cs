using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicVillaUI.MVVM.Model
{
    class Villa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public double Tarifa { get; set; }
        public int Ocupantes { get; set; }
        public double MetrosCuadrados { get; set; }
        public string ImagenUrl { get; set; }
        public string Amenidad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}

