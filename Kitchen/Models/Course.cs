﻿namespace Kitchen.Models
{
    public class Course : Base
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}