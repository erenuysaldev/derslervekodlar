using StockMasterApp.Data.Dal;
using StockMasterApp.Forms;
using StockMasterApp.Models.CategoryModels;

namespace StockMasterApp
{
    public partial class CategoriesForm : Form
    {
        private CategoryDal categoryDal;
        private bool isEditMode = true;
        public CategoriesForm()
        {
            InitializeComponent();
            categoryDal = new CategoryDal();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Forms.CategoriesForm categoriesForm = new Forms.CategoriesForm();
            categoriesForm.Show();
        }

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }


        private void LoadCategories()
        {
            List<CategoryModel> categories = categoryDal.GetAll();
            gridCategories.DataSource = categories;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                isEditMode = false;
                btnAdd.Text = "Kaydet";
                txtName.Clear();
                txtDescription.Clear();
                txtName.Focus();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                gridCategories.Enabled = false;
                txtName.Focus();
            }
            else
            {
                AddCategoryModel model = new()
                {
                    Name = txtName.Text.Trim(),
                    Description = txtDescription.Text.Trim()
                };
                var result = categoryDal.CreateOrUpdate(model);
                if (result)
                {
                    MessageBox.Show("Kayýt iþlemi baþarýyla tamamlanmýþtýr!");
                    LoadCategories();


                    isEditMode = true;
                    btnAdd.Text = "Ekle";
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    gridCategories.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Bir sorun oluþtu, tekrar deneyiniz!");
                }


            }
        }

        private void gridCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateCategoryModel model = new()
            {
                Id = (int)gridCategories.CurrentRow.Cells[0].Value,
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim()
            };
            var result = categoryDal.CreateOrUpdate(model, model.Id);
            if (result)
            {
                MessageBox.Show("Güncelleme iþlemi baþarýyla tamamlanmýþtýr.");
                LoadCategories();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)gridCategories.CurrentRow.Cells[0].Value;
            var result = categoryDal.Delete(id);
            if (result)
            {
                MessageBox.Show("Kayýt baþarýyla silinimþtir");
                LoadCategories();
            }
        }

        private void gridCategories_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = gridCategories.CurrentRow.Cells[1].Value.ToString();
            txtDescription.Text = gridCategories.CurrentRow.Cells[2].Value.ToString();
        }
    }
}