using System;
using System.Collections.Generic;
using System.Linq;

namespace Kitchen.Models
{
    public class Dish : Base<Dish>
    {
        public string Name { get; set; }
        public int Cost { get; set; }

        // Словник інгридієнтів у страві
        public List<Ingredient> DishIngredients
        {
            get { return Ingredient.Items.Values.Where(ingredient => ingredient.Dish == this).ToList(); }
        }

        // Словник зв'язків зі стравою
        public List<Connection> Connetions
        {
            get { return Connection.Items.Values.Where(connection => connection.Dish == this).ToList(); }
        }

        // Словник користувачів у страві
        public List<User> Users
        {
            get { return Connection.Items.Values.Where(connection => connection.Dish == this).Select(connection => connection.User).ToList(); }
        }

        // Ініціалізатор властивості для вмісту страв у кухні
        private Guid _kitchenId;

        public KitchenType KitchenType
        {
            get { return KitchenType.Items[_kitchenId]; }
            set { _kitchenId = value.Id; }
        }

        // Ініціалізатор властивості для вмісту страв у прийомах їжі
        private Guid _courseId;

        public CourseType CourseType
        {
            get { return CourseType.Items[_courseId]; }
            set { _courseId = value.Id; }
        }

        // Реалізація трьох статичних методів
        public static bool DefineCheap(Dish dishes)
        {
            if (dishes.Cost < 50) return true;
            return false;
        }

        public static bool DefineMediumCost(Dish dishes)
        {
            if (dishes.Cost >= 50 && dishes.Cost < 100) return true;
            return false;
        }

        public static bool DefineExpensive(Dish dishes)
        {
            if (dishes.Cost >= 100) return true;
            return false;
        }

        public override string ToString()
        {
            return Name + " - " + Cost;
        }

        public override int GetHashCode()
        {
            return Cost;
        }
    }
}
