using System;
using System.Collections.Generic;
using System.Linq;

namespace Kitchen.Models
{
    public class Dish : Base<Dish>
    {
        public string Name { get; set; }
        public string Kitchen { get { return KitchenType.Name; } set { } }
        public string Course { get { return CourseType.Name; } set { } }

        // Словник інгридієнтів у страві
        public List<Ingredient> DishIngredients
        {
            get { return Ingredient.Items.Values.Where(li => li.Dish == this).ToList(); }
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

        public override string ToString()
        {
            return Name;
        }

        //// Конструктор класа
        //public Dish(string name, KitchenType kitchen, CourseType course)
        //{
        //    Name = name;
        //    Kitchen = kitchen;
        //    Course = course;
        //}
    }
}
