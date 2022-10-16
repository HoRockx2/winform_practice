using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsFormsApp1
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();

            titleLabel.Text = AssemblyGetter.GetTitle();
            descriptionTextBox.Text = AssemblyGetter.GetDescription();
            FilePath.Text = FileIO.FilePath;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            Logger.Start();

            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
