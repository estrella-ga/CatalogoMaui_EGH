using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoMAUI_EGH.Models;

namespace CatalogoMAUI_EGH.ViewModels
{
    public class CatalogoViewModel
    {
        //Cada objeto de esta lista se convertirá en una tarjeta.
        public List<Producto> Productos { get; } = new()
        {
            new Producto
            {
                Nombre = "Mochila urbana",
                Descripcion = "Con espacio para laptop y cuadernos.",
                Precio = 499.00m,
                Foto = "mochila.png"
            },
            new Producto
            {
                Nombre = "Libreta A5",
                Descripcion = "80 hojas rayadas con pasta dura.",
                Precio = 89.50m,
                Foto = "cuaderno.png"
            },
            new Producto
            {
                Nombre = "Termo de acero",
                Descripcion = "Botella reutilizable de 500 ml.",
                Precio = 219.00m,
                Foto = "termo.png"
            }
        };
    }
}
