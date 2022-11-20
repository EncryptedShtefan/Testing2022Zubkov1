//namespace Testing2022Zubkov1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, Deti!");

//            int x1, y1, x2, y2, x3, y3, x4, y4, x5, y5, x6, y6; //короче это координаты наших точек



//            ////
//            Console.WriteLine("Enter X of first dot of first triangle");
//            string x11 = Console.ReadLine();
//            x1 = int.Parse(x11);

//            Console.WriteLine("Enter Y of first dot of first triangle");
//            string y11 = Console.ReadLine();
//            y1 = int.Parse(y11);

//            Console.WriteLine("Enter X of second dot of first triangle");
//            string x22 = Console.ReadLine();
//            x2 = int.Parse(x22);

//            Console.WriteLine("Enter Y of second dot of first triangle");
//            string y22 = Console.ReadLine();
//            y2 = int.Parse(y22);

//            Console.WriteLine("Enter X of third dot of first triangle");
//            string x33 = Console.ReadLine();
//            x3 = int.Parse(x33);

//            Console.WriteLine("Enter Y third dot of first triangle");
//            string y33 = Console.ReadLine();
//            y3 = int.Parse(y33);

//            Console.WriteLine("Enter X of first dot of second triangle");
//            string x44 = Console.ReadLine();
//            x4 = int.Parse(x44);    

//            Console.WriteLine("Enter Y of first dot of second triangle");
//            string y44 = Console.ReadLine();
//            y4 = int.Parse(y44);

//            Console.WriteLine("Enter X of second dot of second triangle");
//            string x55 = Console.ReadLine();
//            x5 = int.Parse(x55);

//            Console.WriteLine("Enter Y of second dot of second triangle");
//            string y55 = Console.ReadLine();
//            y5 = int.Parse(y55);

//            Console.WriteLine("Enter X of third dot of second triangle");
//            string x66 = Console.ReadLine();
//            x6 = int.Parse(x66);

//            Console.WriteLine("Enter Y of third dot of second triangle");
//            string y66 = Console.ReadLine();
//            y6 = int.Parse(y66);
//            ////
//            ////
//            double l11, l12, l13, l21, l22, l23; //стороны треугольников

//            l11 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));//формулы нахождения сторон треуголников по коордам точек
//            l12 = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
//            l13 = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));

//            l21 = Math.Sqrt((x5 - x4) * (x5 - x4) + (y5 - y4) * (y5 - y4));
//            l22 = Math.Sqrt((x6 - x4) * (x6 - x4) + (y6 - y4) * (y6 - y4));
//            l23 = Math.Sqrt((x6 - x5) * (x6 - x5) + (y6 - y5) * (y6 - y5));
//            ////
//            ////
//            double P1, P2; //периметры

//            P1 = l11 + l12 + l13;
//            P2 = l21 + l22 + l23;
//            ////
//            ////
//            double S1, S2; //площади
//            double P1h = P1 / 2; //полупериметр1
//            double P2h = P2 / 2; //полупериметр2

//            S1 = Math.Sqrt(P1h*(P1h-l11)*(P1h-l12)*(P1h-l13)); //Формула Герона (считает с погрешностью ~0.0000000009)
//            Console.Clear();
//            Console.WriteLine($"Площадь первого треугольника равна: {S1}");

//            S2 = Math.Sqrt(P2h * (P2h - l21) * (P2h - l22) * (P2h - l23)); //Формула Герона
//            Console.WriteLine($"Площадь второго треугольника равна: {S2}");
//            ////
//            ////
//            Console.WriteLine("\nХммм... входит ли один в другой? ... Ща проверим! Сделаем это, поделив треугольник на три части точками другого трижды и высчитав площади этих частей и их сумму\n");
//            double s1, s2, s3, ss1, ss2, ss3, Ph, l31, l32, l33;
//            if (S1 > S2)
//            {
//                l31 = Math.Sqrt((x1 - x4) * (x1 - x4) + (y1 - y4) * (y1 - y4));
//                l32 = Math.Sqrt((x2 - x4) * (x2 - x4) + (y2 - y4) * (y2 - y4));
//                Ph = (l11 + l31 + l32) / 2;
//                s1 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l11));

//                l31 = Math.Sqrt((x1 - x4) * (x1 - x4) + (y1 - y4) * (y1 - y4));
//                l32 = Math.Sqrt((x3 - x4) * (x3 - x4) + (y3 - y4) * (y3 - y4));
//                Ph = (l12 + l31 + l32) / 2;
//                s2 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l12));

//                l31 = Math.Sqrt((x2 - x4) * (x2 - x4) + (y2 - y4) * (y2 - y4));
//                l32 = Math.Sqrt((x3 - x4) * (x3 - x4) + (y3 - y4) * (y3 - y4));
//                Ph = (l13 + l31 + l32) / 2;
//                s3 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l13));

//                ss1 = s1 + s2 + s3; 

//                l31 = Math.Sqrt((x1 - x5) * (x1 - x5) + (y1 - y5) * (y1 - y5));
//                l32 = Math.Sqrt((x2 - x5) * (x2 - x5) + (y2 - y5) * (y2 - y5));
//                Ph = (l11 + l31 + l32) / 2;
//                s1 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l11));

//                l31 = Math.Sqrt((x1 - x5) * (x1 - x5) + (y1 - y5) * (y1 - y5));
//                l32 = Math.Sqrt((x3 - x5) * (x3 - x5) + (y3 - y5) * (y3 - y5));
//                Ph = (l12 + l31 + l32) / 2;
//                s2 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l12));

//                l31 = Math.Sqrt((x2 - x5) * (x2 - x5) + (y2 - y5) * (y2 - y5));
//                l32 = Math.Sqrt((x3 - x5) * (x3 - x5) + (y3 - y5) * (y3 - y5));
//                Ph = (l13 + l31 + l32) / 2;
//                s3 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l13));

//                ss2 = s1 + s2 + s3;

//                l31 = Math.Sqrt((x1 - x6) * (x1 - x6) + (y1 - y6) * (y1 - y6));
//                l32 = Math.Sqrt((x2 - x6) * (x2 - x6) + (y2 - y6) * (y2 - y6));
//                Ph = (l11 + l31 + l32) / 2;
//                s1 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l11));

//                l31 = Math.Sqrt((x1 - x6) * (x1 - x6) + (y1 - y6) * (y1 - y6));
//                l32 = Math.Sqrt((x3 - x6) * (x3 - x6) + (y3 - y6) * (y3 - y6));
//                Ph = (l12 + l31 + l32) / 2;
//                s2 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l12));

//                l31 = Math.Sqrt((x2 - x6) * (x2 - x6) + (y2 - y6) * (y2 - y6));
//                l32 = Math.Sqrt((x3 - x6) * (x3 - x6) + (y3 - y6) * (y3 - y6));
//                Ph = (l13 + l31 + l32) / 2;
//                s3 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l13));

//                ss3 = s1 + s2 + s3;

//                Console.WriteLine($"Площадь первой части = {ss1}\t, Площадь второй = {ss2}\t, Площадь третьей = {ss3}\n");

//                if (ss1 <= (ss2 + 0.00000001) & ss1 >= (ss2 - 0.00000001) & ss1 <= (ss3 + 0.00000001) & ss1 >= (ss3 - 0.00000001) & ss2 <= (ss3 + 0.00000001) & ss2 >= (ss3 - 0.00000001)) //здесь странное условие, потому что погрешность мешает сравнивать
//                {
//                    double S;
//                    Console.WriteLine("Они равны, значит второй треугольник внутри первого!");
//                    S = S1 - S2;
//                    Console.WriteLine($"Площадь, не принадлежащая внутреннему треугольнику равна {S}\n\n\n\n\n\n\n\n");
//                }
//                else Console.WriteLine("Ни один треугольник не входит полностью в другой \n\n\n\n\n\n\n\n");
//            }
//            else if (S2 > S1)
//            {
//                l31 = Math.Sqrt((x4 - x1) * (x4 - x1) + (y4 - y1) * (y4 - y1));
//                l32 = Math.Sqrt((x5 - x1) * (x5 - x1) + (y5 - y1) * (y5 - y1));
//                Ph = (l21 + l31 + l32) / 2;
//                s1 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l21));

//                l31 = Math.Sqrt((x4 - x1) * (x4 - x1) + (y4 - y1) * (y4 - y1));
//                l32 = Math.Sqrt((x6 - x1) * (x6 - x1) + (y6 - y1) * (y6 - y1));
//                Ph = (l22 + l31 + l32) / 2;
//                s2 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l22));

//                l31 = Math.Sqrt((x5 - x1) * (x5 - x1) + (y5 - y1) * (y5 - y1));
//                l32 = Math.Sqrt((x6 - x1) * (x6 - x1) + (y6 - y1) * (y6 - y1));
//                Ph = (l23 + l31 + l32) / 2;
//                s3 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l23));

//                ss1 = s1 + s2 + s3;

//                l31 = Math.Sqrt((x4 - x2) * (x4 - x2) + (y4 - y2) * (y4 - y2));
//                l32 = Math.Sqrt((x5 - x2) * (x5 - x2) + (y5 - y2) * (y5 - y2));
//                Ph = (l21 + l31 + l32) / 2;
//                s1 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l21));

//                l31 = Math.Sqrt((x4 - x2) * (x4 - x2) + (y4 - y2) * (y4 - y2));
//                l32 = Math.Sqrt((x6 - x2) * (x6 - x2) + (y6 - y2) * (y6 - y2));
//                Ph = (l22 + l31 + l32) / 2;
//                s2 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l22));

//                l31 = Math.Sqrt((x5 - x2) * (x5 - x2) + (y5 - y2) * (y5 - y2));
//                l32 = Math.Sqrt((x6 - x2) * (x6 - x2) + (y6 - y2) * (y6 - y2));
//                Ph = (l23 + l31 + l32) / 2;
//                s3 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l23));

//                ss2 = s1 + s2 + s3;

//                l31 = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
//                l32 = Math.Sqrt((x5 - x3) * (x5 - x3) + (y5 - y3) * (y5 - y3));
//                Ph = (l21 + l31 + l32) / 2;
//                s1 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l21));

//                l31 = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
//                l32 = Math.Sqrt((x6 - x3) * (x6 - x3) + (y6 - y3) * (y6 - y3));
//                Ph = (l22 + l31 + l32) / 2;
//                s2 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l22));

//                l31 = Math.Sqrt((x5 - x3) * (x5 - x3) + (y5 - y3) * (y5 - y3));
//                l32 = Math.Sqrt((x6 - x3) * (x6 - x3) + (y6 - y3) * (y6 - y3));
//                Ph = (l23 + l31 + l32) / 2;
//                s3 = Math.Sqrt(Ph * (Ph - l31) * (Ph - l32) * (Ph - l23));

//                ss3 = s1 + s2 + s3;

//                Console.WriteLine($"Площадь первой части = {ss1}\t, Площадь второй = {ss2}\t, Площадь третьей = {ss3}\n");

//                if (ss1 <= (ss2 + 0.00000001) & ss1 >= (ss2 - 0.00000001) & ss1 <= (ss3 + 0.00000001) & ss1 >= (ss3 - 0.00000001) & ss2 <= (ss3 + 0.00000001) & ss2 >= (ss3 - 0.00000001))//здесь странное условие, потому что погрешность мешает сравнивать
//                {
//                    double S;
//                    Console.WriteLine("Площади равны, значит первый треугольник внутри второго!");
//                    S = S2 - S1; 
//                    Console.WriteLine($"Площадь, не принадлежащая внутреннему треугольнику равна {S}\n\n\n\n\n\n\n\n");
//                }
//                else Console.WriteLine("Ни один треугольник не входит полностью в другой\n\n\n\n\n\n\n\n");
//            }
//            else Console.WriteLine("треугольники равны!\n\n\n\n\n\n\n\n");
//        }

//        //функции ниже нужно заполнить блоками сверху, назначив соответствующие параметры и ретурны
//        double Lines() //расчет длин сторон
//        {

//            return 0;
//        }

//        double Perimetr() //расчет периметров
//        {

//            return 0;
//        }
//        double Area() //расчет площадей
//        {

//            return 0;
//        }

//    }
//}

using System;

namespace Testing2022Zubkov1
{
    class Program
    {
        class Point
        {
            public double X;
            public double Y;

            //точка в двумерной плоскости
            public Point(double x = 0.0, double y = 0.0)
            {
                X = x;
                Y = y;
            }
        }

        class Triangle
        {
            public Point[] PS;
            private const int PointsAmount = 3;

            public Triangle() => PS = new Point[PointsAmount];

            //считывание данных
            public void Read()
            {
                //1
                for (var i = 0; i < PointsAmount; i++)
                {
                    //2
                    Console.Write($"Enter x of {i} vertex: ");
                    var x = double.Parse(Console.ReadLine());

                    Console.Write($"Enter y of {i} vertex: ");
                    var y = double.Parse(Console.ReadLine());

                    PS[i] = new Point(x, y);
                }
                //3
            }

            //содержание
            public bool Contains(Triangle another)
            {
                var isContainsAnotherTriangle = true; // 1

                foreach (var point in another.PS) // 2
                {
                    // 3 
                    var a = (PS[0].X - point.X) * (PS[1].Y - PS[0].Y) - (PS[1].X - PS[0].X) * (PS[0].Y - point.Y);
                    var b = (PS[1].X - point.X) * (PS[2].Y - PS[1].Y) - (PS[2].X - PS[1].X) * (PS[1].Y - point.Y);
                    var c = (PS[2].X - point.X) * (PS[0].Y - PS[2].Y) - (PS[0].X - PS[2].X) * (PS[2].Y - point.Y);

                    //4
                    if (a >= 0)
                    {
                        //5
                        if (b >= 0)

                        {
                            //6
                            if (c >= 0)
                            {
                                //7
                                isContainsAnotherTriangle &= true;
                            }
                            else
                                //8
                                isContainsAnotherTriangle &= false;
                        }
                        else
                            //9
                            isContainsAnotherTriangle &= false;
                    }  //10
                    else if (a <= 0)
                    {
                        //11
                        if (b <= 0)
                        {
                            //12
                            if (c <= 0)
                            {
                                //13
                                isContainsAnotherTriangle &= true;
                            }
                            else
                                //14
                                isContainsAnotherTriangle &= false;
                        }
                        else //15
                            isContainsAnotherTriangle &= false;
                    } //16

                    //isContainsAnotherTriangle &= a >= 0 && b >= 0 && c >= 0 || a <= 0 && b <= 0 && c <= 0;
                }


                return isContainsAnotherTriangle; // 17

                // 18
            }

            //Длина отрезка
            private double LineLength(Point p1, Point p2)
            {
                //1
                var xd = p2.X - p1.X;
                var yd = p2.Y - p1.Y;

                //2
                return Math.Sqrt(xd * xd + yd * yd);
            }

            private double Perimeter() => LineLength(PS[0], PS[1]) + LineLength(PS[1], PS[2]) + LineLength(PS[2], PS[0]);

            public double Area()
            {
                //1
                var p = Perimeter() / 2;

                var a = LineLength(PS[0], PS[1]);
                var b = LineLength(PS[1], PS[2]);
                var c = LineLength(PS[2], PS[0]);

                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                //2
            }

            public bool EqualTo(Triangle another) =>
                PS[0].X == another.PS[0].X && PS[0].Y == another.PS[0].Y &&
                PS[1].X == another.PS[1].X && PS[1].Y == another.PS[1].Y &&
                PS[2].X == another.PS[2].X && PS[2].Y == another.PS[2].Y;
        }

        static void Main(string[] args)
        {
            //
            Console.WriteLine("Enter data of first triangle");
            var t1 = new Triangle();
            t1.Read();

            Console.WriteLine("Enter data of second triangle");
            var t2 = new Triangle();
            t2.Read();

            var indicationLargerTriangle = Convert.ToInt32(t1.Contains(t2)) - Convert.ToInt32(t2.Contains(t1));
            //2
            switch (indicationLargerTriangle)
            {
                case 1:
                    Console.WriteLine("First bigger");
                    Console.WriteLine($"Free area: {t1.Area() - t2.Area()}");
                    break;
                case -1:
                    Console.WriteLine("Bad result! We find, that");
                    Console.WriteLine("Second bigger");
                    Console.WriteLine($"Free area: {t2.Area() - t1.Area()}");
                    break;
                case 0:
                    if (t1.EqualTo(t2))
                    {
                        Console.WriteLine("Identical");
                        Console.WriteLine("Free area: 0");
                    }
                    else
                        Console.WriteLine("One does not contain the other");
                    break;
            }
        }
    }
}
