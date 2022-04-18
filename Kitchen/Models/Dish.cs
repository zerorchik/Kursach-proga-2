using System.Collections.Generic;
using System.Linq;

namespace Kitchen.Models
{
    public class Dish : Base<Dish>
    {
        public string Name { get; set; }
        public string Kitchen { get; set; }
        public string Course { get; set; }

        // Словник інгридієнтів у страві
        public List<Ingredient> DishIngredients
        {
            get
            {
                //List<Ingredient> result = new List<Ingredient>();
                //foreach (var item in Ingredient.Items.Values)
                //    if (item.Dish == this)
                //        result.Add(item);
                //return result;

                return Ingredient.Ingredients.Values.Where(li => li.Dish == this).ToList();
            }
        }

        public override string ToString()
        {
            return Name;
        }

        // Конструктор класа
        public Dish(string name, string kitchen, string course)
        {
            Name = name;
            Kitchen = kitchen;
            Course = course;
        }
    }
}
