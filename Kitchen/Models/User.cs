using System.Collections.Generic;
using System.Linq;

namespace Kitchen.Models
{
    public class User : Base<User>
    {
        public string Name { get; set; }
        public bool IsAdmin { get; set; }

        // Словник зв'язків з користувачем
        public List<Connection> Connetions
        {
            get { return Connection.Items.Values.Where(connection => connection.User == this).ToList(); }
        }

        // Словник страв у користувачі
        public List<Dish> Dishes
        {
            get { return Connection.Items.Values.Where(connection => connection.User == this).Select(connection => connection.Dish).ToList(); }
        }

        public override string ToString()
        {
            return Name + (IsAdmin? " (адмін)":"");
        }
    }
}
