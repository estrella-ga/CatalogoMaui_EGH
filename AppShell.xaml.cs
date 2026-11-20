using CatalogoMAUI_EGH.Views;

namespace CatalogoMAUI_EGH
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("producto-detalle", typeof(ProductoDetallePage));
        }
    }
}
