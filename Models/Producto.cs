using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoMAUI_EGH.Models
{
    public class Producto
    {
        public string Nombre { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public decimal Precio {  get; set; }

        public string Foto { get; set; } = "";
    }
}
