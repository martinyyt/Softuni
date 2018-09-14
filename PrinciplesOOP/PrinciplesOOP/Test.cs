using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Test
{
    public class Cat
    {
        //Field name
        private string name;
        //Field color
        private string color;

        public string Name
        {
            // Getter of the property "Name" 
            get
            {
                return this.name;
            }
            // Setter of the property "Name" 
            set
            {
                this.name = value;
            }
        }

        public string Color
        {
            // Getter of the property "Color" 
            get
            {
                return this.color;
            }
            // Setter of the property "Color" 
            set
            {
                if (this.color == "black")
                {
                    this.color = "dirty";
                }
                else
                {
                    this.color = value;
                }
            }
        }

        // Default constructor 
        public Cat()
        {
            this.name = null;
            this.color = null;
        }

        // Constructor with parameters 
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        

        // Method SayMeow 
        public void SayMeow()
        {
            Console.WriteLine("Cat {0} said: Meooow!", name);
        }
    }

     class Test
    {
        static public int a;
        static void Main1(string[] args)
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Tony";
            firstCat.SayMeow();
            
            Cat secondCat = new Cat("Pepy", "black");
            secondCat.Color = "black";
            secondCat.SayMeow();
            Console.WriteLine("Cat {0} is {1}.",
              secondCat.Name, secondCat.Color);
        }
    }
}
