using Kitchen.Models;
using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Kitchen
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var user1 = new User() { Name = "Сашко", IsAdmin = true };
            var user2 = new User() { Name = "Микола", IsAdmin = false };

            var kitchen1 = new KitchenType() { Name = "Українська кухня" };
            var kitchen2 = new KitchenType() { Name = "Азійська кухня" };
            var kitchen3 = new KitchenType() { Name = "Європейська кухня" };
            var kitchen4 = new KitchenType() { Name = "Американська кухня" };

            var course1 = new CourseType() { Name = "Перша страва" };
            var course2 = new CourseType() { Name = "Основна страва" };
            var course3 = new CourseType() { Name = "Салат" };
            var course4 = new CourseType() { Name = "Десерт" };
            var course5 = new CourseType() { Name = "Напій" };

            var myDish1 = new Dish() { Name = "Борщ", KitchenType = kitchen1, CourseType = course1, Cost = 85 };
            var product1 = new Ingredient() { Name = "буряк", Count = "2 штуки", Dish = myDish1 };
            var product2 = new Ingredient() { Name = "морква", Count = "1 штука", Dish = myDish1 };
            var product3 = new Ingredient() { Name = "цибуля", Count = "3 штуки", Dish = myDish1 };
            var product4 = new Ingredient() { Name = "томатна паста", Count = "2 ст. ложки", Dish = myDish1 };
            var product5 = new Ingredient() { Name = "соняшникова олія", Count = "4-5 ст. ложок", Dish = myDish1 };
            var product6 = new Ingredient() { Name = "лимонна кислота", Count = "дрібка", Dish = myDish1 };

            var myDish2 = new Dish() { Name = "Рамен", KitchenType = kitchen2, CourseType = course2, Cost = 120 };
            var product7 = new Ingredient() { Name = "локшина", Count = "700 г", Dish = myDish2 };
            var product8 = new Ingredient() { Name = "свинина", Count = "1 кг", Dish = myDish2 };
            var product9 = new Ingredient() { Name = "жир", Count = "30 г", Dish = myDish2 };
            var product10 = new Ingredient() { Name = "зелень", Count = "пучок", Dish = myDish2 };
            var product11 = new Ingredient() { Name = "соєвий соус", Count = "200 г", Dish = myDish2 };
            var product12 = new Ingredient() { Name = "імбир", Count = "30 г", Dish = myDish2 };

            var myDish3 = new Dish() { Name = "Вареники з картоплею", KitchenType = kitchen1, CourseType = course2, Cost = 55 };
            var product13 = new Ingredient() { Name = "борошно", Count = "400 г", Dish = myDish3 };
            var product14 = new Ingredient() { Name = "вода", Count = "200 г", Dish = myDish3 };
            var product15 = new Ingredient() { Name = "олія", Count = "3 ст. ложки", Dish = myDish3 };
            var product16 = new Ingredient() { Name = "сіль", Count = "0.5 ч. ложки", Dish = myDish3 };
            var product17 = new Ingredient() { Name = "картопля", Count = "800 г", Dish = myDish3 };
            var product18 = new Ingredient() { Name = "цибуля", Count = "1 шт", Dish = myDish3 };

            var myDish4 = new Dish() { Name = "Цезар", KitchenType = kitchen3, CourseType = course3, Cost = 45 };
            var product19 = new Ingredient() { Name = "соус \"Цезар\"", Count = "100 мл", Dish = myDish4 };
            var product20 = new Ingredient() { Name = "помідор чері", Count = "100 г", Dish = myDish4 };
            var product21 = new Ingredient() { Name = "твердий пармезан", Count = "1 ч. ложка", Dish = myDish4 };
            var product22 = new Ingredient() { Name = "рослинна олія", Count = "1 ч. ложка", Dish = myDish4 };
            var product23 = new Ingredient() { Name = "салат-латук", Count = "10 г", Dish = myDish4 };
            var product24 = new Ingredient() { Name = "яйце пашот", Count = "2 шт", Dish = myDish4 };
            var product25 = new Ingredient() { Name = "обсмажена куряча грудка", Count = "половина", Dish = myDish4 };
            var product26 = new Ingredient() { Name = "грінки з фокачі", Count = "100 г", Dish = myDish4 };

            var myDish5 = new Dish() { Name = "Кола", KitchenType = kitchen4, CourseType = course5, Cost = 20 };
            var product27 = new Ingredient() { Name = "газована вода", Count = "1 л", Dish = myDish5 };
            var product28 = new Ingredient() { Name = "лимон", Count = "1 шт", Dish = myDish5 };
            var product29 = new Ingredient() { Name = "лайм", Count = "1 шт", Dish = myDish5 };
            var product30 = new Ingredient() { Name = "апельсин", Count = "2 шт", Dish = myDish5 };
            var product31 = new Ingredient() { Name = "цукор", Count = "300 г", Dish = myDish5 };
            var product32 = new Ingredient() { Name = "кава", Count = "2 ст. ложки", Dish = myDish5 };
            var product33 = new Ingredient() { Name = "мускатний горіх", Count = "0.25 ч. ложки", Dish = myDish5 };
            var product34 = new Ingredient() { Name = "кориця", Count = "3 палички", Dish = myDish5 };
            var product35 = new Ingredient() { Name = "коріандр в зернах", Count = "1 ч. ложка", Dish = myDish5 };
            var product36 = new Ingredient() { Name = "ванільна есенція", Count = "0.5 ч. ложки", Dish = myDish5 };

            var myDish6 = new Dish() { Name = "Мотті", KitchenType = kitchen2, CourseType = course4, Cost = 35 };
            var product37 = new Ingredient() { Name = "цукрова пудра", Count = "100 г", Dish = myDish6 };
            var product38 = new Ingredient() { Name = "рисове борошно", Count = "50 г", Dish = myDish6 };
            var product39 = new Ingredient() { Name = "вода", Count = "150 мл", Dish = myDish6 };
            var product40 = new Ingredient() { Name = "барвник", Count = "на кінчику ножа", Dish = myDish6 };
            var product41 = new Ingredient() { Name = "кукурудзяе борошно", Count = "100 г", Dish = myDish6 };

            cbKitchen.DataSource = KitchenType.Items.Values.ToList();
            cbCourse.DataSource = CourseType.Items.Values.ToList();
            cbDishKitchen.DataSource = KitchenType.Items.Values.ToList();
            cbDishCourse.DataSource = CourseType.Items.Values.ToList();
            RefreshUsers();
            RefreshDishes();
        }

        private void btnAllDishes_Click(object sender, EventArgs e)
        {
            RefreshDishes();
        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUsers.SelectedItem != null)
            {
                // Записуємо у параметри користувача
                tbUserName.Text = ((User)lbUsers.SelectedItem).Name;
                checkBoxIsAdmin.Checked = ((User)lbUsers.SelectedItem).IsAdmin ? true : false;
                // Відображаємо страви користувача
                RefreshConnectedDishes();
                RefreshTotalCost();
                AdminChecking(((User)lbUsers.SelectedItem).IsAdmin);
            }
        }

        private void AdminChecking(bool decigion)
        {
            btnEditUser.Enabled = decigion;
            cbDishKitchen.Enabled = cbDishCourse.Enabled = tbDishName.Enabled = tbDishCost.Enabled = btnAddDish.Enabled = btnEditDish.Enabled = btnRemoveDish.Enabled = decigion;
            tbIngredientName.Enabled = tbIngredientCount.Enabled = btnAddIngredient.Enabled = btnEditIngredient.Enabled = btnRemoveIngredient.Enabled = decigion;
        }

        private void lbDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbDish.SelectedItem != null)
            {
                // Записуємо у текстбокси параметри страви
                tbDishName.Text = ((Dish)lbDish.SelectedItem).Name;
                cbDishKitchen.Text = ((Dish)lbDish.SelectedItem).KitchenType.Name;
                cbDishCourse.Text = ((Dish)lbDish.SelectedItem).CourseType.Name;
                tbDishCost.Text = ((Dish)lbDish.SelectedItem).Cost.ToString();
                // Відображаємо інгридієнти страви
                RefreshIngredients();
                // Відображаємо клієнтів, що замовили страву
                RefreshConnectedUsers();
            }
        }

        private void lbIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbIngredients.SelectedItem != null)
            {
                tbIngredientName.Text = ((Ingredient)lbIngredients.SelectedItem).Name;
                tbIngredientCount.Text = ((Ingredient)lbIngredients.SelectedItem).Count;
            }
        }

        private void cbKitchen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKitchen.SelectedItem != null)
            {
                lbDish.DataSource = null;
                lbDish.DataSource = ((KitchenType)cbKitchen.SelectedItem).KitchenDishes;
            }
        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCourse.SelectedItem != null)
            {
                lbDish.DataSource = null;
                lbDish.DataSource = ((CourseType)cbCourse.SelectedItem).CourseDishes;
            }
        }

        private void RefreshUsers()
        {
            lbUsers.DataSource = null;
            lbUsers.DataSource = User.Items.Values.ToList();
        }

        private void RefreshDishes()
        {
            lbDish.DataSource = null;
            lbDish.DataSource = Dish.Items.Values.ToList();
        }

        private void RefreshIngredients()
        {
            lbIngredients.DataSource = null;
            lbIngredients.DataSource = ((Dish)lbDish.SelectedItem).DishIngredients;
        }

        private void RefreshConnectedDishes()
        {
            if(lbUsers.SelectedItem != null)
            {
                lbUserDishes.DataSource = null;
                lbUserDishes.DataSource = ((User)lbUsers.SelectedItem).Dishes;
            }
        }

        private void RefreshConnectedUsers()
        {
            lbConnectedUser.DataSource = null;
            lbConnectedUser.DataSource = ((Dish)lbDish.SelectedItem).Users;
        }

        private void btnEditDish_Click(object sender, EventArgs e)
        {
            KitchenType kitchen;
            CourseType course;
            VarsForDish(out kitchen, out course);
            ((Dish)lbDish.SelectedItem).Name = tbDishName.Text;
            ((Dish)lbDish.SelectedItem).Cost = Convert.ToInt32(tbDishCost.Text);
            ((Dish)lbDish.SelectedItem).KitchenType = kitchen;
            ((Dish)lbDish.SelectedItem).CourseType = course;
            RefreshDishes();
        }

        private void btnEditIngredient_Click(object sender, EventArgs e)
        {
            ((Ingredient)lbIngredients.SelectedItem).Name = tbIngredientName.Text;
            ((Ingredient)lbIngredients.SelectedItem).Count = tbIngredientCount.Text;
            RefreshIngredients();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            ((User)lbUsers.SelectedItem).Name = tbUserName.Text;
            ((User)lbUsers.SelectedItem).IsAdmin = checkBoxIsAdmin.Checked;
            RefreshUsers();
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            KitchenType kitchen;
            CourseType course;
            VarsForDish(out kitchen, out course);
            new Dish() { Name = tbDishName.Text, KitchenType = kitchen, CourseType = course, Cost = Convert.ToInt32(tbDishCost.Text) };
            RefreshDishes();
        }

        private void VarsForDish(out KitchenType kitchen, out CourseType course)
        {
            kitchen = (KitchenType)cbDishKitchen.SelectedItem;
            course = (CourseType)cbDishCourse.SelectedItem;
        }

        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            var dish = (Dish)lbDish.SelectedItem;
            new Ingredient() { Name = tbIngredientName.Text, Count = tbIngredientCount.Text, Dish = dish };
            RefreshIngredients();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            new User() { Name = tbUserName.Text, IsAdmin = checkBoxIsAdmin.Checked };
            RefreshUsers();
        }


        private void btnAddConnection_Click(object sender, EventArgs e)
        {
            new Connection() { User = (User)lbUsers.SelectedItem, Dish = (Dish)lbDish.SelectedItem };
            RefreshConnectedDishes();
            RefreshConnectedUsers();
            RefreshTotalCost();
        }

        private void btnRemoveIngredient_Click(object sender, EventArgs e)
        {
            var dish = lbDish.SelectedItem;
            var ingredientToDel = Ingredient.Items.Values.Where(connection => connection.Dish == dish).FirstOrDefault();
            if (ingredientToDel != null)
            {
                Ingredient.Items.Remove(ingredientToDel.Id);
                RefreshIngredients();
            }
        }

        private void btnRemoveDish_Click(object sender, EventArgs e)
        {
            if(lbDish.SelectedItem != null)
            {
                if (lbUserDishes.Items.Contains(lbDish.SelectedItem))
                    MessageBox.Show("Ви не можете видалити страву, яка вже замовлена!");
                else
                {
                    int count = lbIngredients.Items.Count;
                    for (int i = 0; i < count; i++)
                        btnRemoveIngredient_Click(sender, e);
                    Dish.Items.Remove(((Dish)lbDish.SelectedItem).Id);
                    RefreshDishes();
                }
            }
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedItem != null)
            {
                int count = lbUserDishes.Items.Count;
                for (int i = 0; i < count; i++)
                {
                    var dish = lbUserDishes.SelectedItem;
                    RemoveConnections(dish);
                }
                User.Items.Remove(((User)lbUsers.SelectedItem).Id);
                RefreshUsers();
                RefreshConnectedDishes();
            }
        }

        private void btnRemoveConnection_Click(object sender, EventArgs e)
        {
            var dish = lbDish.SelectedItem;
            RemoveConnections(dish);
        }

        private void RemoveConnections(object dishes)
        {
            var user = lbUsers.SelectedItem;
            var dish = dishes;
            var connetionToDel = Connection.Items.Values.Where(connection => connection.Dish == dish && connection.User == user).FirstOrDefault();
            if (connetionToDel != null)
                Connection.Items.Remove(connetionToDel.Id);
            RefreshConnectedDishes();
            RefreshConnectedUsers();
            RefreshTotalCost();
        }

        private void RefreshTotalCost()
        {
            int cost = 0;
            foreach (var dishes in lbUserDishes.Items) cost += dishes.GetHashCode();
            labelTotalCost.Text = Convert.ToString(cost) + " грн";
        }
    }
}
