using System.Collections.Generic;
using System.Linq;

namespace Kitchen.Models
{
    public class CourseType : Base<CourseType>
    {
        public string Name { get; set; }

        // Словник страв у прийомах їжі
        public List<Dish> CourseDishes
        {
            get { return Dish.Items.Values.Where(li => li.CourseType == this).ToList(); }
        }

        public override string ToString()
        {
            return Name;
        }

        //// Конструктор класа
        //public CourseType(string name)
        //{
        //    Name = name;
        //}
    }
}