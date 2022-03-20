using System;
using System.Collections.Generic;
using System.Text;

using SQLite;
namespace Tarea2_3.Models
{
    public class constructor
    {
        [PrimaryKey, AutoIncrement]
        public int codigo { get; set; }

        

        [MaxLength(250)]
        public string descripcion { get; set; }

        
        public string ruta { get; set; }

        public DateTime fecha { get; set; }


    }
}
