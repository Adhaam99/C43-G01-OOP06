namespace Asignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region First Project

            ///*
            // * 3. Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).
            // */

            //Point P1 , P2;

            //int x = 0, y = 0, z = 0;

            //bool flag01, flag02, flag03;

            //do
            //{
            //    Console.Write("Enter P1.x : ");

            //    flag01 = int.TryParse( Console.ReadLine() , out x);

            //    Console.Write("Enter P1.y : ");

            //    string str = Console.ReadLine() ?? "" ;

            //    if (str == "")
            //    {
            //        flag02 = false;
                    
            //    }
            //    else
            //    {
            //        flag02 = true;
            //        y = int.Parse(str);
            //    }


            //    Console.Write("Enter P1.z : ");

            //    str = Console.ReadLine() ?? "";

            //    if (str == "")
            //    {
            //        flag03 = false;

            //    }
            //    else
            //    {
            //        flag03 = true;
            //        z = Convert.ToInt32(str);
            //    }


            //}while (!flag01 && !flag02 && !flag03);

            //P1 = new Point(x, y, z);

            //Console.WriteLine("=================================");

            //do
            //{
            //    Console.Write("Enter P2.x : ");

            //    flag01 = int.TryParse(Console.ReadLine(), out x);

            //    Console.Write("Enter P2.y : ");

            //    string str = Console.ReadLine() ?? "";

            //    if (str == "")
            //    {
            //        flag02 = false;

            //    }
            //    else
            //    {
            //        flag02 = true;
            //        y = int.Parse(str);
            //    }


            //    Console.Write("Enter P2.z : ");

            //    str = Console.ReadLine() ?? "";

            //    if (str == "")
            //    {
            //        flag03 = false;

            //    }
            //    else
            //    {
            //        flag03 = true;
            //        z = Convert.ToInt32(str);
            //    }


            //} while (!flag01 && !flag02 && !flag03);

            //P2 = new Point(x, y, z);

            //Console.Clear();

            //Console.WriteLine($"For P1 {P1}");

            //Console.WriteLine($"For P2 {P2}");

            ///*
            // * 4. Try to use ==
            // * If (P1 == P2) Does it work properly?
            // */

            //if (P1 == P2)
            //{
            //    Console.WriteLine("P1 Equals P2");
            //}
            //else
            //{
            //    Console.WriteLine("P1 Not Equals P2");
            //}

            //// == dosen't work properly because it's not comparing points by its coordinates.

            ///*
            // * 5. Define an array of points and sort this array based on X & Y coordinates.
            // */

            //Point[] points = { P1, P2 , new Point(4 , 5 , 6) };
            
            //for (int i = 0; i < points.Length; i++)
            //{
            //    for (int j = i +1 ;  j < points.Length; j++)
            //    {
            //        if (points[i].X >  points[j].X && points[i].Y > points[j].Y)
            //            (points[i] , points[j]) = (points[j] , points[i]);
            //    }
            //}
            
            //for (int i = 0; i < points.Length;i++)
            //{
            //    Console.WriteLine($"Point Num {i + 1} : {points[i]}");
            //}

            /*
             * 6. Implement ICloneable interface to be able to clone the object.
             */

            //Point point01 = new Point(12, 14, 16);
            //Point point02 = new Point() { X = 10 , Y = 20 , Z = 30};

            //Console.WriteLine("Before Clone");

            //Console.WriteLine($"point01 : {point01}");
            //Console.WriteLine($"point02 : {point02}");
            //Console.WriteLine($"point01 : {point01.GetHashCode()}");
            //Console.WriteLine($"point02 : {point02.GetHashCode()}");

            //point02 = point01;

            //Console.WriteLine("After Clone");

            //Console.WriteLine($"point01 : {point01}");
            //Console.WriteLine($"point02 : {point02}");
            //Console.WriteLine($"point01 : {point01.GetHashCode()}");
            //Console.WriteLine($"point02 : {point02.GetHashCode()}");


            #endregion
        }
    }
}
