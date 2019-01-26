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
    public partial class Inicio : DevExpress.XtraEditors.XtraUserControl
    {
        private static Inicio _instance;
        public static Inicio Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Inicio();
                return _instance;

            }
        }
        public Inicio()
        {
            InitializeComponent();
        }
    }
}
