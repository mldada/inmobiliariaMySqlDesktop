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
    public partial class AlquilerCasaDuplex : DevExpress.XtraEditors.XtraUserControl
    {
        private static AlquilerCasaDuplex _instance;
        public static AlquilerCasaDuplex Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AlquilerCasaDuplex();
                return _instance;

            }
        }
        public AlquilerCasaDuplex()
        {
            InitializeComponent();
        }
    }
}
