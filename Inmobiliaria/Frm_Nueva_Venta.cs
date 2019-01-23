using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDAD;
using BL;


namespace Inmobiliaria
{
    public partial class Frm_Nueva_Venta : Form
    {
        Inmueble_BL inmueble_BL = new Inmueble_BL();

        private void AbrirFormInPanel(object FormHijo)
        {
            if (this.pnlContenido.Controls.Count > 0)

                this.pnlContenido.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenido.Controls.Add(fh);
            this.pnlContenido.Tag = fh;
            fh.Show();

        }

        public Frm_Nueva_Venta()
        {
            InitializeComponent();
        }

        private void Frm_Nueva_Venta_Load(object sender, EventArgs e)
        {
            CboVentaTipoPropiedad();
            CboLocalidad();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Inmueble_E inmueble = new Inmueble_E();
                inmueble.tipoPropiedad_E.Id_Tipo_Propiedad = Convert.ToInt32(cboTipoPropiedad.SelectedValue);
                inmueble.Es_Venta = Convert.ToBoolean(TipoPropiedad_E.TipoOperacion.Venta);
                inmueble.Importe = Convert.ToInt32(txtImporte.Text);
                inmueble.Superficie = Convert.ToInt32(txtSuperficie.Text);
                inmueble.Calle = txtCalle.Text;
                inmueble.Altura = Convert.ToInt32(txtAltura.Text);
                inmueble.localidad_E.Id_Localidad = Convert.ToInt32(cboLocalidad.SelectedValue);
                inmueble.Descripcion = txtDescripcion.Text;
                inmueble.estado_E.Id_Estado = Convert.ToInt32(Estado_E.Estado.Publicado);
                inmueble.Cant_Ambientes = Convert.ToInt32(txtCantAmbientes.Text);
                inmueble.Piso = txtPiso.Text;
                inmueble.Depto = txtDepto.Text;
                inmueble.Apto_Credito = chkAptoCredito.Checked;
                inmueble_BL.AgregarInmueble(inmueble);

                AbrirFormInPanel(new Frm_Venta_Departamento());
                Frm_Venta_Departamento fv = new Frm_Venta_Departamento();


                //switch (cboTipoPropiedad.SelectedValue)
                //{
                //    case TipoPropiedad_E.TipoPropiedad.Departamento:
                        
                //        break;

                //    case TipoPropiedad_E.TipoPropiedad.CasaDuplex:

                //        break;

                //    case TipoPropiedad_E.TipoPropiedad.TipoCasa:

                //        break;

                //    case TipoPropiedad_E.TipoPropiedad.LocalGalpon:

                //        break;

                //    default: 

                //        break;
                //}

            }
            catch (Exception)
            {

                throw;
            }

            
        }

        public void CboVentaTipoPropiedad()
        {
            List<TipoPropiedad_E> lstTiposPropiedades = new List<TipoPropiedad_E>();
            TipoPropiedad_BL tipoPropiedadBL = new TipoPropiedad_BL();
            lstTiposPropiedades = tipoPropiedadBL.VentaTipoPropiedad();
            cboTipoPropiedad.DataSource =  lstTiposPropiedades;           
            cboTipoPropiedad.ValueMember = "id_tipo_propiedad";
            cboTipoPropiedad.DisplayMember = "dc_tipo_propiedad";
        }

        public void CboLocalidad()
        {
            List<Localidad_E> lstLocalidades = new List<Localidad_E>();
            Localidad_BL LocalidadBL = new Localidad_BL();
            lstLocalidades = LocalidadBL.ListadoLocalidad();
            cboLocalidad.DataSource = lstLocalidades;
            cboLocalidad.ValueMember = "id_localidad";
            cboLocalidad.DisplayMember = "dc_localidad";
        }
    }
}
