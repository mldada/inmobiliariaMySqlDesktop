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
    public partial class Buscar : DevExpress.XtraEditors.XtraUserControl
    {
        private static Buscar _instance;
        public static Buscar Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Buscar();
                return _instance;

            }
        }
        public Buscar()
        {
            InitializeComponent();
        }
    }
}
