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
    public partial class AlquilerLocalGalpon : DevExpress.XtraEditors.XtraUserControl
    {
        private static AlquilerLocalGalpon _instance;
        public static AlquilerLocalGalpon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AlquilerLocalGalpon();
                return _instance;

            }
        }
        public AlquilerLocalGalpon()
        {
            InitializeComponent();
        }
    }
}
