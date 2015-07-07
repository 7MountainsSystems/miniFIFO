using System;
using GUIdefs;
using HWdefs;

using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace miniFIFO
{
    public partial class miniFIFO_HMI : Form
    {
        private FIFOexample CANdata = new FIFOexample();
        protected myFIFO tFIFO = new myFIFO();

        public miniFIFO_HMI()
        {
            InitializeComponent();
            CANdata.nError = 10;
            tFIFO.inErr(CANdata);
            CANdata.nError = 20;
            tFIFO.inErr(CANdata);
            FIFOexample getErrorNr = tFIFO.outErr();
            getErrorNr = tFIFO.outErr();
        }
    }
}
