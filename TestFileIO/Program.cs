using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // write to a file
            //StreamWriter wr = new StreamWriter("Cars.txt", true); // sends a stream of characters to a file

            //wr.WriteLine("Jeep\tCompass\t2015\t30000"); // instead of printing to console prints to file
            //wr.WriteLine("Chevy\tCruze\t2017\t20000");

            //wr.Close();

            //append

            // read from a file

            StreamReader rd = new StreamReader("Cars.txt");

            // string str = rd.ReadToEnd(); // reads the contents of the whole file

            // Console.WriteLine(str);

            List<Car> CarList = new List<Car>();

            string str = rd.ReadLine(); // this will read only one line

            while (str != null) // while we still have more lines to read
            {
                // Console.WriteLine(str); // print the current line
                

                string[] tempCar = str.Split(); //  an array to split the line you just read into four pieces

                CarList.Add(new Car(tempCar[0], tempCar[1], int.Parse(tempCar[2]), double.Parse(tempCar[3]))); // makes a new car to store all information you just read

                str = rd.ReadLine(); // read the next line (fetch a new one)
            }

            foreach (Car Element in CarList)
            {
                Console.WriteLine(Element.ToString());
            }



        }


    }


}
