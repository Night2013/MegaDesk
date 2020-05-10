using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void width_input_Validating(object sender, CancelEventArgs e) : MainMenu
        {
            if (width_input > MAX_WIDTH && width_input)

        }

       
    }
}
