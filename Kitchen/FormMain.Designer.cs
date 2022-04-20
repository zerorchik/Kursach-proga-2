
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
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.labelUsers = new System.Windows.Forms.Label();
            this.labelChooseUser = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.checkBoxIsAdmin = new System.Windows.Forms.CheckBox();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnRemoveConnection = new System.Windows.Forms.Button();
            this.btnAddConnection = new System.Windows.Forms.Button();
            this.labelZamovlenya = new System.Windows.Forms.Label();
            this.lbZamovlenya = new System.Windows.Forms.ListBox();
            this.lbUserDishes = new System.Windows.Forms.ListBox();
            this.labelUserDishes = new System.Windows.Forms.Label();
            this.btnAllDishes = new System.Windows.Forms.Button();
            this.labelConnectedUser = new System.Windows.Forms.Label();
            this.lbConnectedUser = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelDish
            // 
            this.labelDish.AutoSize = true;
            this.labelDish.Location = new System.Drawing.Point(783, 57);
            this.labelDish.Name = "labelDish";
            this.labelDish.Size = new System.Drawing.Size(49, 15);
            this.labelDish.TabIndex = 1;
            this.labelDish.Text = "Страви:";
            // 
            // labelKitchen
            // 
            this.labelKitchen.AutoSize = true;
            this.labelKitchen.Location = new System.Drawing.Point(608, 57);
            this.labelKitchen.Name = "labelKitchen";
            this.labelKitchen.Size = new System.Drawing.Size(113, 15);
            this.labelKitchen.TabIndex = 3;
            this.labelKitchen.Text = "Кухні народів світу:";
            // 
            // cbKitchen
            // 
            this.cbKitchen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKitchen.FormattingEnabled = true;
            this.cbKitchen.Location = new System.Drawing.Point(608, 96);
            this.cbKitchen.Name = "cbKitchen";
            this.cbKitchen.Size = new System.Drawing.Size(149, 23);
            this.cbKitchen.TabIndex = 2;
            this.cbKitchen.SelectedIndexChanged += new System.EventHandler(this.cbKitchen_SelectedIndexChanged);
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(608, 139);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(69, 15);
            this.labelCourse.TabIndex = 5;
            this.labelCourse.Text = "Тип блюда:";
            // 
            // cbCourse
            // 
            this.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(608, 178);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(149, 23);
            this.cbCourse.TabIndex = 4;
            this.cbCourse.SelectedIndexChanged += new System.EventHandler(this.cbCourse_SelectedIndexChanged);
            // 
            // lbIngredients
            // 
            this.lbIngredients.FormattingEnabled = true;
            this.lbIngredients.ItemHeight = 15;
            this.lbIngredients.Location = new System.Drawing.Point(978, 96);
            this.lbIngredients.Name = "lbIngredients";
            this.lbIngredients.Size = new System.Drawing.Size(223, 289);
            this.lbIngredients.TabIndex = 6;
            this.lbIngredients.SelectedIndexChanged += new System.EventHandler(this.lbIngredients_SelectedIndexChanged);
            // 
            // labelIngredients
            // 
            this.labelIngredients.AutoSize = true;
            this.labelIngredients.Location = new System.Drawing.Point(978, 57);
            this.labelIngredients.Name = "labelIngredients";
            this.labelIngredients.Size = new System.Drawing.Size(72, 15);
            this.labelIngredients.TabIndex = 7;
            this.labelIngredients.Text = "Інгредієнти:";
            // 
            // lbDish
            // 
            this.lbDish.FormattingEnabled = true;
            this.lbDish.ItemHeight = 15;
            this.lbDish.Location = new System.Drawing.Point(783, 96);
            this.lbDish.Name = "lbDish";
            this.lbDish.Size = new System.Drawing.Size(168, 289);
            this.lbDish.TabIndex = 8;
            this.lbDish.SelectedIndexChanged += new System.EventHandler(this.lbDish_SelectedIndexChanged);
            // 
            // btnAddDish
            // 
            this.btnAddDish.Location = new System.Drawing.Point(608, 533);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(343, 23);
            this.btnAddDish.TabIndex = 9;
            this.btnAddDish.Text = "Додати";
            this.btnAddDish.UseVisualStyleBackColor = true;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // tbDishName
            // 
            this.tbDishName.Location = new System.Drawing.Point(783, 435);
            this.tbDishName.Name = "tbDishName";
            this.tbDishName.Size = new System.Drawing.Size(168, 23);
            this.tbDishName.TabIndex = 10;
            // 
            // btnEditDish
            // 
            this.btnEditDish.Location = new System.Drawing.Point(608, 562);
            this.btnEditDish.Name = "btnEditDish";
            this.btnEditDish.Size = new System.Drawing.Size(343, 23);
            this.btnEditDish.TabIndex = 11;
            this.btnEditDish.Text = "Редагувати";
            this.btnEditDish.UseVisualStyleBackColor = true;
            this.btnEditDish.Click += new System.EventHandler(this.btnEditDish_Click);
            // 
            // btnRemoveDish
            // 
            this.btnRemoveDish.Location = new System.Drawing.Point(608, 591);
            this.btnRemoveDish.Name = "btnRemoveDish";
            this.btnRemoveDish.Size = new System.Drawing.Size(343, 23);
            this.btnRemoveDish.TabIndex = 12;
            this.btnRemoveDish.Text = "Видалити";
            this.btnRemoveDish.UseVisualStyleBackColor = true;
            // 
            // tbIngredientName
            // 
            this.tbIngredientName.Location = new System.Drawing.Point(978, 435);
            this.tbIngredientName.Name = "tbIngredientName";
            this.tbIngredientName.Size = new System.Drawing.Size(223, 23);
            this.tbIngredientName.TabIndex = 13;
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(978, 533);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(223, 23);
            this.btnAddIngredient.TabIndex = 14;
            this.btnAddIngredient.Text = "Додати";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // btnEditIngredient
            // 
            this.btnEditIngredient.Location = new System.Drawing.Point(978, 562);
            this.btnEditIngredient.Name = "btnEditIngredient";
            this.btnEditIngredient.Size = new System.Drawing.Size(223, 23);
            this.btnEditIngredient.TabIndex = 15;
            this.btnEditIngredient.Text = "Редагувати";
            this.btnEditIngredient.UseVisualStyleBackColor = true;
            this.btnEditIngredient.Click += new System.EventHandler(this.btnEditIngredient_Click);
            // 
            // btnRemoveIngredient
            // 
            this.btnRemoveIngredient.Location = new System.Drawing.Point(978, 591);
            this.btnRemoveIngredient.Name = "btnRemoveIngredient";
            this.btnRemoveIngredient.Size = new System.Drawing.Size(223, 23);
            this.btnRemoveIngredient.TabIndex = 16;
            this.btnRemoveIngredient.Text = "Видалити";
            this.btnRemoveIngredient.UseVisualStyleBackColor = true;
            // 
            // labelDishChange
            // 
            this.labelDishChange.AutoSize = true;
            this.labelDishChange.Location = new System.Drawing.Point(783, 408);
            this.labelDishChange.Name = "labelDishChange";
            this.labelDishChange.Size = new System.Drawing.Size(122, 15);
            this.labelDishChange.TabIndex = 17;
            this.labelDishChange.Text = "Уведіть назву страви:";
            // 
            // labelIngredientName
            // 
            this.labelIngredientName.AutoSize = true;
            this.labelIngredientName.Location = new System.Drawing.Point(978, 408);
            this.labelIngredientName.Name = "labelIngredientName";
            this.labelIngredientName.Size = new System.Drawing.Size(107, 15);
            this.labelIngredientName.TabIndex = 18;
            this.labelIngredientName.Text = "Уведіть інгредієнт:";
            // 
            // labelIngredientCount
            // 
            this.labelIngredientCount.AutoSize = true;
            this.labelIngredientCount.Location = new System.Drawing.Point(978, 475);
            this.labelIngredientCount.Name = "labelIngredientCount";
            this.labelIngredientCount.Size = new System.Drawing.Size(129, 15);
            this.labelIngredientCount.TabIndex = 20;
            this.labelIngredientCount.Text = "Уведіть його кількість:";
            // 
            // tbIngredientCount
            // 
            this.tbIngredientCount.Location = new System.Drawing.Point(978, 501);
            this.tbIngredientCount.Name = "tbIngredientCount";
            this.tbIngredientCount.Size = new System.Drawing.Size(223, 23);
            this.tbIngredientCount.TabIndex = 19;
            // 
            // labelChooseKitchen
            // 
            this.labelChooseKitchen.AutoSize = true;
            this.labelChooseKitchen.Location = new System.Drawing.Point(608, 408);
            this.labelChooseKitchen.Name = "labelChooseKitchen";
            this.labelChooseKitchen.Size = new System.Drawing.Size(91, 15);
            this.labelChooseKitchen.TabIndex = 22;
            this.labelChooseKitchen.Text = "Оберіть кухню:";
            // 
            // cbDishKitchen
            // 
            this.cbDishKitchen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDishKitchen.FormattingEnabled = true;
            this.cbDishKitchen.Location = new System.Drawing.Point(608, 435);
            this.cbDishKitchen.Name = "cbDishKitchen";
            this.cbDishKitchen.Size = new System.Drawing.Size(149, 23);
            this.cbDishKitchen.TabIndex = 23;
            // 
            // cbDishCourse
            // 
            this.cbDishCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDishCourse.FormattingEnabled = true;
            this.cbDishCourse.Location = new System.Drawing.Point(608, 501);
            this.cbDishCourse.Name = "cbDishCourse";
            this.cbDishCourse.Size = new System.Drawing.Size(149, 23);
            this.cbDishCourse.TabIndex = 25;
            // 
            // labelChooseCourse
            // 
            this.labelChooseCourse.AutoSize = true;
            this.labelChooseCourse.Location = new System.Drawing.Point(608, 474);
            this.labelChooseCourse.Name = "labelChooseCourse";
            this.labelChooseCourse.Size = new System.Drawing.Size(114, 15);
            this.labelChooseCourse.TabIndex = 24;
            this.labelChooseCourse.Text = "Оберіть тип блюда:";
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 15;
            this.lbUsers.Location = new System.Drawing.Point(25, 96);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(168, 289);
            this.lbUsers.TabIndex = 26;
            this.lbUsers.SelectedIndexChanged += new System.EventHandler(this.lbUsers_SelectedIndexChanged);
            // 
            // labelUsers
            // 
            this.labelUsers.AutoSize = true;
            this.labelUsers.Location = new System.Drawing.Point(25, 57);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(52, 15);
            this.labelUsers.TabIndex = 27;
            this.labelUsers.Text = "Клієнти:";
            // 
            // labelChooseUser
            // 
            this.labelChooseUser.AutoSize = true;
            this.labelChooseUser.Location = new System.Drawing.Point(25, 408);
            this.labelChooseUser.Name = "labelChooseUser";
            this.labelChooseUser.Size = new System.Drawing.Size(92, 15);
            this.labelChooseUser.TabIndex = 29;
            this.labelChooseUser.Text = "Уведіть клієнта:";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(25, 435);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(168, 23);
            this.tbUserName.TabIndex = 28;
            // 
            // checkBoxIsAdmin
            // 
            this.checkBoxIsAdmin.AutoSize = true;
            this.checkBoxIsAdmin.Location = new System.Drawing.Point(26, 469);
            this.checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            this.checkBoxIsAdmin.Size = new System.Drawing.Size(57, 19);
            this.checkBoxIsAdmin.TabIndex = 30;
            this.checkBoxIsAdmin.Text = "адмін";
            this.checkBoxIsAdmin.UseVisualStyleBackColor = true;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(26, 591);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(167, 23);
            this.btnRemoveUser.TabIndex = 33;
            this.btnRemoveUser.Text = "Видалити";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(26, 562);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(167, 23);
            this.btnEditUser.TabIndex = 32;
            this.btnEditUser.Text = "Редагувати";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(26, 533);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(167, 23);
            this.btnAddUser.TabIndex = 31;
            this.btnAddUser.Text = "Додати";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnRemoveConnection
            // 
            this.btnRemoveConnection.Location = new System.Drawing.Point(218, 465);
            this.btnRemoveConnection.Name = "btnRemoveConnection";
            this.btnRemoveConnection.Size = new System.Drawing.Size(168, 23);
            this.btnRemoveConnection.TabIndex = 35;
            this.btnRemoveConnection.Text = "Вилучити з замовлення";
            this.btnRemoveConnection.UseVisualStyleBackColor = true;
            // 
            // btnAddConnection
            // 
            this.btnAddConnection.Location = new System.Drawing.Point(218, 436);
            this.btnAddConnection.Name = "btnAddConnection";
            this.btnAddConnection.Size = new System.Drawing.Size(168, 23);
            this.btnAddConnection.TabIndex = 34;
            this.btnAddConnection.Text = "Замовити";
            this.btnAddConnection.UseVisualStyleBackColor = true;
            // 
            // labelZamovlenya
            // 
            this.labelZamovlenya.AutoSize = true;
            this.labelZamovlenya.Location = new System.Drawing.Point(1229, 57);
            this.labelZamovlenya.Name = "labelZamovlenya";
            this.labelZamovlenya.Size = new System.Drawing.Size(78, 15);
            this.labelZamovlenya.TabIndex = 37;
            this.labelZamovlenya.Text = "Замовлення:";
            // 
            // lbZamovlenya
            // 
            this.lbZamovlenya.FormattingEnabled = true;
            this.lbZamovlenya.ItemHeight = 15;
            this.lbZamovlenya.Location = new System.Drawing.Point(1229, 96);
            this.lbZamovlenya.Name = "lbZamovlenya";
            this.lbZamovlenya.Size = new System.Drawing.Size(360, 289);
            this.lbZamovlenya.TabIndex = 36;
            // 
            // lbUserDishes
            // 
            this.lbUserDishes.FormattingEnabled = true;
            this.lbUserDishes.ItemHeight = 15;
            this.lbUserDishes.Location = new System.Drawing.Point(218, 96);
            this.lbUserDishes.Name = "lbUserDishes";
            this.lbUserDishes.Size = new System.Drawing.Size(168, 289);
            this.lbUserDishes.TabIndex = 39;
            // 
            // labelUserDishes
            // 
            this.labelUserDishes.AutoSize = true;
            this.labelUserDishes.Location = new System.Drawing.Point(218, 57);
            this.labelUserDishes.Name = "labelUserDishes";
            this.labelUserDishes.Size = new System.Drawing.Size(89, 15);
            this.labelUserDishes.TabIndex = 38;
            this.labelUserDishes.Text = "Обрані страви:";
            // 
            // btnAllDishes
            // 
            this.btnAllDishes.Location = new System.Drawing.Point(608, 229);
            this.btnAllDishes.Name = "btnAllDishes";
            this.btnAllDishes.Size = new System.Drawing.Size(149, 23);
            this.btnAllDishes.TabIndex = 40;
            this.btnAllDishes.Text = "Усі страви";
            this.btnAllDishes.UseVisualStyleBackColor = true;
            this.btnAllDishes.Click += new System.EventHandler(this.btnAllDishes_Click);
            // 
            // labelConnectedUser
            // 
            this.labelConnectedUser.AutoSize = true;
            this.labelConnectedUser.Location = new System.Drawing.Point(412, 57);
            this.labelConnectedUser.Name = "labelConnectedUser";
            this.labelConnectedUser.Size = new System.Drawing.Size(152, 15);
            this.labelConnectedUser.TabIndex = 42;
            this.labelConnectedUser.Text = "Прив\'язані до них клієнти:";
            // 
            // lbConnectedUser
            // 
            this.lbConnectedUser.FormattingEnabled = true;
            this.lbConnectedUser.ItemHeight = 15;
            this.lbConnectedUser.Location = new System.Drawing.Point(412, 96);
            this.lbConnectedUser.Name = "lbConnectedUser";
            this.lbConnectedUser.Size = new System.Drawing.Size(168, 289);
            this.lbConnectedUser.TabIndex = 41;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 643);
            this.Controls.Add(this.labelConnectedUser);
            this.Controls.Add(this.lbConnectedUser);
            this.Controls.Add(this.btnAllDishes);
            this.Controls.Add(this.lbUserDishes);
            this.Controls.Add(this.labelUserDishes);
            this.Controls.Add(this.labelZamovlenya);
            this.Controls.Add(this.lbZamovlenya);
            this.Controls.Add(this.btnRemoveConnection);
            this.Controls.Add(this.btnAddConnection);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.checkBoxIsAdmin);
            this.Controls.Add(this.labelChooseUser);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.lbUsers);
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
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Label labelChooseUser;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.CheckBox checkBoxIsAdmin;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnRemoveConnection;
        private System.Windows.Forms.Button btnAddConnection;
        private System.Windows.Forms.Label labelZamovlenya;
        private System.Windows.Forms.ListBox lbZamovlenya;
        private System.Windows.Forms.ListBox lbUserDishes;
        private System.Windows.Forms.Label labelUserDishes;
        private System.Windows.Forms.Button btnAllDishes;
        private System.Windows.Forms.Label labelConnectedUser;
        private System.Windows.Forms.ListBox lbConnectedUser;
    }
}

