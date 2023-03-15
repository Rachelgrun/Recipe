namespace RecipeWinForm
{
    partial class frmRecipeDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblRecipeName = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.tblNumCal = new System.Windows.Forms.TableLayoutPanel();
            this.txtNumCal = new System.Windows.Forms.TextBox();
            this.lblNumberCal = new System.Windows.Forms.Label();
            this.tblNumIngredients = new System.Windows.Forms.TableLayoutPanel();
            this.txtNumIngredients = new System.Windows.Forms.TextBox();
            this.lblNumIngredients = new System.Windows.Forms.Label();
            this.tblNumSteps = new System.Windows.Forms.TableLayoutPanel();
            this.txtNumSteps = new System.Windows.Forms.TextBox();
            this.lblNumSteps = new System.Windows.Forms.Label();
            this.gIngredientList = new System.Windows.Forms.DataGridView();
            this.gStepList = new System.Windows.Forms.DataGridView();
            this.tblSaveDelete = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tblDateDrafted = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateDraftedLabel = new System.Windows.Forms.Label();
            this.lblDateDrafted = new System.Windows.Forms.Label();
            this.tblDatePublished = new System.Windows.Forms.TableLayoutPanel();
            this.lblDatePublishedLabel = new System.Windows.Forms.Label();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.tbleDateArchived = new System.Windows.Forms.TableLayoutPanel();
            this.lblDateArchivedLabel = new System.Windows.Forms.Label();
            this.lblDateArchived = new System.Windows.Forms.Label();
            this.tblRecipeStatus = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecipeStatusLabel = new System.Windows.Forms.Label();
            this.lblRecipeStatus = new System.Windows.Forms.Label();
            this.tblUserName = new System.Windows.Forms.TableLayoutPanel();
            this.lstUserName = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.tblCuisineType = new System.Windows.Forms.TableLayoutPanel();
            this.lstCuisineType = new System.Windows.Forms.ComboBox();
            this.lblCuisineType = new System.Windows.Forms.Label();
            this.tblMain.SuspendLayout();
            this.tblRecipeName.SuspendLayout();
            this.tblNumCal.SuspendLayout();
            this.tblNumIngredients.SuspendLayout();
            this.tblNumSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIngredientList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gStepList)).BeginInit();
            this.tblSaveDelete.SuspendLayout();
            this.tblDateDrafted.SuspendLayout();
            this.tblDatePublished.SuspendLayout();
            this.tbleDateArchived.SuspendLayout();
            this.tblRecipeStatus.SuspendLayout();
            this.tblUserName.SuspendLayout();
            this.tblCuisineType.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 4;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.64103F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.64103F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.64103F));
            this.tblMain.Controls.Add(this.tblRecipeName, 0, 0);
            this.tblMain.Controls.Add(this.tblNumCal, 1, 1);
            this.tblMain.Controls.Add(this.tblNumIngredients, 2, 1);
            this.tblMain.Controls.Add(this.tblNumSteps, 3, 1);
            this.tblMain.Controls.Add(this.gIngredientList, 0, 2);
            this.tblMain.Controls.Add(this.gStepList, 2, 2);
            this.tblMain.Controls.Add(this.tblSaveDelete, 0, 5);
            this.tblMain.Controls.Add(this.tblDateDrafted, 1, 0);
            this.tblMain.Controls.Add(this.tblDatePublished, 2, 0);
            this.tblMain.Controls.Add(this.tbleDateArchived, 3, 0);
            this.tblMain.Controls.Add(this.tblRecipeStatus, 0, 1);
            this.tblMain.Controls.Add(this.tblUserName, 3, 5);
            this.tblMain.Controls.Add(this.tblCuisineType, 2, 5);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(2);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 6;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.30664F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.30663F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.30664F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.30664F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.72997F));
            this.tblMain.Size = new System.Drawing.Size(1490, 1056);
            this.tblMain.TabIndex = 0;
            // 
            // tblRecipeName
            // 
            this.tblRecipeName.ColumnCount = 1;
            this.tblRecipeName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRecipeName.Controls.Add(this.lblRecipeName, 0, 0);
            this.tblRecipeName.Controls.Add(this.txtRecipeName, 0, 1);
            this.tblRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRecipeName.Location = new System.Drawing.Point(2, 2);
            this.tblRecipeName.Margin = new System.Windows.Forms.Padding(2);
            this.tblRecipeName.Name = "tblRecipeName";
            this.tblRecipeName.RowCount = 2;
            this.tblRecipeName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRecipeName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRecipeName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tblRecipeName.Size = new System.Drawing.Size(339, 133);
            this.tblRecipeName.TabIndex = 10;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeName.Location = new System.Drawing.Point(2, 0);
            this.lblRecipeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(335, 66);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.Text = "Recipe Name:";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Location = new System.Drawing.Point(2, 68);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(2);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(335, 55);
            this.txtRecipeName.TabIndex = 4;
            // 
            // tblNumCal
            // 
            this.tblNumCal.ColumnCount = 1;
            this.tblNumCal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblNumCal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblNumCal.Controls.Add(this.txtNumCal, 0, 1);
            this.tblNumCal.Controls.Add(this.lblNumberCal, 0, 0);
            this.tblNumCal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblNumCal.Location = new System.Drawing.Point(345, 139);
            this.tblNumCal.Margin = new System.Windows.Forms.Padding(2);
            this.tblNumCal.Name = "tblNumCal";
            this.tblNumCal.RowCount = 2;
            this.tblNumCal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNumCal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNumCal.Size = new System.Drawing.Size(378, 189);
            this.tblNumCal.TabIndex = 11;
            // 
            // txtNumCal
            // 
            this.txtNumCal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNumCal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumCal.Location = new System.Drawing.Point(2, 96);
            this.txtNumCal.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumCal.Name = "txtNumCal";
            this.txtNumCal.Size = new System.Drawing.Size(374, 55);
            this.txtNumCal.TabIndex = 5;
            // 
            // lblNumberCal
            // 
            this.lblNumberCal.AutoSize = true;
            this.lblNumberCal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumberCal.Location = new System.Drawing.Point(2, 0);
            this.lblNumberCal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberCal.Name = "lblNumberCal";
            this.lblNumberCal.Size = new System.Drawing.Size(374, 94);
            this.lblNumberCal.TabIndex = 1;
            this.lblNumberCal.Text = "Number Of Calories:";
            // 
            // tblNumIngredients
            // 
            this.tblNumIngredients.ColumnCount = 1;
            this.tblNumIngredients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblNumIngredients.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblNumIngredients.Controls.Add(this.txtNumIngredients, 0, 1);
            this.tblNumIngredients.Controls.Add(this.lblNumIngredients, 0, 0);
            this.tblNumIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblNumIngredients.Location = new System.Drawing.Point(727, 139);
            this.tblNumIngredients.Margin = new System.Windows.Forms.Padding(2);
            this.tblNumIngredients.Name = "tblNumIngredients";
            this.tblNumIngredients.RowCount = 2;
            this.tblNumIngredients.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNumIngredients.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNumIngredients.Size = new System.Drawing.Size(378, 189);
            this.tblNumIngredients.TabIndex = 12;
            // 
            // txtNumIngredients
            // 
            this.txtNumIngredients.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNumIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumIngredients.Location = new System.Drawing.Point(2, 96);
            this.txtNumIngredients.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumIngredients.Name = "txtNumIngredients";
            this.txtNumIngredients.Size = new System.Drawing.Size(374, 55);
            this.txtNumIngredients.TabIndex = 6;
            // 
            // lblNumIngredients
            // 
            this.lblNumIngredients.AutoSize = true;
            this.lblNumIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumIngredients.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumIngredients.Location = new System.Drawing.Point(2, 0);
            this.lblNumIngredients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumIngredients.Name = "lblNumIngredients";
            this.lblNumIngredients.Size = new System.Drawing.Size(374, 94);
            this.lblNumIngredients.TabIndex = 2;
            this.lblNumIngredients.Text = "Number Of Ingredients:";
            // 
            // tblNumSteps
            // 
            this.tblNumSteps.ColumnCount = 1;
            this.tblNumSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblNumSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblNumSteps.Controls.Add(this.txtNumSteps, 0, 1);
            this.tblNumSteps.Controls.Add(this.lblNumSteps, 0, 0);
            this.tblNumSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblNumSteps.Location = new System.Drawing.Point(1109, 139);
            this.tblNumSteps.Margin = new System.Windows.Forms.Padding(2);
            this.tblNumSteps.Name = "tblNumSteps";
            this.tblNumSteps.RowCount = 2;
            this.tblNumSteps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNumSteps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNumSteps.Size = new System.Drawing.Size(379, 189);
            this.tblNumSteps.TabIndex = 13;
            // 
            // txtNumSteps
            // 
            this.txtNumSteps.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNumSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumSteps.Location = new System.Drawing.Point(2, 96);
            this.txtNumSteps.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumSteps.Name = "txtNumSteps";
            this.txtNumSteps.Size = new System.Drawing.Size(375, 55);
            this.txtNumSteps.TabIndex = 7;
            // 
            // lblNumSteps
            // 
            this.lblNumSteps.AutoSize = true;
            this.lblNumSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumSteps.Location = new System.Drawing.Point(2, 0);
            this.lblNumSteps.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumSteps.Name = "lblNumSteps";
            this.lblNumSteps.Size = new System.Drawing.Size(375, 94);
            this.lblNumSteps.TabIndex = 3;
            this.lblNumSteps.Text = "Number Of Steps:";
            // 
            // gIngredientList
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gIngredientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gIngredientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMain.SetColumnSpan(this.gIngredientList, 2);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gIngredientList.DefaultCellStyle = dataGridViewCellStyle2;
            this.gIngredientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gIngredientList.Location = new System.Drawing.Point(2, 332);
            this.gIngredientList.Margin = new System.Windows.Forms.Padding(2);
            this.gIngredientList.Name = "gIngredientList";
            this.gIngredientList.RowHeadersWidth = 123;
            this.tblMain.SetRowSpan(this.gIngredientList, 3);
            this.gIngredientList.RowTemplate.Height = 57;
            this.gIngredientList.Size = new System.Drawing.Size(721, 575);
            this.gIngredientList.TabIndex = 14;
            // 
            // gStepList
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gStepList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gStepList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMain.SetColumnSpan(this.gStepList, 2);
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gStepList.DefaultCellStyle = dataGridViewCellStyle4;
            this.gStepList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gStepList.Location = new System.Drawing.Point(727, 332);
            this.gStepList.Margin = new System.Windows.Forms.Padding(2);
            this.gStepList.Name = "gStepList";
            this.gStepList.RowHeadersWidth = 123;
            this.tblMain.SetRowSpan(this.gStepList, 3);
            this.gStepList.RowTemplate.Height = 57;
            this.gStepList.Size = new System.Drawing.Size(761, 575);
            this.gStepList.TabIndex = 15;
            // 
            // tblSaveDelete
            // 
            this.tblSaveDelete.ColumnCount = 2;
            this.tblMain.SetColumnSpan(this.tblSaveDelete, 2);
            this.tblSaveDelete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSaveDelete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSaveDelete.Controls.Add(this.btnSave, 1, 0);
            this.tblSaveDelete.Controls.Add(this.btnDelete, 0, 0);
            this.tblSaveDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSaveDelete.Location = new System.Drawing.Point(2, 911);
            this.tblSaveDelete.Margin = new System.Windows.Forms.Padding(2);
            this.tblSaveDelete.Name = "tblSaveDelete";
            this.tblSaveDelete.RowCount = 1;
            this.tblSaveDelete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSaveDelete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tblSaveDelete.Size = new System.Drawing.Size(721, 143);
            this.tblSaveDelete.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(362, 2);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(357, 139);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(2, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(356, 139);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // tblDateDrafted
            // 
            this.tblDateDrafted.ColumnCount = 1;
            this.tblDateDrafted.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDateDrafted.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDateDrafted.Controls.Add(this.lblDateDraftedLabel, 0, 0);
            this.tblDateDrafted.Controls.Add(this.lblDateDrafted, 0, 1);
            this.tblDateDrafted.Location = new System.Drawing.Point(345, 2);
            this.tblDateDrafted.Margin = new System.Windows.Forms.Padding(2);
            this.tblDateDrafted.Name = "tblDateDrafted";
            this.tblDateDrafted.RowCount = 2;
            this.tblDateDrafted.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDateDrafted.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDateDrafted.Size = new System.Drawing.Size(375, 132);
            this.tblDateDrafted.TabIndex = 17;
            // 
            // lblDateDraftedLabel
            // 
            this.lblDateDraftedLabel.AutoSize = true;
            this.lblDateDraftedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateDraftedLabel.Location = new System.Drawing.Point(2, 0);
            this.lblDateDraftedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateDraftedLabel.Name = "lblDateDraftedLabel";
            this.lblDateDraftedLabel.Size = new System.Drawing.Size(371, 66);
            this.lblDateDraftedLabel.TabIndex = 0;
            this.lblDateDraftedLabel.Text = "Date Drafted:";
            // 
            // lblDateDrafted
            // 
            this.lblDateDrafted.AutoSize = true;
            this.lblDateDrafted.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDateDrafted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateDrafted.Location = new System.Drawing.Point(2, 66);
            this.lblDateDrafted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateDrafted.Name = "lblDateDrafted";
            this.lblDateDrafted.Size = new System.Drawing.Size(371, 66);
            this.lblDateDrafted.TabIndex = 1;
            // 
            // tblDatePublished
            // 
            this.tblDatePublished.ColumnCount = 1;
            this.tblDatePublished.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDatePublished.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDatePublished.Controls.Add(this.lblDatePublishedLabel, 0, 0);
            this.tblDatePublished.Controls.Add(this.lblDatePublished, 0, 1);
            this.tblDatePublished.Location = new System.Drawing.Point(727, 2);
            this.tblDatePublished.Margin = new System.Windows.Forms.Padding(2);
            this.tblDatePublished.Name = "tblDatePublished";
            this.tblDatePublished.RowCount = 2;
            this.tblDatePublished.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDatePublished.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDatePublished.Size = new System.Drawing.Size(375, 132);
            this.tblDatePublished.TabIndex = 18;
            // 
            // lblDatePublishedLabel
            // 
            this.lblDatePublishedLabel.AutoSize = true;
            this.lblDatePublishedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatePublishedLabel.Location = new System.Drawing.Point(2, 0);
            this.lblDatePublishedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatePublishedLabel.Name = "lblDatePublishedLabel";
            this.lblDatePublishedLabel.Size = new System.Drawing.Size(371, 66);
            this.lblDatePublishedLabel.TabIndex = 0;
            this.lblDatePublishedLabel.Text = "Date Published:";
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDatePublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatePublished.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDatePublished.Location = new System.Drawing.Point(2, 66);
            this.lblDatePublished.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(371, 66);
            this.lblDatePublished.TabIndex = 1;
            // 
            // tbleDateArchived
            // 
            this.tbleDateArchived.ColumnCount = 1;
            this.tbleDateArchived.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbleDateArchived.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbleDateArchived.Controls.Add(this.lblDateArchivedLabel, 0, 0);
            this.tbleDateArchived.Controls.Add(this.lblDateArchived, 0, 1);
            this.tbleDateArchived.Location = new System.Drawing.Point(1109, 2);
            this.tbleDateArchived.Margin = new System.Windows.Forms.Padding(2);
            this.tbleDateArchived.Name = "tbleDateArchived";
            this.tbleDateArchived.RowCount = 2;
            this.tbleDateArchived.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbleDateArchived.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbleDateArchived.Size = new System.Drawing.Size(378, 132);
            this.tbleDateArchived.TabIndex = 19;
            // 
            // lblDateArchivedLabel
            // 
            this.lblDateArchivedLabel.AutoSize = true;
            this.lblDateArchivedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateArchivedLabel.Location = new System.Drawing.Point(2, 0);
            this.lblDateArchivedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateArchivedLabel.Name = "lblDateArchivedLabel";
            this.lblDateArchivedLabel.Size = new System.Drawing.Size(374, 66);
            this.lblDateArchivedLabel.TabIndex = 0;
            this.lblDateArchivedLabel.Text = "Date Archived:";
            // 
            // lblDateArchived
            // 
            this.lblDateArchived.AutoSize = true;
            this.lblDateArchived.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDateArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateArchived.Location = new System.Drawing.Point(2, 66);
            this.lblDateArchived.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateArchived.Name = "lblDateArchived";
            this.lblDateArchived.Size = new System.Drawing.Size(374, 66);
            this.lblDateArchived.TabIndex = 1;
            // 
            // tblRecipeStatus
            // 
            this.tblRecipeStatus.ColumnCount = 1;
            this.tblRecipeStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRecipeStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblRecipeStatus.Controls.Add(this.lblRecipeStatusLabel, 0, 0);
            this.tblRecipeStatus.Controls.Add(this.lblRecipeStatus, 0, 1);
            this.tblRecipeStatus.Location = new System.Drawing.Point(2, 139);
            this.tblRecipeStatus.Margin = new System.Windows.Forms.Padding(2);
            this.tblRecipeStatus.Name = "tblRecipeStatus";
            this.tblRecipeStatus.RowCount = 2;
            this.tblRecipeStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRecipeStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRecipeStatus.Size = new System.Drawing.Size(338, 187);
            this.tblRecipeStatus.TabIndex = 20;
            // 
            // lblRecipeStatusLabel
            // 
            this.lblRecipeStatusLabel.AutoSize = true;
            this.lblRecipeStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeStatusLabel.Location = new System.Drawing.Point(2, 0);
            this.lblRecipeStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecipeStatusLabel.Name = "lblRecipeStatusLabel";
            this.lblRecipeStatusLabel.Size = new System.Drawing.Size(334, 93);
            this.lblRecipeStatusLabel.TabIndex = 0;
            this.lblRecipeStatusLabel.Text = "Recipe Status:";
            // 
            // lblRecipeStatus
            // 
            this.lblRecipeStatus.AutoSize = true;
            this.lblRecipeStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRecipeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeStatus.Location = new System.Drawing.Point(2, 93);
            this.lblRecipeStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecipeStatus.Name = "lblRecipeStatus";
            this.lblRecipeStatus.Size = new System.Drawing.Size(334, 94);
            this.lblRecipeStatus.TabIndex = 1;
            // 
            // tblUserName
            // 
            this.tblUserName.ColumnCount = 1;
            this.tblUserName.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblUserName.Controls.Add(this.lstUserName, 0, 1);
            this.tblUserName.Controls.Add(this.lblUser, 0, 0);
            this.tblUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblUserName.Location = new System.Drawing.Point(1109, 911);
            this.tblUserName.Margin = new System.Windows.Forms.Padding(2);
            this.tblUserName.Name = "tblUserName";
            this.tblUserName.RowCount = 2;
            this.tblUserName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblUserName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblUserName.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tblUserName.Size = new System.Drawing.Size(379, 143);
            this.tblUserName.TabIndex = 21;
            // 
            // lstUserName
            // 
            this.lstUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUserName.FormattingEnabled = true;
            this.lstUserName.Location = new System.Drawing.Point(2, 73);
            this.lstUserName.Margin = new System.Windows.Forms.Padding(2);
            this.lstUserName.Name = "lstUserName";
            this.lstUserName.Size = new System.Drawing.Size(375, 56);
            this.lstUserName.TabIndex = 4;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUser.Location = new System.Drawing.Point(8, 0);
            this.lblUser.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(363, 71);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "User Name:";
            // 
            // tblCuisineType
            // 
            this.tblCuisineType.ColumnCount = 1;
            this.tblCuisineType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCuisineType.Controls.Add(this.lstCuisineType, 0, 1);
            this.tblCuisineType.Controls.Add(this.lblCuisineType, 0, 0);
            this.tblCuisineType.Location = new System.Drawing.Point(727, 911);
            this.tblCuisineType.Margin = new System.Windows.Forms.Padding(2);
            this.tblCuisineType.Name = "tblCuisineType";
            this.tblCuisineType.RowCount = 2;
            this.tblCuisineType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCuisineType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCuisineType.Size = new System.Drawing.Size(375, 142);
            this.tblCuisineType.TabIndex = 22;
            // 
            // lstCuisineType
            // 
            this.lstCuisineType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstCuisineType.FormattingEnabled = true;
            this.lstCuisineType.Location = new System.Drawing.Point(2, 73);
            this.lstCuisineType.Margin = new System.Windows.Forms.Padding(2);
            this.lstCuisineType.Name = "lstCuisineType";
            this.lstCuisineType.Size = new System.Drawing.Size(371, 56);
            this.lstCuisineType.TabIndex = 3;
            // 
            // lblCuisineType
            // 
            this.lblCuisineType.AutoSize = true;
            this.lblCuisineType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCuisineType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCuisineType.Location = new System.Drawing.Point(8, 0);
            this.lblCuisineType.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCuisineType.Name = "lblCuisineType";
            this.lblCuisineType.Size = new System.Drawing.Size(359, 71);
            this.lblCuisineType.TabIndex = 1;
            this.lblCuisineType.Text = "Cuisine Type:";
            // 
            // frmRecipeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 1056);
            this.Controls.Add(this.tblMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRecipeDetail";
            this.Text = "frmRecipeDetail";
            this.tblMain.ResumeLayout(false);
            this.tblRecipeName.ResumeLayout(false);
            this.tblRecipeName.PerformLayout();
            this.tblNumCal.ResumeLayout(false);
            this.tblNumCal.PerformLayout();
            this.tblNumIngredients.ResumeLayout(false);
            this.tblNumIngredients.PerformLayout();
            this.tblNumSteps.ResumeLayout(false);
            this.tblNumSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIngredientList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gStepList)).EndInit();
            this.tblSaveDelete.ResumeLayout(false);
            this.tblDateDrafted.ResumeLayout(false);
            this.tblDateDrafted.PerformLayout();
            this.tblDatePublished.ResumeLayout(false);
            this.tblDatePublished.PerformLayout();
            this.tbleDateArchived.ResumeLayout(false);
            this.tbleDateArchived.PerformLayout();
            this.tblRecipeStatus.ResumeLayout(false);
            this.tblRecipeStatus.PerformLayout();
            this.tblUserName.ResumeLayout(false);
            this.tblUserName.PerformLayout();
            this.tblCuisineType.ResumeLayout(false);
            this.tblCuisineType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView gIngredientList;
        private DataGridView gStepList;
        private TableLayoutPanel tblRecipeName;
        private Label lblRecipeName;
        private TextBox txtRecipeName;
        private TableLayoutPanel tblNumCal;
        private TextBox txtNumCal;
        private Label lblNumberCal;
        private TableLayoutPanel tblNumIngredients;
        private TextBox txtNumIngredients;
        private Label lblNumIngredients;
        private TableLayoutPanel tblNumSteps;
        private TextBox txtNumSteps;
        private Label lblNumSteps;
        private TableLayoutPanel tblSaveDelete;
        private Button btnSave;
        private Button btnDelete;
        private TableLayoutPanel tblDateDrafted;
        private Label lblDateDraftedLabel;
        private Label lblDateDrafted;
        private TableLayoutPanel tblDatePublished;
        private Label lblDatePublishedLabel;
        private Label lblDatePublished;
        private TableLayoutPanel tbleDateArchived;
        private Label lblDateArchivedLabel;
        private Label lblDateArchived;
        private TableLayoutPanel tblRecipeStatus;
        private Label lblRecipeStatusLabel;
        private Label lblRecipeStatus;
        private TableLayoutPanel tblUserName;
        private ComboBox lstUserName;
        private Label lblUser;
        private TableLayoutPanel tblCuisineType;
        private ComboBox lstCuisineType;
        private Label lblCuisineType;
    }
}