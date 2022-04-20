using System.Collections.Generic;
using System.Linq;

namespace Kitchen.Models
{
    public class User : Base<User>
    {
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
    }
}
