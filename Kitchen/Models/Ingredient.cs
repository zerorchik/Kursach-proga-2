using System;

namespace Kitchen.Models
{
    public class Ingredient : Base<Ingredient>
    {
        public string Name { get; set; }
        public string Count { get; set; }

        // Ініціалізатор властивості для вмісту інгредієнтів у страві
        private Guid _dishId;

        public Dish Dish
        {
            get { return Dish.Items[_dishId]; }
            set { _dishId = value.Id; }
        }

        public override string ToString()
        {
            return "* " + Name + " - " + Count;
        }
    }
}
