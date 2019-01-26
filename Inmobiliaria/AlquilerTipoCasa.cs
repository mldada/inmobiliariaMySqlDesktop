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
    public partial class AlquilerTipoCasa : DevExpress.XtraEditors.XtraUserControl
    {

        private static AlquilerTipoCasa _instance;
        public static AlquilerTipoCasa Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AlquilerTipoCasa();
                return _instance;

            }
        }
        public AlquilerTipoCasa()
        {
            InitializeComponent();
        }
    }
}
