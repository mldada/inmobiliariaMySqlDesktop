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

namespace Inmobiliaria
{
    public partial class VentaLoteTerreno : DevExpress.XtraEditors.XtraUserControl
    {
        private static VentaLoteTerreno _instance;
        public static VentaLoteTerreno Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new VentaLoteTerreno();
                return _instance;

            }
        }
        public VentaLoteTerreno()
        {
            InitializeComponent();
        }
    }
}
