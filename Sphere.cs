using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphere
{
    class Sphere
    {
        private int cordX;
        private int cordY;
        private int cordZ;
        private double radius;
        private double volume;
        private double surfaceArea;

        public int CordX
        {
            get
            {
                return cordX;
            }
            set
            {
                cordX = value;
            }
        }

        public int CordY
        {
            get
            {
                return cordY;
            }
            set
            {
                cordY = value;
            }
        }

        public int CordZ
        {
            get
            {
                return cordZ;
            }
            set
            {
                cordZ = value;
            }
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public double Volume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
            }
        }

        public double SurfaceArea
        {
            get
            {
                return surfaceArea;
            }
            set
            {
                surfaceArea = value;
            }
        }

        public void setCordX()
        {
            Console.Write("\nWhat is the x coordinate? ");
            CordX = Convert.ToInt32(Console.ReadLine());
        }

        public int getCordX()
        {
            return CordX;
        }

        public void setCordY()
        {
            Console.Write("\nWhat is the y coordinate? ");
            CordY = Convert.ToInt32(Console.ReadLine());
        }

        public int getCordY()
        {
            return CordY;
        }

        public void setCordZ()
        {
            Console.Write("\nWhat is the z coordinate? ");
            CordZ = Convert.ToInt32(Console.ReadLine());
        }

        public int getCordZ()
        {
            return CordZ;
        }

        public void setVolume()
        {
            Volume = 4 / 3 * 3.14 * (radius * radius * radius);
        }
        public double getVolume()
        {
            return Volume;
        }

        public void setRadius()
        {
            Console.Write("\nWhat is the radius? ");
            Radius = Convert.ToDouble(Console.ReadLine());
        }

        public double getRadius()
        {
            return Radius;
        }

        public void setSurfaceArea()
        {
            SurfaceArea = 4 * 3.14 * (Radius * Radius);
        }

        public double getSurfaceArea()
        {
            return SurfaceArea;
        }

        public void setCords()
        {
            setCordX();
            setCordY();
            setCordZ();
        } 

        public void printInfo()
        {
            Console.WriteLine("\nThe x coordinate is " +
                getCordX());

            Console.WriteLine("\nThe y coordinate is " +
                getCordY());

            Console.WriteLine("\nThe z coordinate is " +
                getCordZ());

            Console.WriteLine("\nThe radius is " + 
                getRadius());

            Console.WriteLine("\nThe surface area is " +
                getSurfaceArea());
        }

        public void setInfo()
        {
            setCords();
            setRadius();
            setSurfaceArea();
        }

        public void run()
        {
            string choice;

            Console.WriteLine("\nNAME: VINCENT CHUI" +
                "\nDATE: 2015/10/26" +
                "\nLAB: 1" +
                "\nCOURSE: CIS 23" +
                "\nSEMIMESTER: FALL 2015");

            do {
                Console.Write("\nSet" +
                    "\nQuit" +
                    "\nEnter: ");

                choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "set":
                        setInfo();
                        printInfo();
                        break;
                    case "quit":
                        Console.WriteLine("\nQUITTING");
                        break;
                    default:
                        Console.WriteLine("\nINVALID INPUT");
                        break;
                }
            } while (choice != "quit");
        } 
    }
}
/*OUTPUT

NAME: VINCENT CHUI
DATE: 2015/10/26
LAB: 1
COURSE: CIS 23
SEMIMESTER: FALL 2015

Set
Quit
Enter: set

What is the x coordinate? 1

What is the y coordinate? 2

What is the z coordinate? 3

What is the radius? 4

The x coordinate is 1

The y coordinate is 2

The z coordinate is 3

The radius is 4

The surface area is 200.96

Set
Quit
Enter: quit

QUITTING
Press any key to continue . . .
*/