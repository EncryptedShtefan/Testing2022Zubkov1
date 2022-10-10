namespace Testing2022Zubkov1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Deti!");

            int x1, y1, x2, y2, x3, y3, x4, y4, x5, y5, x6, y6; //короче это координаты наших точек
           
            

            ////
            Console.WriteLine("Enter X of first dot of first triangle");
            string x11 = Console.ReadLine();
            x1 = int.Parse(x11);
            
            Console.WriteLine("Enter Y of first dot of first triangle");
            string y11 = Console.ReadLine();
            y1 = int.Parse(y11);

            Console.WriteLine("Enter X of second dot of first triangle");
            string x22 = Console.ReadLine();
            x2 = int.Parse(x22);

            Console.WriteLine("Enter Y of second dot of first triangle");
            string y22 = Console.ReadLine();
            y2 = int.Parse(y22);

            Console.WriteLine("Enter X of third dot of first triangle");
            string x33 = Console.ReadLine();
            x3 = int.Parse(x33);

            Console.WriteLine("Enter Y third dot of first triangle");
            string y33 = Console.ReadLine();
            y3 = int.Parse(y33);

            Console.WriteLine("Enter X of first dot of second triangle");
            string x44 = Console.ReadLine();
            x4 = int.Parse(x44);    

            Console.WriteLine("Enter Y of first dot of second triangle");
            string y44 = Console.ReadLine();
            y4 = int.Parse(y44);

            Console.WriteLine("Enter X of second dot of second triangle");
            string x55 = Console.ReadLine();
            x5 = int.Parse(x55);

            Console.WriteLine("Enter Y of second dot of second triangle");
            string y55 = Console.ReadLine();
            y5 = int.Parse(y55);

            Console.WriteLine("Enter X of third dot of second triangle");
            string x66 = Console.ReadLine();
            x6 = int.Parse(x66);

            Console.WriteLine("Enter Y of third dot of second triangle");
            string y66 = Console.ReadLine();
            y6 = int.Parse(y66);
            ////
            ////
            double l11, l12, l13, l21, l22, l23; //стороны треугольников

            l11 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));//формулы нахождения сторон треуголников по коордам точек
            l12 = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            l13 = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));

            l21 = Math.Sqrt((x5 - x4) * (x5 - x4) + (y5 - y4) * (y5 - y4));
            l22 = Math.Sqrt((x6 - x4) * (x6 - x4) + (y6 - y4) * (y6 - y4));
            l23 = Math.Sqrt((x6 - x5) * (x6 - x5) + (y6 - y5) * (y6 - y5));
            ////
            ////
            double P1, P2; //периметры

            P1 = l11 + l12 + l13;
            P2 = l21 + l22 + l23;
            ////
            ////
            double S1, S2; //площади
            double P1h = P1 / 2; //полупериметр1
            double P2h = P2 / 2; //полупериметр2

            S1 = Math.Sqrt(P1h*(P1h-l11)*(P1h-l12)*(P1h-l13)); //Формула Герона (считает с погрешностью ~0.0000000009, поэтому костыли в виде приведение к int и 0.1 внизу)
            Console.WriteLine($"Площадь первого треугольника равна: {S1}");

            S2 = Math.Sqrt(P2h * (P2h - l21) * (P2h - l22) * (P2h - l23)); //Формула Герона
            Console.WriteLine($"Площадь второго треугольника равна: {S2}");
            ////
            ////
            Console.WriteLine("\nХммм... входит ли один в другой? ... Ща проверим! Сделаем это, поделив треугольник на три части точками другого трижды и высчитав площади этих частей и их сумму\n");
            double s1, s2, s3, ss1, ss2, ss3, Ph, l31, l32, l33;
            if (S1 > S2)
            {
                l31 = Math.Sqrt((x1 - x4) * (x1 - x4) + (y1 - y4) * (y1 - y4));
                l32 = Math.Sqrt((x2 - x4) * (x2 - x4) + (y2 - y4) * (y2 - y4));
                Ph = (l11 + l31 + l32) / 2;
                s1 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l11)) + 0.1;

                l31 = Math.Sqrt((x1 - x4) * (x1 - x4) + (y1 - y4) * (y1 - y4));
                l32 = Math.Sqrt((x3 - x4) * (x3 - x4) + (y3 - y4) * (y3 - y4));
                Ph = (l12 + l31 + l32) / 2;
                s2 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l12)) + 0.1;

                l31 = Math.Sqrt((x2 - x4) * (x2 - x4) + (y2 - y4) * (y2 - y4));
                l32 = Math.Sqrt((x3 - x4) * (x3 - x4) + (y3 - y4) * (y3 - y4));
                Ph = (l13 + l31 + l32) / 2;
                s3 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l13)) + 0.1;

                ss1 = (int)s1 + (int)s2 + (int)s3; 

                l31 = Math.Sqrt((x1 - x5) * (x1 - x5) + (y1 - y5) * (y1 - y5));
                l32 = Math.Sqrt((x2 - x5) * (x2 - x5) + (y2 - y5) * (y2 - y5));
                Ph = (l11 + l31 + l32) / 2;
                s1 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l11)) + 0.1;

                l31 = Math.Sqrt((x1 - x5) * (x1 - x5) + (y1 - y5) * (y1 - y5));
                l32 = Math.Sqrt((x3 - x5) * (x3 - x5) + (y3 - y5) * (y3 - y5));
                Ph = (l12 + l31 + l32) / 2;
                s2 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l12)) + 0.1;

                l31 = Math.Sqrt((x2 - x5) * (x2 - x5) + (y2 - y5) * (y2 - y5));
                l32 = Math.Sqrt((x3 - x5) * (x3 - x5) + (y3 - y5) * (y3 - y5));
                Ph = (l13 + l31 + l32) / 2;
                s3 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l13)) + 0.1;

                ss2 = (int)s1 + (int)s2 + (int)s3;

                l31 = Math.Sqrt((x1 - x6) * (x1 - x6) + (y1 - y6) * (y1 - y6));
                l32 = Math.Sqrt((x2 - x6) * (x2 - x6) + (y2 - y6) * (y2 - y6));
                Ph = (l11 + l31 + l32) / 2;
                s1 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l11)) + 0.1;

                l31 = Math.Sqrt((x1 - x6) * (x1 - x6) + (y1 - y6) * (y1 - y6));
                l32 = Math.Sqrt((x3 - x6) * (x3 - x6) + (y3 - y6) * (y3 - y6));
                Ph = (l12 + l31 + l32) / 2;
                s2 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l12)) + 0.1;

                l31 = Math.Sqrt((x2 - x6) * (x2 - x6) + (y2 - y6) * (y2 - y6));
                l32 = Math.Sqrt((x3 - x6) * (x3 - x6) + (y3 - y6) * (y3 - y6));
                Ph = (l13 + l31 + l32) / 2;
                s3 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l13)) + 0.1;

                ss3 = (int)s1 + (int)s2 + (int)s3;

                Console.WriteLine($"Площадь первой части = {ss1}\t, Площадь второй = {ss2}\t, Площадь третьей = {ss3}\n");

                if (ss1 == ss2 & ss1 == ss3 & ss2 == ss3)
                {
                    Console.WriteLine("Они равны, значит второй треугольник внутри первого!");
                }
                else Console.WriteLine("Ни один треугольник не входит полностью в другой");
            }
            else if (S2 > S1)
            {
                l31 = Math.Sqrt((x4 - x1) * (x4 - x1) + (y4 - y1) * (y4 - y1));
                l32 = Math.Sqrt((x5 - x1) * (x5 - x1) + (y5 - y1) * (y5 - y1));
                Ph = (l21 + l31 + l32) / 2;
                s1 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l21)) + 0.1;

                l31 = Math.Sqrt((x4 - x1) * (x4 - x1) + (y4 - y1) * (y4 - y1));
                l32 = Math.Sqrt((x6 - x1) * (x6 - x1) + (y6 - y1) * (y6 - y1));
                Ph = (l22 + l31 + l32) / 2;
                s2 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l22)) + 0.1;

                l31 = Math.Sqrt((x5 - x1) * (x5 - x1) + (y5 - y1) * (y5 - y1));
                l32 = Math.Sqrt((x6 - x1) * (x6 - x1) + (y6 - y1) * (y6 - y1));
                Ph = (l23 + l31 + l32) / 2;
                s3 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l23)) + 0.1;

                ss1 = (int)s1 + (int)s2 + (int)s3;

                l31 = Math.Sqrt((x4 - x2) * (x4 - x2) + (y4 - y2) * (y4 - y2));
                l32 = Math.Sqrt((x5 - x2) * (x5 - x2) + (y5 - y2) * (y5 - y2));
                Ph = (l21 + l31 + l32) / 2;
                s1 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l21)) + 0.1;

                l31 = Math.Sqrt((x4 - x2) * (x4 - x2) + (y4 - y2) * (y4 - y2));
                l32 = Math.Sqrt((x6 - x2) * (x6 - x2) + (y6 - y2) * (y6 - y2));
                Ph = (l22 + l31 + l32) / 2;
                s2 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l22)) + 0.1;

                l31 = Math.Sqrt((x5 - x2) * (x5 - x2) + (y5 - y2) * (y5 - y2));
                l32 = Math.Sqrt((x6 - x2) * (x6 - x2) + (y6 - y2) * (y6 - y2));
                Ph = (l23 + l31 + l32) / 2;
                s3 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l23)) + 0.1;

                ss2 = (int)s1 + (int)s2 + (int)s3;

                l31 = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
                l32 = Math.Sqrt((x5 - x3) * (x5 - x3) + (y5 - y3) * (y5 - y3));
                Ph = (l21 + l31 + l32) / 2;
                s1 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l21)) + 0.1;

                l31 = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
                l32 = Math.Sqrt((x6 - x3) * (x6 - x3) + (y6 - y3) * (y6 - y3));
                Ph = (l22 + l31 + l32) / 2;
                s2 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l22)) + 0.1;

                l31 = Math.Sqrt((x5 - x3) * (x5 - x3) + (y5 - y3) * (y5 - y3));
                l32 = Math.Sqrt((x6 - x3) * (x6 - x3) + (y6 - y3) * (y6 - y3));
                Ph = (l23 + l31 + l32) / 2;
                s3 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l23)) + 0.1;

                ss3 = (int)s1 + (int)s2 + (int)s3;

                Console.WriteLine($"Площадь первой части = {ss1}\t, Площадь второй = {ss2}\t, Площадь третьей = {ss3}\n");

                if (ss1 == ss2 & ss1 == ss3 & ss2 == ss3)
                {
                    Console.WriteLine("Площади равны, значит первый треугольник внутри второго!");
                }
                else Console.WriteLine("Ни один треугольник не входит полностью в другой");
            }
            else Console.WriteLine("треугольники равны!");
        }

        //функции ниже нужно заполнить блоками сверху, назначив соответствующие параметры и ретурны, я ща спать хачу, ни магу уже ничего ааааа как же долго я разбирался в этом изиче
        double Lines()
        {

            return 0;
        }

        double Perimetr()
        {

            return 0;
        }
        double Area()
        {

            return 0;
        }

    }
}