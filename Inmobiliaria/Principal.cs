using System;
using System.Windows.Forms;

namespace Inmobiliaria
{
    public partial class Principal : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Principal()
        {
            InitializeComponent();
        }              

        private void BtnVentaDepartamento_Click(object sender, EventArgs e)
        {
            if (!ContenedorPrincipal.Controls.Contains(VentaDepartamento.Instance))
            {
                ContenedorPrincipal.Controls.Add(VentaDepartamento.Instance);
                VentaDepartamento.Instance.Dock = DockStyle.Fill;
                VentaDepartamento.Instance.BringToFront();
            }
            VentaDepartamento.Instance.BringToFront();
        }
        private void BtnVentaCasaDuplex_Click(object sender, EventArgs e)
        {
            if (!ContenedorPrincipal.Controls.Contains(VentaCasaDuplex.Instance))
            {
                ContenedorPrincipal.Controls.Add(VentaCasaDuplex.Instance);
                VentaCasaDuplex.Instance.Dock = DockStyle.Fill;
                VentaCasaDuplex.Instance.BringToFront();
            }
            VentaCasaDuplex.Instance.BringToFront();
        }
        private void BtnVentaTipoCasa_Click(object sender, EventArgs e)
        {
            if (!ContenedorPrincipal.Controls.Contains(VentaTipoCasa.Instance))
            {
                ContenedorPrincipal.Controls.Add(VentaTipoCasa.Instance);
                VentaTipoCasa.Instance.Dock = DockStyle.Fill;
                VentaTipoCasa.Instance.BringToFront();
            }
            VentaTipoCasa.Instance.BringToFront();
        }
        private void BtnVentaLocalGalpon_Click(object sender, EventArgs e)
        {
            if (!ContenedorPrincipal.Controls.Contains(VentaLocalGalpon.Instance))
            {
                ContenedorPrincipal.Controls.Add(VentaLocalGalpon.Instance);
                VentaLocalGalpon.Instance.Dock = DockStyle.Fill;
                VentaLocalGalpon.Instance.BringToFront();
            }
            VentaLocalGalpon.Instance.BringToFront();
        }
        private void BtnVentaLoteTerreno_Click(object sender, EventArgs e)
        {
            if (!ContenedorPrincipal.Controls.Contains(VentaLoteTerreno.Instance))
            {
                ContenedorPrincipal.Controls.Add(VentaLoteTerreno.Instance);
                VentaLoteTerreno.Instance.Dock = DockStyle.Fill;
                VentaLoteTerreno.Instance.BringToFront();
            }
            VentaLoteTerreno.Instance.BringToFront();
        }


        private void BtnAlquilerDepartamento_Click(object sender, EventArgs e)
        {
            if (!ContenedorPrincipal.Controls.Contains(AlquilerDepartamento.Instance))
            {
                ContenedorPrincipal.Controls.Add(AlquilerDepartamento.Instance);
                AlquilerDepartamento.Instance.Dock = DockStyle.Fill;
                AlquilerDepartamento.Instance.BringToFront();
            }
            AlquilerDepartamento.Instance.BringToFront();
        }
        private void BtnAlquilerCasaDuplex_Click(object sender, EventArgs e)
        {
            if (!ContenedorPrincipal.Controls.Contains(AlquilerCasaDuplex.Instance))
            {
                ContenedorPrincipal.Controls.Add(AlquilerCasaDuplex.Instance);
                AlquilerCasaDuplex.Instance.Dock = DockStyle.Fill;
                AlquilerCasaDuplex.Instance.BringToFront();
            }
            AlquilerCasaDuplex.Instance.BringToFront();
        }
        private void BtnAlquilerTipoCasa_Click(object sender, EventArgs e)
        {
            if (!ContenedorPrincipal.Controls.Contains(AlquilerTipoCasa.Instance))
            {
                ContenedorPrincipal.Controls.Add(AlquilerTipoCasa.Instance);
                AlquilerTipoCasa.Instance.Dock = DockStyle.Fill;
                AlquilerTipoCasa.Instance.BringToFront();
            }
            AlquilerTipoCasa.Instance.BringToFront();
        }
        private void BtnAlquilerLocalGalpon_Click(object sender, EventArgs e)
        {
            if (!ContenedorPrincipal.Controls.Contains(AlquilerLocalGalpon.Instance))
            {
                ContenedorPrincipal.Controls.Add(AlquilerLocalGalpon.Instance);
                AlquilerLocalGalpon.Instance.Dock = DockStyle.Fill;
                AlquilerLocalGalpon.Instance.BringToFront();
            }
            AlquilerLocalGalpon.Instance.BringToFront();
        }

        private void BtnNuevaVenta_Click(object sender, EventArgs e)
        {
            if (!ContenedorPrincipal.Controls.Contains(NuevaVenta.Instance))
            {
                ContenedorPrincipal.Controls.Add(NuevaVenta.Instance);
                NuevaVenta.Instance.Dock = DockStyle.Fill;
                NuevaVenta.Instance.BringToFront();
            }
            NuevaVenta.Instance.BringToFront();
        }
        private void BtnNuevoAlquiler_Click(object sender, EventArgs e)
        {
            if (!ContenedorPrincipal.Controls.Contains(NuevoAlquiler.Instance))
            {
                ContenedorPrincipal.Controls.Add(NuevoAlquiler.Instance);
                NuevoAlquiler.Instance.Dock = DockStyle.Fill;
                NuevoAlquiler.Instance.BringToFront();
            }
            NuevoAlquiler.Instance.BringToFront();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (!ContenedorPrincipal.Controls.Contains(Buscar.Instance))
            {
                ContenedorPrincipal.Controls.Add(Buscar.Instance);
                Buscar.Instance.Dock = DockStyle.Fill;
                Buscar.Instance.BringToFront();
            }
            Buscar.Instance.BringToFront();
        }
    }
}
