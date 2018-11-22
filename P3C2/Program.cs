using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3C2
{
    class Program
    {
        static void Main(string[] args)
        {
            var theCourseIsExcellent = true;
            var theAuthorIsHumble = false;

            bool iAmABoolean;

            iAmABoolean = true;
            if (iAmABoolean == true)
            { }

            //var a = 2 == 2;
            //Console.WriteLine(a); // -> true

            var a = 2;
            var b = 3;
            Console.WriteLine(a < b); // -> true

            //bool isCustomPhotoAvailable()
            //{
            //    return true;
            //}

            //if (isCustomPhotoAvailable())
            //{
            //    // display custom photo
            //}

            //if (!isCustomPhotoAvailable())
            //{
            //    // display placeholer
            //}

            if (true)
            {
                Console.WriteLine("I'm executed");
            }
            else
            {
                Console.WriteLine("I'm ignored");
            }

            bool isCustomPhotoAvailable()
            {
                return true;
            }

            if (isCustomPhotoAvailable())
            {
                // display custom photo
            }
            else
            {
                // display placeholer
            }

            if (true)
            {
                Console.WriteLine("I am executed"); // will be printed
            }

            if (false)
            {
                Console.WriteLine("I'am ignored"); // will NOT be printed
            }
            const Direction direction = Direction.north;

            switch (direction)
            {
                case Direction.north:
                    Console.WriteLine("You are heading north");
                    break;
                case Direction.east:
                    Console.WriteLine("You are heading east");
                    break;
                case Direction.south:
                    Console.WriteLine("You are heading south");
                    break;
                case Direction.west:
                    Console.WriteLine("You are heading west");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }
        enum Direction
        {
            north, east, south, west
        }
    }
}
