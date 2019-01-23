using System;
using System.Windows.Forms;
using BL;
using ENTIDAD;


namespace Inmobiliaria
{
    public partial class Frm_Venta_Departamento : Form
    {
        Inmueble_BL inmueble_BL = new Inmueble_BL();
      

        public Frm_Venta_Departamento()
        {
            InitializeComponent();
        }

        public void MostrarInmuebles()
        {
            dgVentas.AutoGenerateColumns = false;
            dgVentas.DataSource = inmueble_BL.BuscarInmuebles(Convert.ToInt32(TipoPropiedad_E.TipoPropiedad.Departamento), Convert.ToBoolean(TipoPropiedad_E.TipoOperacion.Venta));
        }

        private void Frm_Departamento_Load(object sender, EventArgs e)
        {
            MostrarInmuebles();
        }
    }
}
