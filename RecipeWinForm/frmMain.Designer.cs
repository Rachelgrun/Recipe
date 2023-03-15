namespace RecipeWinForm
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.gRecipeSummary = new System.Windows.Forms.DataGridView();
            this.gRecipeList = new System.Windows.Forms.DataGridView();
            this.tblNewRecipe = new System.Windows.Forms.TableLayoutPanel();
            this.btnNewRecipe = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipeSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipeList)).BeginInit();
            this.tblNewRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.gRecipeSummary, 0, 0);
            this.tblMain.Controls.Add(this.gRecipeList, 1, 0);
            this.tblMain.Controls.Add(this.tblNewRecipe, 0, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblMain.Size = new System.Drawing.Size(1964, 1197);
            this.tblMain.TabIndex = 0;
            // 
            // gRecipeSummary
            // 
            this.gRecipeSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gRecipeSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gRecipeSummary.Location = new System.Drawing.Point(3, 3);
            this.gRecipeSummary.Name = "gRecipeSummary";
            this.gRecipeSummary.RowHeadersWidth = 123;
            this.gRecipeSummary.RowTemplate.Height = 57;
            this.gRecipeSummary.Size = new System.Drawing.Size(976, 991);
            this.gRecipeSummary.TabIndex = 0;
            // 
            // gRecipeList
            // 
            this.gRecipeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gRecipeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gRecipeList.Location = new System.Drawing.Point(985, 3);
            this.gRecipeList.Name = "gRecipeList";
            this.gRecipeList.RowHeadersWidth = 123;
            this.gRecipeList.RowTemplate.Height = 57;
            this.gRecipeList.Size = new System.Drawing.Size(976, 991);
            this.gRecipeList.TabIndex = 1;
            // 
            // tblNewRecipe
            // 
            this.tblNewRecipe.ColumnCount = 2;
            this.tblNewRecipe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNewRecipe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNewRecipe.Controls.Add(this.btnNewRecipe, 0, 0);
            this.tblNewRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblNewRecipe.Location = new System.Drawing.Point(3, 1000);
            this.tblNewRecipe.Name = "tblNewRecipe";
            this.tblNewRecipe.RowCount = 1;
            this.tblNewRecipe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblNewRecipe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblNewRecipe.Size = new System.Drawing.Size(976, 194);
            this.tblNewRecipe.TabIndex = 2;
            // 
            // btnNewRecipe
            // 
            this.btnNewRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewRecipe.Location = new System.Drawing.Point(3, 3);
            this.btnNewRecipe.Name = "btnNewRecipe";
            this.btnNewRecipe.Size = new System.Drawing.Size(482, 188);
            this.btnNewRecipe.TabIndex = 0;
            this.btnNewRecipe.Text = "New Recipe";
            this.btnNewRecipe.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1964, 1197);
            this.Controls.Add(this.tblMain);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gRecipeSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRecipeList)).EndInit();
            this.tblNewRecipe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView gRecipeSummary;
        private DataGridView gRecipeList;
        private TableLayoutPanel tblNewRecipe;
        private Button btnNewRecipe;
    }
}