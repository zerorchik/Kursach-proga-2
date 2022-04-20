using System;

namespace Kitchen.Models
{
    public class Connection : Base<Connection>
    {
        // Ініціалізатор властивості для вмісту страв у користувачі
        private Guid _userId;

        public User User
        {
            get { return User.Items[_userId]; }
            set { _userId = value.Id; }
        }

        // Ініціалізатор властивості для вмісту користувачів у страві
        private Guid _dishId;
        public Dish Dish
        {
            get { return Dish.Items[_dishId]; }
            set { _dishId = value.Id; }
        }
    }
}
