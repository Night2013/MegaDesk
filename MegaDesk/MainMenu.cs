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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddQuote aq = new AddQuote();
            aq.ShowDialog();
            this.Close();
        }

        private void view_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAllQuotes view = new ViewAllQuotes();
            view.ShowDialog();
            this.Close();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchQuote search = new SearchQuote();
            search.ShowDialog();
            this.Close();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
