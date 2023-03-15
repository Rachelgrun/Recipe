using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecipeBizObjects;
using CPUFramework;

namespace RecipeWinForm
{
    public partial class frmRecipeDetail : Form
    {
        bizRecipe recipeobj = new bizRecipe();
        public frmRecipeDetail()
        {
            InitializeComponent();
            btnDelete.Click += BtnDelete_Click;
            btnSave.Click += BtnSave_Click;
  
        }

  

        public void ShowForm(int id)
        {
         
            recipeobj = bizRecipe.Get(id);

            lstCuisineType.DataSource = DataService.GetCuisineList(true);
            lstCuisineType.ValueMember = "CuisineTypeId";
            lstCuisineType.DisplayMember = "CuisineTypeName";
            lstCuisineType.DataBindings.Add("SelectedValue", recipeobj, "CuisineTypeId");


            lstUserName.DataSource = DataService.GetUserNameList(true);
            lstUserName.ValueMember = "UserId";
            lstUserName.DisplayMember = "FullName";
            lstUserName.DataBindings.Add("SelectedValue", recipeobj, "CreatedByUserId");


            DataTable dt = DataService.GetRecipeDetail(id);
            lblDateArchived.DataBindings.Add("Text", recipeobj, "DateArchived");
            lblDateDrafted.DataBindings.Add("Text", recipeobj, "DateDrafted");
            lblDatePublished.DataBindings.Add("Text", recipeobj, "DatePublished");
            lblRecipeStatus.DataBindings.Add("Text", recipeobj, "RecipeStatus");
            txtRecipeName.DataBindings.Add("Text", recipeobj, "RecipeName");
            txtNumCal.DataBindings.Add("Text", recipeobj, "Calories");
            txtNumIngredients.DataBindings.Add("Text", recipeobj, "NumberOfIngredients");
            txtNumSteps.DataBindings.Add("Text", recipeobj, "NumberOfSteps");
            gIngredientList.DataSource = DataService.GetIngredientList(id);
            gStepList.DataSource = DataService.GetStepList(id);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Show();
            this.FormatGrid(gIngredientList);
            this.FormatGrid(gStepList);


        }
        private void FormatGrid(DataGridView gridobj, string PrimaryKeyFieldName = "")
        {
            gridobj.ReadOnly = true;
            gridobj.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridobj.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gridobj.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridobj.RowHeadersWidth = 25;
            gridobj.AllowUserToAddRows = false;
            if (PrimaryKeyFieldName != "")
            {
                gridobj.Columns[PrimaryKeyFieldName].Visible = false;
            }

        }

        
        private void Save()
        {
            try
            {
                recipeobj.Save();
            }
            catch(CPUException ex)
            {
                MessageBox.Show(ex.Message,this.Text,MessageBoxButtons.OK);
            }
           

        }
        private void Delete()
        {
            recipeobj.Delete();
            this.Close();
        }
        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }
    }
}
