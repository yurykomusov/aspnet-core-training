using System;

namespace aspnet_core_training 
{
    public class HomeController
    {
        public string Index(string name, int age) => $"I am {name}. I am {age} years old.";

        public int Square(int number) => number * number;
    }
}
