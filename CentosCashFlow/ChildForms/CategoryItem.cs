using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace CentosCashFlow.ChildForms
{
    public partial class CategoryItem : UserControl
    {
        public CategoryItem()
        {
            InitializeComponent();
        }
        private void btnEditingCategory_Click(object sender, EventArgs e)
        {
            CategoryEditForm form = new CategoryEditForm();
            form.ShowDialog();
        }

        private void CategoryItem_Load(object sender, EventArgs e)
        {
            string pic_name = "puzzle-piece.png"; // Tên hình ảnh

            // Đường dẫn đầy đủ đến hình ảnh trong thư mục Resources (hoặc thư mục khác)
            string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.Windows.Forms.Application.StartupPath));
            string imagePath = Path.Combine(projectPath, @"Resources", pic_name);
            // Kiểm tra xem tệp hình ảnh có tồn tại không
            if (File.Exists(imagePath))
            {
                
                // Tạo hình ảnh từ tệp hình ảnh
                System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath);

                // Gán hình ảnh cho PictureBox
                pictureBoxCategory.Image = image;
            }
            else
            {
                pictureBoxCategory.Image = CentosCashFlow.Properties.Resources.category_df;
            }
        }
    }
}
