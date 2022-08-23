using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEntities
{
    public class Cliente
    {
        public int Cliente_ID { get; set; }

        public string Cliente_Codigo { get; set; }

        public string Cliente_Nombre { get; set; }

        public string Cliente_Apellido { get; set; }

        public string Cliente_Telefono { get; set; }

        public string Cliente_Direccion { get; set; }

        public bool Cliente_Status { get; set; }


    }
}
