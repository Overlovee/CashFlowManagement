using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentosCashFlow.ChildForms
{
    public partial class CategoryAddingForm : Form
    {
        public CategoryAddingForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog df = new OpenFileDialog() { Filter= "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png" })
            {
                if(df.ShowDialog() == DialogResult.OK)
                {
                    //pictureBox1.BackgroundImage = Image.FromFile(df.FileName);
                    textBoxCategoryImgPath.Text= df.FileName;
                }
            }
        }
    }
}
