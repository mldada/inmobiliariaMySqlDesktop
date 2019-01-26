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
    public partial class VentaLocalGalpon : DevExpress.XtraEditors.XtraUserControl
    {
        private static VentaLocalGalpon _instance;
        public static VentaLocalGalpon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new VentaLocalGalpon();
                return _instance;

            }
        }
        public VentaLocalGalpon()
        {
            InitializeComponent();
        }
    }
}
