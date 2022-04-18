using System;
using System.Collections.Generic;

namespace Kitchen.Models
{
    public class Base<T> where T : Base<T>
    {
        public static Dictionary<Guid, T> Ingredients = new Dictionary<Guid, T>();

        public Guid Id { get; private set; }

        public Base()
        {
            Id = Guid.NewGuid();
            Ingredients.Add(Id, (T)this);
        }
    }
}
