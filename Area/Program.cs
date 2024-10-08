using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;//imports libraries
using System.Xml.Serialization;

namespace Area//names program and allows for classes
{
    class Program//names the class of the program
    {
        private static object area;//names the object

        static void Main(string[] args)//entrypoint. the main function
        {
            string userChoice;
            float length;
            float width;
            float rectangleArea;
            float radius;
            float circleArea;
            float height;
            float baseOfTriangle;
            float triangleArea;
            float cubeArea;
            float side;

            Console.WriteLine("Please enter your choice");
            Console.WriteLine("Choices are:-");
            Console.WriteLine("rectangle, circle, triangle, cube");
            userChoice = Console.ReadLine();

            if (userChoice == "rectangle") 
            {
                Console.WriteLine("Enter the length in cms");
                length = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the width in cms");
                width = float.Parse(Console.ReadLine());
                rectangleArea = length * width;
                Console.WriteLine("The area of the rectangle is " + rectangleArea + " square units");
            }
            else if (userChoice == "circle") 
            {
                Console.WriteLine("Enter the radius in cms");
                radius = float.Parse(Console.ReadLine());
                circleArea = (float)(3.14 * radius * radius);
                Console.WriteLine("The area of the circle is " + circleArea + " units");
            }
            else if (userChoice == "triangle")
            {
                Console.WriteLine("Enter the height in cms");
                height = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the base in cms");
                baseOfTriangle = float.Parse(Console.ReadLine());
                triangleArea = (float)(0.5 * height * baseOfTriangle);
                Console.WriteLine("The area of the circle is " + triangleArea + " units");
            }
            else if (userChoice == "cube")
            {
                Console.WriteLine("Enter the side in cms");
                side = float.Parse(Console.ReadLine());
                cubeArea = (float)(6 * side * side);
                Console.WriteLine("The area of the cube is " + cubeArea + " units");
            }
            else
            {
                Console.WriteLine("Invalid option chosen");
            }
            Console.ReadLine();
        }
    }
}
