
namespace Kitchen
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDish = new System.Windows.Forms.Label();
            this.labelKitchen = new System.Windows.Forms.Label();
            this.cbKitchen = new System.Windows.Forms.ComboBox();
            this.labelCourse = new System.Windows.Forms.Label();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.lbIngredients = new System.Windows.Forms.ListBox();
            this.labelIngredients = new System.Windows.Forms.Label();
            this.lbDish = new System.Windows.Forms.ListBox();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.tbDishName = new System.Windows.Forms.TextBox();
            this.btnEditDish = new System.Windows.Forms.Button();
            this.btnRemoveDish = new System.Windows.Forms.Button();
            this.tbIngredientName = new System.Windows.Forms.TextBox();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.btnEditIngredient = new System.Windows.Forms.Button();
            this.btnRemoveIngredient = new System.Windows.Forms.Button();
            this.labelDishChange = new System.Windows.Forms.Label();
            this.labelIngredientName = new System.Windows.Forms.Label();
            this.labelIngredientCount = new System.Windows.Forms.Label();
            this.tbIngredientCount = new System.Windows.Forms.TextBox();
            this.labelChooseKitchen = new System.Windows.Forms.Label();
            this.cbDishKitchen = new System.Windows.Forms.ComboBox();
            this.cbDishCourse = new System.Windows.Forms.ComboBox();
            this.labelChooseCourse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDish
            // 
            this.labelDish.AutoSize = true;
            this.labelDish.Location = new System.Drawing.Point(382, 57);
            this.labelDish.Name = "labelDish";
            this.labelDish.Size = new System.Drawing.Size(49, 15);
            this.labelDish.TabIndex = 1;
            this.labelDish.Text = "Страви:";
            // 
            // labelKitchen
            // 
            this.labelKitchen.AutoSize = true;
            this.labelKitchen.Location = new System.Drawing.Point(30, 57);
            this.labelKitchen.Name = "labelKitchen";
            this.labelKitchen.Size = new System.Drawing.Size(113, 15);
            this.labelKitchen.TabIndex = 3;
            this.labelKitchen.Text = "Кухні народів світу:";
            // 
            // cbKitchen
            // 
            this.cbKitchen.FormattingEnabled = true;
            this.cbKitchen.Location = new System.Drawing.Point(30, 96);
            this.cbKitchen.Name = "cbKitchen";
            this.cbKitchen.Size = new System.Drawing.Size(149, 23);
            this.cbKitchen.TabIndex = 2;
            this.cbKitchen.SelectedIndexChanged += new System.EventHandler(this.cbKitchen_SelectedIndexChanged);
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(207, 57);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(69, 15);
            this.labelCourse.TabIndex = 5;
            this.labelCourse.Text = "Тип блюда:";
            // 
            // cbCourse
            // 
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(207, 96);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(149, 23);
            this.cbCourse.TabIndex = 4;
            this.cbCourse.SelectedIndexChanged += new System.EventHandler(this.cbCourse_SelectedIndexChanged);
            // 
            // lbIngredients
            // 
            this.lbIngredients.FormattingEnabled = true;
            this.lbIngredients.ItemHeight = 15;
            this.lbIngredients.Location = new System.Drawing.Point(577, 96);
            this.lbIngredients.Name = "lbIngredients";
            this.lbIngredients.Size = new System.Drawing.Size(223, 289);
            this.lbIngredients.TabIndex = 6;
            this.lbIngredients.SelectedIndexChanged += new System.EventHandler(this.lbIngredients_SelectedIndexChanged);
            // 
            // labelIngredients
            // 
            this.labelIngredients.AutoSize = true;
            this.labelIngredients.Location = new System.Drawing.Point(577, 57);
            this.labelIngredients.Name = "labelIngredients";
            this.labelIngredients.Size = new System.Drawing.Size(72, 15);
            this.labelIngredients.TabIndex = 7;
            this.labelIngredients.Text = "Інгредієнти:";
            // 
            // lbDish
            // 
            this.lbDish.FormattingEnabled = true;
            this.lbDish.ItemHeight = 15;
            this.lbDish.Location = new System.Drawing.Point(382, 96);
            this.lbDish.Name = "lbDish";
            this.lbDish.Size = new System.Drawing.Size(168, 289);
            this.lbDish.TabIndex = 8;
            this.lbDish.SelectedIndexChanged += new System.EventHandler(this.lbDish_SelectedIndexChanged);
            // 
            // btnAddDish
            // 
            this.btnAddDish.Location = new System.Drawing.Point(30, 475);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(520, 37);
            this.btnAddDish.TabIndex = 9;
            this.btnAddDish.Text = "Додати";
            this.btnAddDish.UseVisualStyleBackColor = true;
            // 
            // tbDishName
            // 
            this.tbDishName.Location = new System.Drawing.Point(382, 435);
            this.tbDishName.Name = "tbDishName";
            this.tbDishName.Size = new System.Drawing.Size(168, 23);
            this.tbDishName.TabIndex = 10;
            // 
            // btnEditDish
            // 
            this.btnEditDish.Location = new System.Drawing.Point(30, 526);
            this.btnEditDish.Name = "btnEditDish";
            this.btnEditDish.Size = new System.Drawing.Size(520, 37);
            this.btnEditDish.TabIndex = 11;
            this.btnEditDish.Text = "Редагувати";
            this.btnEditDish.UseVisualStyleBackColor = true;
            this.btnEditDish.Click += new System.EventHandler(this.btnEditDish_Click);
            // 
            // btnRemoveDish
            // 
            this.btnRemoveDish.Location = new System.Drawing.Point(30, 576);
            this.btnRemoveDish.Name = "btnRemoveDish";
            this.btnRemoveDish.Size = new System.Drawing.Size(520, 38);
            this.btnRemoveDish.TabIndex = 12;
            this.btnRemoveDish.Text = "Видалити";
            this.btnRemoveDish.UseVisualStyleBackColor = true;
            // 
            // tbIngredientName
            // 
            this.tbIngredientName.Location = new System.Drawing.Point(577, 435);
            this.tbIngredientName.Name = "tbIngredientName";
            this.tbIngredientName.Size = new System.Drawing.Size(223, 23);
            this.tbIngredientName.TabIndex = 13;
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(577, 533);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(223, 23);
            this.btnAddIngredient.TabIndex = 14;
            this.btnAddIngredient.Text = "Додати";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // btnEditIngredient
            // 
            this.btnEditIngredient.Location = new System.Drawing.Point(577, 562);
            this.btnEditIngredient.Name = "btnEditIngredient";
            this.btnEditIngredient.Size = new System.Drawing.Size(223, 23);
            this.btnEditIngredient.TabIndex = 15;
            this.btnEditIngredient.Text = "Редагувати";
            this.btnEditIngredient.UseVisualStyleBackColor = true;
            // 
            // btnRemoveIngredient
            // 
            this.btnRemoveIngredient.Location = new System.Drawing.Point(577, 591);
            this.btnRemoveIngredient.Name = "btnRemoveIngredient";
            this.btnRemoveIngredient.Size = new System.Drawing.Size(223, 23);
            this.btnRemoveIngredient.TabIndex = 16;
            this.btnRemoveIngredient.Text = "Видалити";
            this.btnRemoveIngredient.UseVisualStyleBackColor = true;
            // 
            // labelDishChange
            // 
            this.labelDishChange.AutoSize = true;
            this.labelDishChange.Location = new System.Drawing.Point(382, 408);
            this.labelDishChange.Name = "labelDishChange";
            this.labelDishChange.Size = new System.Drawing.Size(88, 15);
            this.labelDishChange.TabIndex = 17;
            this.labelDishChange.Text = "Уведіть страву:";
            // 
            // labelIngredientName
            // 
            this.labelIngredientName.AutoSize = true;
            this.labelIngredientName.Location = new System.Drawing.Point(577, 408);
            this.labelIngredientName.Name = "labelIngredientName";
            this.labelIngredientName.Size = new System.Drawing.Size(107, 15);
            this.labelIngredientName.TabIndex = 18;
            this.labelIngredientName.Text = "Уведіть інгредієнт:";
            // 
            // labelIngredientCount
            // 
            this.labelIngredientCount.AutoSize = true;
            this.labelIngredientCount.Location = new System.Drawing.Point(577, 475);
            this.labelIngredientCount.Name = "labelIngredientCount";
            this.labelIngredientCount.Size = new System.Drawing.Size(129, 15);
            this.labelIngredientCount.TabIndex = 20;
            this.labelIngredientCount.Text = "Уведіть його кількість:";
            // 
            // tbIngredientCount
            // 
            this.tbIngredientCount.Location = new System.Drawing.Point(577, 501);
            this.tbIngredientCount.Name = "tbIngredientCount";
            this.tbIngredientCount.Size = new System.Drawing.Size(223, 23);
            this.tbIngredientCount.TabIndex = 19;
            // 
            // labelChooseKitchen
            // 
            this.labelChooseKitchen.AutoSize = true;
            this.labelChooseKitchen.Location = new System.Drawing.Point(30, 408);
            this.labelChooseKitchen.Name = "labelChooseKitchen";
            this.labelChooseKitchen.Size = new System.Drawing.Size(91, 15);
            this.labelChooseKitchen.TabIndex = 22;
            this.labelChooseKitchen.Text = "Оберіть кухню:";
            // 
            // cbDishKitchen
            // 
            this.cbDishKitchen.FormattingEnabled = true;
            this.cbDishKitchen.Location = new System.Drawing.Point(30, 435);
            this.cbDishKitchen.Name = "cbDishKitchen";
            this.cbDishKitchen.Size = new System.Drawing.Size(149, 23);
            this.cbDishKitchen.TabIndex = 23;
            // 
            // cbDishCourse
            // 
            this.cbDishCourse.FormattingEnabled = true;
            this.cbDishCourse.Location = new System.Drawing.Point(207, 435);
            this.cbDishCourse.Name = "cbDishCourse";
            this.cbDishCourse.Size = new System.Drawing.Size(149, 23);
            this.cbDishCourse.TabIndex = 25;
            // 
            // labelChooseCourse
            // 
            this.labelChooseCourse.AutoSize = true;
            this.labelChooseCourse.Location = new System.Drawing.Point(207, 408);
            this.labelChooseCourse.Name = "labelChooseCourse";
            this.labelChooseCourse.Size = new System.Drawing.Size(114, 15);
            this.labelChooseCourse.TabIndex = 24;
            this.labelChooseCourse.Text = "Оберіть тип блюда:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 653);
            this.Controls.Add(this.cbDishCourse);
            this.Controls.Add(this.labelChooseCourse);
            this.Controls.Add(this.cbDishKitchen);
            this.Controls.Add(this.labelChooseKitchen);
            this.Controls.Add(this.labelIngredientCount);
            this.Controls.Add(this.tbIngredientCount);
            this.Controls.Add(this.labelIngredientName);
            this.Controls.Add(this.labelDishChange);
            this.Controls.Add(this.btnRemoveIngredient);
            this.Controls.Add(this.btnEditIngredient);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.tbIngredientName);
            this.Controls.Add(this.btnRemoveDish);
            this.Controls.Add(this.btnEditDish);
            this.Controls.Add(this.tbDishName);
            this.Controls.Add(this.btnAddDish);
            this.Controls.Add(this.lbDish);
            this.Controls.Add(this.labelIngredients);
            this.Controls.Add(this.lbIngredients);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.labelKitchen);
            this.Controls.Add(this.cbKitchen);
            this.Controls.Add(this.labelDish);
            this.Name = "FormMain";
            this.Text = "Recepies";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDish;
        private System.Windows.Forms.Label labelKitchen;
        private System.Windows.Forms.ComboBox cbKitchen;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.ListBox lbIngredients;
        private System.Windows.Forms.Label labelIngredients;
        private System.Windows.Forms.ListBox lbDish;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.TextBox tbDishName;
        private System.Windows.Forms.Button btnEditDish;
        private System.Windows.Forms.Button btnRemoveDish;
        private System.Windows.Forms.TextBox tbIngredientName;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.Button btnEditIngredient;
        private System.Windows.Forms.Button btnRemoveIngredient;
        private System.Windows.Forms.Label labelDishChange;
        private System.Windows.Forms.Label labelIngredientName;
        private System.Windows.Forms.Label labelIngredientCount;
        private System.Windows.Forms.TextBox tbIngredientCount;
        private System.Windows.Forms.Label labelChooseKitchen;
        private System.Windows.Forms.ComboBox cbDishKitchen;
        private System.Windows.Forms.ComboBox cbDishCourse;
        private System.Windows.Forms.Label labelChooseCourse;
    }
}

