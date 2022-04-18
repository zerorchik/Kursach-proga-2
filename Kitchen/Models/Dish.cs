using System.Collections.Generic;

namespace Kitchen.Models
{
    public class Dish : Base
    {
        public string Name { get; set; }
        public string Kitchen { get; set; }
        public string Course { get; set; }

        public List<Ingredient> Ingredients
        {
            get
            {
                List<Ingredient> result = new List<Ingredient>();
                foreach (var item in Base.Ingredients.Values)
                {
                    if (item is Ingredient && ((Ingredient)item).Dish == this)
                        result.Add((Ingredient)item);
                }
                return result;
            }
        }

        public override string ToString()
        {
            return Name;
        }

        //public List<Ingredient> Ingredients
        //{
        //    get
        //    {
        //        List<Ingredient> result = new List<Ingredient>();
        //        foreach (var item in ) 
        //    }
        //}

        //public Dish(string name, string kitchen, string course)
        //{
        //    Name = name;
        //    Kitchen = kitchen;
        //    Course = course;
        //}
    }
}
