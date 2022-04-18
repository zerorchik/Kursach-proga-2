using Kitchen.Models;
using System;
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
            var myDish1 = new Dish() { Name = "Борщ", Course = "Перша страва", Kitchen = "Українська" };
            var product1 = new Ingredient() { Name = "буряк", Count = "2 штуки", Dish = myDish1 };
            var product2 = new Ingredient() { Name = "морква", Count = "1 штука", Dish = myDish1 };
            var product3 = new Ingredient() { Name = "цибуля", Count = "3 штуки", Dish = myDish1 };
            var product4 = new Ingredient() { Name = "томатна паста", Count = "2 ст. ложки", Dish = myDish1 };
            var product5 = new Ingredient() { Name = "соняшникова олія", Count = "4-5 ст. ложок", Dish = myDish1 };
            var product6 = new Ingredient() { Name = "лимонна кислота", Count = "дрібка", Dish = myDish1 };

            var myDish2 = new Dish() { Name = "Рамен", Course = "Основна страва", Kitchen = "Азійська" };
            var product7 = new Ingredient() { Name = "локшина", Count = "700 г", Dish = myDish2 };
            var product8 = new Ingredient() { Name = "свинина", Count = "1 кг", Dish = myDish2 };
            var product9 = new Ingredient() { Name = "жир", Count = "30 г", Dish = myDish2 };
            var product10 = new Ingredient() { Name = "зелень", Count = "пучок", Dish = myDish2 };
            var product11 = new Ingredient() { Name = "соєвий соус", Count = "200 г", Dish = myDish2 };
            var product12 = new Ingredient() { Name = "імбир", Count = "30 г", Dish = myDish2 };

            var myDish3 = new Dish() { Name = "Вареники з картоплею", Course = "Основна страва", Kitchen = "Українська" };
            var product13 = new Ingredient() { Name = "борошно", Count = "400 г", Dish = myDish3 };
            var product14 = new Ingredient() { Name = "вода", Count = "200 г", Dish = myDish3 };
            var product15 = new Ingredient() { Name = "олія", Count = "3 ст. ложки", Dish = myDish3 };
            var product16 = new Ingredient() { Name = "сіль", Count = "0.5 ч. ложки", Dish = myDish3 };
            var product17 = new Ingredient() { Name = "картопля", Count = "800 г", Dish = myDish3 };
            var product18 = new Ingredient() { Name = "цибуля", Count = "1 шт", Dish = myDish3 };

            var myDish4 = new Dish() { Name = "Цезар", Course = "Салат", Kitchen = "Європейська" };
            var product19 = new Ingredient() { Name = "соус \"Цезар\"", Count = "100 мл", Dish = myDish4 };
            var product20 = new Ingredient() { Name = "помідор чері", Count = "100 г", Dish = myDish4 };
            var product21 = new Ingredient() { Name = "твердий пармезан", Count = "1 ч. ложка", Dish = myDish4 };
            var product22 = new Ingredient() { Name = "рослинна олія", Count = "1 ч. ложка", Dish = myDish4 };
            var product23 = new Ingredient() { Name = "салат-латук", Count = "10 г", Dish = myDish4 };
            var product24 = new Ingredient() { Name = "яйце пашот", Count = "2 шт", Dish = myDish4 };
            var product25 = new Ingredient() { Name = "обсмажена куряча грудка", Count = "половина", Dish = myDish4 };
            var product26 = new Ingredient() { Name = "грінки з фокачі", Count = "100 г", Dish = myDish4 };

            var myDish5 = new Dish() { Name = "Кола", Course = "Напій", Kitchen = "Американська" };
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

            var myDish6 = new Dish() { Name = "Мотті", Course = "Десерт", Kitchen = "Азійська" };
            var product37 = new Ingredient() { Name = "цукрова пудра", Count = "100 г", Dish = myDish6 };
            var product38 = new Ingredient() { Name = "рисове борошно", Count = "50 г", Dish = myDish6 };
            var product39 = new Ingredient() { Name = "вода", Count = "150 мл", Dish = myDish6 };
            var product40 = new Ingredient() { Name = "барвник", Count = "на кінчику ножа", Dish = myDish6 };
            var product41 = new Ingredient() { Name = "кукурудзяе борошно", Count = "100 г", Dish = myDish6 };            
        }
    }
}
