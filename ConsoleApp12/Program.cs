/*
// Коллекция List
int[] arr = new int[] { 1, 2, 3 };
List<int> array = new List<int>();
array.Add(10);
array.AddRange(arr);
array.Insert(0, 100);
array.Remove(10);
int value = array.IndexOf(10); // -1
//value = array[10];// ошибка, поскольку индекса нет
array[0] = 11;
if (array.Contains(10))
    Console.WriteLine("В коллекции есть число 10");
int countItems = array.Count;
// Словарь Dictionary - хранение объектов по
// ключам-индексам
Dictionary<string, int> map = 
    new Dictionary<string, int>();
map.Add("Первый", 100);
//map.Add("Первый", 100); тут будет ошибка
map.Add("Еще какой-то ключ", 255);

if (map.ContainsKey("Первый"))
    value = map["Первый"];
//map.Remove("Первый");
List<string> keys = map.Keys.ToList();
for(int i = 0; i < keys.Count; i++)
    Console.WriteLine(map[keys[i]]);
*/
// Делегаты и лямбда-выражения
/*namespace Test
{
    delegate void testDelegate(int a);
    class Program
    {//Делегат - тип данных, который содержит
     // ссылки на методы
        static void Main()
        {
            //лямбда-выражения - сокращенные методы без имени
            Action<int, string> a = (s, a) => 
            {
                s++;
                Console.WriteLine(a + " " + s); 
            };
            a(10, "Привет");
            Func<int, int, int> calc = (x, y) =>
            {
                return x + y;
            };
            Console.WriteLine(calc(10, 20));
            List<string> students = new List<string>();
            students.Add("Аня");
            students.Add("Петя");
            students.Add("Серега");
            students.Add("Валя");
            students.Add("Геннадий");
            var search = students.
                Where(s => s.Length > 3).
                ToList();
            int[] a1 = new int[10];
            
            search.ForEach(s => Console.WriteLine(s));

            int[] array = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < array.Length; i++)
            {
                
            }

            Action<int> action = Test1;
            action += Test2;
            action(100);
            Func<int, int, int> func = Summ;
            testDelegate m = Test1;
            m(10);
            m += Test2;
            m(100);
            Test3(m);
        }

        static int Summ(int x, int y) => x + y;

        static void Test1(int b)
        {

        }

        static void Test2(int b)
        { 
        }

        static void Test3(testDelegate test)
        {
            test(100);
        }

    }
}*/
using System.Linq;
// 7 тема 1 задание
List<int> array = new List<int>();
Console.WriteLine("K?");
int k = int.Parse(Console.ReadLine());
Console.WriteLine("N?");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{ 
    Console.Write($"Введите число [{i}]");
    array.Add(int.Parse(Console.ReadLine()));
}
int result = array.Where(s => s % k == 0).Sum();
int index = array.IndexOf(10); //определить индекс
Console.WriteLine(result);
//кусок 5ого задания
List<int> array2 = array.
    Count(s => s % 2 == 0);
if (array2.Count == 0)
    Console.WriteLine("Четных элементов нет");
// кусок 6 задачи
int min = array.Min();
int max = array.Max();
Console.WriteLine(max - min);
// кусок 7 задачи
int count = 0;
array = array.Select(s => {
    if (s > k)
    {
        count++;
        return k;
    }
    else
        return s;
    }).ToList();
Console.WriteLine("Кол-во замен: " + count);

int countPozitive = array.Count(s => s > 0);
int firstNegativeValue = array.
    FirstOrDefault(s => s < 0);
int lastNotZero = array.Last(s => s != 0);
int sumElements3and4 = array.Skip(2).Take(2).Sum();
int indexValue100 = array.IndexOf(100);
//***** не очень удачное применение функций 
int maxValue = array.Max();
int minValue = array.Min();
int maxIndex = array.IndexOf(maxValue);
int minIndex = array.IndexOf(minValue);
array[maxIndex] = minValue;
array[minIndex] = maxValue;
//***** - много циклов, по сравнению с созданием своего цикла
array.Clear(); // очистить коллекцию
