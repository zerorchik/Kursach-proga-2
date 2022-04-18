using System.Collections.Generic;
using System.Linq;

namespace Kitchen.Models
{
    public class KitchenType : Base<KitchenType>
    {
        public string Name { get; set; }

        // Словник страв у кухні
        public List<Dish> KitchenDishes
        {
            get { return Dish.Items.Values.Where(li => li.KitchenType == this).ToList(); }
        }

        public override string ToString()
        {
            return Name + " кухня";
        }

        //// Конструктор класа
        //public KitchenType(string name)
        //{
        //    Name = name;
        //}
    }

}
