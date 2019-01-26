using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ENTIDAD;
using BL;

namespace Inmobiliaria
{
    public partial class NuevoAlquiler : DevExpress.XtraEditors.XtraUserControl
    {
        Inmueble_BL inmueble_BL = new Inmueble_BL();
        private static NuevoAlquiler _instance;
        public static NuevoAlquiler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NuevoAlquiler();
                return _instance;

            }
        }
        public NuevoAlquiler()
        {
            InitializeComponent();
        }

        private void NuevaVenta_Load(object sender, EventArgs e)
        {
            CboAlquilerTipoPropiedad();
            CboLocalidad();
        }
        public void CboAlquilerTipoPropiedad()
        {
            List<TipoPropiedad_E> lstTiposPropiedades = new List<TipoPropiedad_E>();
            TipoPropiedad_BL tipoPropiedadBL = new TipoPropiedad_BL();
            lstTiposPropiedades = tipoPropiedadBL.AlquilerTipoPropiedad();
            cboTipoPropiedad.DataSource = lstTiposPropiedades;            
            cboTipoPropiedad.ValueMember = "id_tipo_propiedad";
            cboTipoPropiedad.DisplayMember = "dc_tipo_propiedad";
            cboTipoPropiedad.Text = "(seleccionar)";
        }
        public void CboLocalidad()
        {
            List<Localidad_E> lstLocalidades = new List<Localidad_E>();
            Localidad_BL LocalidadBL = new Localidad_BL();
            lstLocalidades = LocalidadBL.ListadoLocalidad();
            cboLocalidades.DataSource = lstLocalidades;
            cboLocalidades.ValueMember = "id_localidad";
            cboLocalidades.DisplayMember = "dc_localidad";
            cboLocalidades.Text = "(seleccionar)";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
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
                inmueble.localidad_E.Id_Localidad = Convert.ToInt32(cboLocalidades.SelectedValue);
                inmueble.Descripcion = txtDescripcion.Text;
                inmueble.estado_E.Id_Estado = Convert.ToInt32(Estado_E.Estado.Publicado);
                inmueble.Cant_Ambientes = Convert.ToInt32(txtCantAmbientes.Text);
                inmueble.Piso = txtPiso.Text;
                inmueble.Depto = txtDepto.Text;
                inmueble.Apto_Credito = false;
                inmueble_BL.AgregarInmueble(inmueble);
                DialogResult rs = MessageBox.Show("Guardado");
                LimpiarFormulario();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void LimpiarFormulario()
        {
            txtImporte.Text = "";
            txtSuperficie.Text = "";
            txtCalle.Text = "";
            txtAltura.Text = "";
            txtDescripcion.Text = "";
            txtCantAmbientes.Text = "";
            txtPiso.Text = "";
            txtDepto.Text = "";            
            cboLocalidades.Text = "(seleccionar)";
            cboTipoPropiedad.Text = "(seleccionar)";
        }
    }
}
