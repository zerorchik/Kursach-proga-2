using System;
using System.Collections.Generic;

namespace Kitchen.Models
{
    public class Base
    {
        public static Dictionary<Guid, Base> Ingredients = new Dictionary<Guid, Base>();

        public Guid Id { get; private set; }

        public Base()
        {
            Id = Guid.NewGuid();
            Ingredients.Add(Id, this);
        }
    }
}
