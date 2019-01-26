using System;
using BL;
using ENTIDAD;

namespace Inmobiliaria
{
    public partial class VentaCasaDuplex : DevExpress.XtraEditors.XtraUserControl
    {
        Inmueble_BL inmueble_BL = new Inmueble_BL();
        private static VentaCasaDuplex _instance;
        public static VentaCasaDuplex Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new VentaCasaDuplex();
                return _instance;

            }
        }
        public VentaCasaDuplex()
        {
            InitializeComponent();
        }

      
    }

 

    
}
