
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
            this.SuspendLayout();
            // 
            // labelDish
            // 
            this.labelDish.AutoSize = true;
            this.labelDish.Location = new System.Drawing.Point(376, 72);
            this.labelDish.Name = "labelDish";
            this.labelDish.Size = new System.Drawing.Size(49, 15);
            this.labelDish.TabIndex = 1;
            this.labelDish.Text = "Страви:";
            // 
            // labelKitchen
            // 
            this.labelKitchen.AutoSize = true;
            this.labelKitchen.Location = new System.Drawing.Point(24, 72);
            this.labelKitchen.Name = "labelKitchen";
            this.labelKitchen.Size = new System.Drawing.Size(113, 15);
            this.labelKitchen.TabIndex = 3;
            this.labelKitchen.Text = "Кухні народів світу:";
            // 
            // cbKitchen
            // 
            this.cbKitchen.FormattingEnabled = true;
            this.cbKitchen.Location = new System.Drawing.Point(190, 111);
            this.cbKitchen.Name = "cbKitchen";
            this.cbKitchen.Size = new System.Drawing.Size(149, 23);
            this.cbKitchen.TabIndex = 2;
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(190, 72);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(69, 15);
            this.labelCourse.TabIndex = 5;
            this.labelCourse.Text = "Тип блюда:";
            // 
            // cbCourse
            // 
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(24, 111);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(121, 23);
            this.cbCourse.TabIndex = 4;
            // 
            // lbIngredients
            // 
            this.lbIngredients.FormattingEnabled = true;
            this.lbIngredients.ItemHeight = 15;
            this.lbIngredients.Location = new System.Drawing.Point(536, 111);
            this.lbIngredients.Name = "lbIngredients";
            this.lbIngredients.Size = new System.Drawing.Size(120, 94);
            this.lbIngredients.TabIndex = 6;
            // 
            // labelIngredients
            // 
            this.labelIngredients.AutoSize = true;
            this.labelIngredients.Location = new System.Drawing.Point(536, 72);
            this.labelIngredients.Name = "labelIngredients";
            this.labelIngredients.Size = new System.Drawing.Size(72, 15);
            this.labelIngredients.TabIndex = 7;
            this.labelIngredients.Text = "Інгредієнти:";
            // 
            // lbDish
            // 
            this.lbDish.FormattingEnabled = true;
            this.lbDish.ItemHeight = 15;
            this.lbDish.Location = new System.Drawing.Point(376, 111);
            this.lbDish.Name = "lbDish";
            this.lbDish.Size = new System.Drawing.Size(120, 94);
            this.lbDish.TabIndex = 8;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

