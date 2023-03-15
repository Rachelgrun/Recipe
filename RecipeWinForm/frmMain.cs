using RecipeBizObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPUFramework;

namespace RecipeWinForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
 
            DataUtility.SetConnectionString("rgrunwald.database.windows.net,1433", "RecipeDB", "rgrunwaldadmin", "CPU123!@#");
            BindForm();
            gRecipeList.CellDoubleClick += GRecipeList_CellDoubleClick;
            btnNewRecipe.Click += BtnNewRecipe_Click;
         

        }

   

        private void BindForm()
        {
            this.FormatGrid(gRecipeSummary);
            this.FormatGrid(gRecipeList);
            gRecipeSummary.DataSource = DataService.GetRecipeBookSummary();
            gRecipeList.DataSource = DataService.GetRecipeList();
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
        private void CreateNewRecipe()
        {
            
              frmRecipeDetail f = new frmRecipeDetail();
                f.ShowForm(0);

            
           
            
        }

        private void GRecipeList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            int id = (int)gRecipeList.Rows[e.RowIndex].Cells["RecipeId"].Value;
            frmRecipeDetail f = new frmRecipeDetail();
            f.ShowForm(id);
            
        }
        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            CreateNewRecipe();
        }


    }
}
