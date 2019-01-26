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
    public partial class VentaTipoCasa : DevExpress.XtraEditors.XtraUserControl
    {
        private static VentaTipoCasa _instance;
        public static VentaTipoCasa Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new VentaTipoCasa();
                return _instance;

            }
        }
        public VentaTipoCasa()
        {
            InitializeComponent();
        }
    }
}
