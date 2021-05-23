using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreBootcampT23MVC_EX1
{
    public class Cliente
    {
        public const int MAXNOMBRE = 250;
        public const int MAXAPELLIDOS = 250;
        public const int MAXDIRECCION = 250;
        public const int TOTALDNI = 11;
        public int? Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public int? DNI { get; set; }
        public DateTime? Fecha { get; set; }

        public override string ToString()
        {
            return $"{(!string.IsNullOrEmpty(Nombre) ? Nombre : string.Empty)} {(!string.IsNullOrEmpty(Apellidos)?Apellidos:string.Empty)}";
        }
    }
}
