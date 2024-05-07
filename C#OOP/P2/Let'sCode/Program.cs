using System.Net.Http.Headers;
using System.Text;
namespace Let_sCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Frist Project [Point]
            /* 
               1.3
                int X = 0, Y = 0, Z = 0;

                do
                {
                    Console.WriteLine("Enter Point X: ");

                } while (!int.TryParse(Console.ReadLine(), out X));

                try
                {

                    Console.WriteLine("Enter Point Y: ");
                    Y = int.Parse(Console.ReadLine());

                }
                catch (Exception ex) { }

                try
                {
                    Console.WriteLine("Enter Point Z: ");
                    Z = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex) { }

                //1.4
                /Point P1 = new Point(X, Y, Z);
                Point P2 = new Point(1, 2, 3);
                //Doesn't Work Even Points are The Same Because == compare Identity[GetHashCode()] not Values 
                //Console.WriteLine(P1==P2);

                //1.5
                //Point[] points = { new Point(1, 2, 3), new Point(4, 5, 6), new Point() ,new Point(1,2,0)};
                //Array.Sort(points);
                //foreach (Point p in points)
                //{
                //    Console.WriteLine(p);
                //}

                //1.6
                //Point P3 = new Point(4, 5, 6);
                //Point P4=(Point) P3.Clone();
                //Console.WriteLine(P4);
                */
            #endregion

            #region Second Project [Duration]
            Duration D01 = new Duration(1, 10, 15);
            Console.WriteLine(D01.ToString());
            Duration D02 = new Duration(3600);
            Console.WriteLine(D02.ToString());
            Duration D03 = new Duration(7800);
            Console.WriteLine(D03.ToString());
            Duration D04 = new Duration(666);
            Console.WriteLine(D04.ToString());


            D03 = D01 + D02;
            Console.WriteLine(D03.ToString());
            D03 = D01 + 7800;
            Console.WriteLine(D03.ToString());
            D03 = 666 + D03;
            Console.WriteLine(D03.ToString());
            D03 = ++D01;
            Console.WriteLine(D03.ToString());
            D03 = --D02;
            Console.WriteLine(D03.ToString());
            D01 = D01 - D02;
            Console.WriteLine(D01.ToString());
            if (D01 > D02)
            {
                Console.WriteLine("Bigger");
            }
            else
            {
                Console.WriteLine("Smaller");
            }
            if (D01 <= D02)
            {
                Console.WriteLine("Less Than Or Equal");
            }
            else
            {
                Console.WriteLine("Grater Than");
            }
            if (D01)
            {
                Console.WriteLine("Bigger Than Zero Time");
            }
            else
            {
                Console.WriteLine("Zero Time");
            }
            
            DateTime obj = (DateTime)D01;
            Console.WriteLine(obj);
            #endregion
        }
    }
}