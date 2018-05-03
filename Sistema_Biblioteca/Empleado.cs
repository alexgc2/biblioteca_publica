using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Biblioteca
{
    public class Empleado
    {
        string id = "15";
        string nombre;
        string apellidos;
        string direccion;
        DateTime fecha_nacimiento;
        string sexo;
        string telefono;
        string status;

        #region getters y setters
        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Status { get => status; set => status = value; }
        #endregion
    }
}
