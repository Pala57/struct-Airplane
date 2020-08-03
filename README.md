1. Оголосити структуру Airplane, яка представляє інформацію про рейс літака і містить такі поля (відкриті):
- StartCity – місто відправлення;
- FinishCity – місто прибуття;
- StartDate – дата відправлення, задана структурою Date;
- FinishDate – дата прибуття, задана структурою Date;
Оголосити структуру Date, яка містить дату і включає такі поля (відкриті):
- Year – рік;
- Month – місяць;
- Day – день;
- Hours – години;
- Minutes – хвилини.
2. Для кожної структури реалізувати конструктори.
3. У структуру Airplane додати методи (нестатичні):
- GetTotalTime(), який обраховує сумарний час подорожі у хвилинах;
- IsArrivingToday(), що повертає true, якщо відправлення і прибуття в той же день.
4. У класі Program передбачити статичні методи:
- ReadAirplaneArray() – читає з клавіатури масив структур (n штук) і повертає масив структур типу Airplane;
- PrintAirplane() – приймає структуру типу Airplane і виводить її на екран;
- PrintAirplanes() – приймає масив структур типу Airplane і виводить його на екран;
- GetAirplaneInfo() – приймає масив структур типу Airplane і повертає через out-параметри найбільший та найменший час подорожі.
- SortAirplanesByDate() – приймає масив структур типу Airplane і сортує його за спаданням дати відправлення;
- SortAirplanesByTotalTime() – приймає масив структур типу Airplane і сортує його за зростанням часу подорожі.

Методичні вказівки до завдання.
1. Прочитати з клавіатури масив структур.
2. Програма не повинна допускати помилки введення.
3. Для сортування масивів використовуйте метод Array.Sort() та функцію компаратор. Компаратор – це метод, який приймає дві структури і повертає ціле число: 
•	1, якщо перша структура більше за другу;
•	-1, якщо перша структура менша за другу;
•	0, якщо структури рівні.
Нехай є структура:
  	public struct Info
{
            public string Name;
            public int []Points;
            public double GetAverage()
            {
                double res = 0;
                for (int i = 0; i < Points.Length; i++)
                    res += Points[i];
                res /= Points.Length;
                return res;
            }
}        
Тоді для порівняння двох структур за середнім арифметичним чисел масиву Points потрібно оголосити компаратор:
public static int SortInfoByAveragePoints(Info a, Info b)
       {
            double avgA = a.GetAverage(), avgB = b.GetAverage();
     if (avgA > avgB)
                return 1;
     if (avgA < avgB)
                return -1;
     return 0;       
}
Щоб скористатися компаратором, потрібно передати його другим параметром у метод Array.Sort:
// Тут arr – масив типу Info
Array.Sort(arr, SortInfoByAveragePoints);
4. Реалізуйте меню, яке дозволяє вибирати реалізовані завдання.
5. При виведенні даних обов’язково використайте додаткові можливості консолі:
Можливість	Як реалізувати у мові С#
Встановити заголовок вікна консолі	Console.Title = "Лабораторна робота №4";
Примусово встановити розміри вікна консолі (вимірюється у символах)	Console.SetWindowSize(100, 25);
Очищення вікна консолі	Console.Clear();
Примусове встановлення кольору фону вікна та кольору тексту	Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.Clear();
Повернути кольори до тих значень, які задані по замовчуванню в операційній системі	Console.ResetColor();
Виведення тексту різними кольорами	Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
Console.Write("Текст ");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("можна ");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("виводити ");
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.DarkRed;
Console.Write("рiзними ");
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("кольорами");
Console.ResetColor();  
