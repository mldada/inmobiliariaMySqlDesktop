using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ENTIDAD;

namespace Inmobiliaria
{
    public partial class Frm_Principal : Form
    {
        private bool isCollapsedVenta;
        private bool isCollapsedAlquiler;
        private bool isCollapsedNuevo;
        
        public Frm_Principal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlHader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {

        }

        private void BtnVenta_Click(object sender, EventArgs e)
        {
            TimerVenta.Start();
            
        }

        private void TimerVenta_Tick(object sender, EventArgs e)
        {
            if (isCollapsedVenta)
            {
                PnlVentas.Height += 10;
                if (PnlVentas.Size == PnlVentas.MaximumSize)
                {
                    TimerVenta.Stop();
                    isCollapsedVenta = false;
                }

                PnlAlquileres.Height -= 10;
                if (PnlAlquileres.Size == PnlAlquileres.MinimumSize)
                {
                    TimerAlquiler.Stop();
                    isCollapsedAlquiler = true;
                }

                pnlNuevo.Height -= 10;
                if (pnlNuevo.Size == pnlNuevo.MinimumSize)
                {
                    TimerNuevo.Stop();
                    isCollapsedNuevo = true;
                }

            }
            else
            {
                PnlVentas.Height -= 10;
                if (PnlVentas.Size == PnlVentas.MinimumSize)
                {
                    TimerVenta.Stop();
                    isCollapsedVenta = true;
                }

            }
        }

        private void AbrirFormInPanel(object FormHijo)
        {
            if(this.pnlContenido.Controls.Count > 0)
            
                this.pnlContenido.Controls.RemoveAt(0);
                Form fh = FormHijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.pnlContenido.Controls.Add(fh);
                this.pnlContenido.Tag = fh;
                fh.Show();
            
        }
        private void BtnVentaDepartamento_Click(object sender, EventArgs e)
        {
           AbrirFormInPanel(new Frm_Venta_Departamento());
           Frm_Venta_Departamento fv = new Frm_Venta_Departamento(); 
        }

        private void BtnVentaCasaDuplex_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnVentaTipoCasa_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnVentaLocalGalpon_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnVentaLoteTerreno_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnAlquiler_Click(object sender, EventArgs e)
        {
            
            TimerAlquiler.Start();
            
        }

        private void TimerAlquiler_Tick(object sender, EventArgs e)
        {
            if (isCollapsedAlquiler)
            {
                PnlAlquileres.Height += 10;
                if (PnlAlquileres.Size == PnlAlquileres.MaximumSize)
                {
                    TimerAlquiler.Stop();
                    isCollapsedAlquiler = false;
                }

                PnlVentas.Height -= 20;
                if (PnlVentas.Size == PnlVentas.MinimumSize)
                {
                    TimerVenta.Stop();
                    isCollapsedVenta = true;
                }

                pnlNuevo.Height -= 10;
                if (pnlNuevo.Size == pnlNuevo.MinimumSize)
                {
                    TimerNuevo.Stop();
                    isCollapsedNuevo = true;
                }
            }
            else
            {
                PnlAlquileres.Height -= 10;
                if (PnlAlquileres.Size == PnlAlquileres.MinimumSize)
                {
                    TimerAlquiler.Stop();
                    isCollapsedAlquiler = true;
                }

            }
        }

        private void BtnAlquilerDepartamento_Click(object sender, EventArgs e)
        {

        }

        private void BtnAlquilerCasaDuplex_Click(object sender, EventArgs e)
        {

        }

        private void BtnAlquilerTipoCasa_Click(object sender, EventArgs e)
        {

        }

        private void BtnAlquilerLocalGalpon_Click(object sender, EventArgs e)
        {

        }
               
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            
            TimerNuevo.Start();
        }

        private void TimerNuevo_Tick(object sender, EventArgs e)
        {
            if (isCollapsedNuevo)
            {
                pnlNuevo.Height += 10;
                if (pnlNuevo.Size == pnlNuevo.MaximumSize)
                {
                    TimerNuevo.Stop();
                    isCollapsedNuevo = false;
                }

                PnlAlquileres.Height -= 20;
                if (PnlAlquileres.Size == PnlAlquileres.MinimumSize)
                {
                    TimerAlquiler.Stop();
                    isCollapsedAlquiler = true;
                }

                PnlVentas.Height -= 30;
                if (PnlVentas.Size == PnlVentas.MinimumSize)
                {
                    TimerVenta.Stop();
                    isCollapsedVenta = true;
                }
            }
            else
            {
                pnlNuevo.Height -= 10;
                if (pnlNuevo.Size == pnlNuevo.MinimumSize)
                {
                    TimerNuevo.Stop();
                    isCollapsedNuevo = true;
                }

            }
        }

        private void BtnNuevaVenta_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Frm_Nueva_Venta());
            Frm_Nueva_Venta fv = new Frm_Nueva_Venta();
        }

        private void BtnNuevoAlquiler_Click(object sender, EventArgs e)
        {

        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {

        }

       
    }
}
