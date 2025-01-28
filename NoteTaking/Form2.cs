using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaking
{
    public partial class Form2 : Form
    {
        private string title;
        private string message;
        public Form2(string title, string message)
        {
            InitializeComponent();

            this.title = title;
            this.message = message;

            Form2_TitleOutput.Text = title;
            Form2_MessageOutput.Text = message;



        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
