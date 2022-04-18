using System;

namespace Kitchen.Models
{
    public class Ingredient : Base
    {
        public string Name { get; set; }
        public string Count { get; set; }

        private Guid _dishId;

        public Dish Dish
        {
            get { return (Dish)Ingredients[_dishId]; }
            set { _dishId = value.Id; }
        }

        public override string ToString()
        {
            return Name + " (" + Count + ")";
        }
    }
}
