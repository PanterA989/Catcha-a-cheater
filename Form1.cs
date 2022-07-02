using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catcha_a_cheater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeCustomFonts();
        }

        /// <summary>
        /// Loads and sets custom fonts used in 
        /// </summary>
        private void InitializeCustomFonts()
        {
            //Initialize your private font collection object.
            PrivateFontCollection pfc = new();

            var fontLength = Properties.Resources.Anton_Regular.Length;

            //Create a buffer to read in to
            var fontdata = Properties.Resources.Anton_Regular;

            //Create an unsafe memory block for the font data
            var data = Marshal.AllocCoTaskMem(fontLength);

            //Copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            //Pass the font to the font collection
            pfc.AddMemoryFont(data, fontLength);

            cacLabel.Font = new Font(pfc.Families[0], cacLabel.Font.Size);
            cacLabel.Text = Properties.Resources.ResourceManager.GetString("cacLabelText");
        }
    }
}
