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
    public partial class AlquilerDepartamento : DevExpress.XtraEditors.XtraUserControl
    {
        private static AlquilerDepartamento _instance;
        public static AlquilerDepartamento Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AlquilerDepartamento();
                return _instance;

            }
        }
        public AlquilerDepartamento()
        {
            InitializeComponent();
        }
    }
}
