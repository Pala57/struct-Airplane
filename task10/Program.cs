using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Date
    {
        public int Year;
        public int Month;
        public int Day;
        public int Hours;
        public int Mitutes;
        public Date(int y, int m, int d, int h, int min)
        {
            Year = y;
            Month = m;
            Day = d;
            Hours = h;
            Mitutes = min;
        }

        public void PrintDate()
        {
            Console.WriteLine(Hours + ":" + Mitutes + "  " + Day + "/" + Month + "/" + Year);
        }
        public void FillDate()
        {
            bool f;
            do
            {
                Console.WriteLine("Ввести Year");
                f = int.TryParse(Console.ReadLine(), out Year);
                if (!f)
                {
                    Console.WriteLine("Помилка введіть ще раз");
                }
            } while (!f);
            do
            {
                Console.WriteLine("Ввести Month");
                f = int.TryParse(Console.ReadLine(), out Month);
                if (!f)
                {
                    Console.WriteLine("Помилка введіть ще раз");
                }
            } while (!f);
            do
            {
                Console.WriteLine("Ввести Day");
                f = int.TryParse(Console.ReadLine(), out Day);
                if (!f)
                {
                    Console.WriteLine("Помилка введіть ще раз");
                }
            } while (!f);
            do
            {
                Console.WriteLine("Ввести Hours");
                f = int.TryParse(Console.ReadLine(), out Hours);
                if (!f)
                {
                    Console.WriteLine("Помилка введіть ще раз");
                }
            } while (!f);
            do
            {
                Console.WriteLine("Ввести Mitutes");
                f = int.TryParse(Console.ReadLine(), out Mitutes);
                if (!f)
                {
                    Console.WriteLine("Помилка введіть ще раз");
                }
            } while (!f);
        }
    }
    struct Airplane
    {
        public string StartCity;
        public string FinishCity;
        public Date StartDate;
        public Date FinishDate;
        public Airplane(string s, string f, int y, int m, int d, int h, int min, int y2, int m2, int d2, int h2, int min2)
        {
            StartCity = s;
            FinishCity = f;
            //StartDate.Year=obj.Year;
            //StartDate.Mitutes = obj.Mitutes;
            //StartDate.Month = obj.Month;
            //StartDate.Day = obj.Day;
            //StartDate.Hours = obj.Hours;
            //FinishDate.Year = obj2.Year;
            //FinishDate.Mitutes = obj2.Mitutes;
            //FinishDate.Month = obj2.Month;
            //FinishDate.Day = obj2.Day;
            //FinishDate.Hours = obj2.Hours;
            StartDate = new Date(y, m, d, h, min);
            FinishDate = new Date(y2, m2, d2, h2, min2);
        }
        public bool IsArrivingToday()
        {
            if (StartDate.Day == FinishDate.Day)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void FillAirplane()
        {
            Console.WriteLine("Введіть місто відправлення");
            StartCity = Console.ReadLine();
            Console.WriteLine("Введіть місто прибуття");
            FinishCity = Console.ReadLine();
            StartDate.FillDate();
            FinishDate.FillDate();
        }
        public double GetTotalTime()
        {
            double k = 0;

            k = (FinishDate.Year - StartDate.Year) * 525600 + (FinishDate.Month - StartDate.Month) * 43800.048 + (FinishDate.Day - StartDate.Day) * 1440 + (FinishDate.Hours - StartDate.Hours) * 60 + (FinishDate.Mitutes - StartDate.Mitutes);
            //Console.WriteLine("K=" + k);
            return k;


        }

        public void PrintAirplane()
        {

            Console.WriteLine("Місто відправлення: {0}", StartCity);
            Console.WriteLine("Місто прибуття:     {0}", FinishCity);
            Console.WriteLine("Дата відправлення:  ");
            StartDate.PrintDate();
            Console.WriteLine("Дата прибуття:  ");
            FinishDate.PrintDate();
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                       System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            //Date A=new Date(1999,10,12,16,23);
            //A.PrintDate();

          //  Airplane D = new Airplane("Sdasd", "asdas", 1999, 10, 12, 16, 23, 1999, 10, 13, 05, 35);


            Airplane[] arr = new Airplane[0];



            //  ReadAirplaneArray(ref arr);

            //  arr= ReadAirplaneArrays(arr);

            //  PrintAirplanes(arr);
            ////  SortAirplanesByTotalTime(arr);


            //  SortAirplanesByDate(arr);
            //  PrintAirplanes(arr);

            int x;
            do
            {

                Console.WriteLine("1.Функція: читає з клавіатури масив структур (n штук) і повертає масив структур типу Airplane\n\n");
                Console.WriteLine("2.Функція: приймає масив структур типу Airplane і виводить його на екран\n\n");
                Console.WriteLine("3.Функція: приймає масив структур типу Airplane і повертає через out-параметри найбільший та найменший час подорожі\n\n");
                Console.WriteLine("4.Функція: приймає масив структур типу Airplane і сортує його за зростанням часу подорожі\n\n");
                Console.WriteLine("5.Функція: приймає масив структур типу Airplane і сортує його за спаданням дати відправлення\n\n");
                Console.WriteLine("6.Функція: приймає структуру типу Airplane і виводить її на екран;\n\n");
                Console.WriteLine("0.Вихід.\n\n");
                x = int.Parse(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        ReadAirplaneArray(ref arr);
                        break;
                    case 2:
                        PrintAirplanes(arr);
                        break;
                    case 3:
                        double min = double.MaxValue;
                        double max = double.MinValue;
                        GetAirplaneInfo(arr, out min, out max);
                        Console.WriteLine("max = " + max + "\nmin = " + min);
                        break;
                    case 4:
                        SortAirplanesByTotalTime(arr);
                        break;
                    case 5:
                        SortAirplanesByDate(arr);
                        break;
                    case 6:
                        int y;
                        Console.WriteLine("Введіть № масиву\n");
                        y = int.Parse(Console.ReadLine()) - 1;
                        PrintAirplane(arr[y]);
                        break;

                    default:

                        break;
                }
            } while (x != 0);

            Console.ReadLine();

        }

        static void ReadAirplaneArray(ref Airplane[] arr)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1].FillAirplane();

        }
        static Airplane[] ReadAirplaneArrays(Airplane[] arr)
        {
            bool f;
            int n;
            do
            {
                Console.WriteLine("Ввести n");
                f = int.TryParse(Console.ReadLine(), out n);
                if (!f)
                {
                    Console.WriteLine("Помилка введіть ще раз");
                }
            } while (!f);
            Array.Resize(ref arr, arr.Length + n);

            for (int i = arr.Length - n; i < arr.Length; i++)
            {
                arr[i].FillAirplane();
            }

            return arr;
        }

        static void PrintAirplane(Airplane obj)
        {
            obj.PrintAirplane();

        }
        static void PrintAirplanes(Airplane[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].PrintAirplane();
            }

        }

        static void GetAirplaneInfo(Airplane[] arr, out double min, out double max)
        {
            min = double.MaxValue;
            max = double.MinValue;
            int counter = 0;
            int counter1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].GetTotalTime() < min)
                {
                    counter = i;
                    min = arr[i].GetTotalTime();

                }
                if (arr[i].GetTotalTime() > max)
                {
                    counter1 = i;
                    max = arr[i].GetTotalTime();

                }
            }
            Console.WriteLine("counter min= " + counter);
            Console.WriteLine("counter max= " + counter1);
        }

        public static int SortInfoByGetTotalTime(Airplane a, Airplane b)
        {
            double avgA = a.GetTotalTime(), avgB = b.GetTotalTime();
            if (avgA > avgB)
                return 1;
            if (avgA < avgB)
                return -1;
            return 0;
        }



        static void SortAirplanesByTotalTime(Airplane[] arr)
        {
            Array.Sort(arr, SortInfoByGetTotalTime);
        }

        static void SortAirplanesByDate(Airplane[] arr)
        {
            Array.Sort(arr, SortInfoByDate);
        }

        public static int SortInfoByDate(Airplane a, Airplane b)
        {
            if (a.StartDate.Year < b.StartDate.Year)
            {
                return 1;
            }
            else if (a.StartDate.Year == b.StartDate.Year)
            {
                if (a.StartDate.Month < b.StartDate.Month)
                {
                    return 1;

                }
                else if (a.StartDate.Month == b.StartDate.Month)
                {
                    if (a.StartDate.Day < b.StartDate.Day)
                    {
                        return 1;
                    }
                    else if (a.StartDate.Day == b.StartDate.Day)
                    {
                        if (a.StartDate.Hours < b.StartDate.Hours)
                        {
                            return 1;
                        }
                        else if (a.StartDate.Hours == b.StartDate.Hours)
                        {
                            if (a.StartDate.Mitutes < b.StartDate.Mitutes)
                            {
                                return 1;
                            }
                            else if (a.StartDate.Mitutes == b.StartDate.Mitutes)
                            {
                                return 0;
                            }
                            else
                            {
                                return -1;
                            }
                        }
                    }
                }
            }
            return -1;
        }
    }
}

