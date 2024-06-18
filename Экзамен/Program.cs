/*
using System;

public struct Result
{
    public int min;
    public int max;
}

public class Program
{
    public static Result GetMinMax()
    {
        // Примерный код для нахождения минимального и максимального значения
        int min = 10; // Замените на фактическое вычисление минимального значения
        int max = 20; // Замените на фактическое вычисление максимального значения

        // Возвращаем экземпляр структуры Result с заданными значениями
        return new Result { min = min, max = max };
    }

    public static void Main()
    {
        // Пример вызова функции GetMinMax и вывод результата
        var result = GetMinMax(); // Пример вызова функции с пустым входным массивом

        Console.WriteLine($"Min: {result.min}, Max: {result.max}");
    }
}

*/


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Вопрос №2 - Устройство класса List (Дженерик)

// Дженерик - обобщения конструкция языка, которые позволяют писать код,
// который будет работать одинаково для разных типов данных. + Повторное использование кода.

using System.Collections.Generic;

namespace Vopros2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Пример работы с List из стандартной библиотеки
            List<int> list = new List<int>();
            list.Add(1); 
            list.Add(14);
            list.Add(16);

            Console.WriteLine(list.Count); // Вывод количества элементов в List
            Console.WriteLine(list.Capacity); // Вывод текущей емкости List
            Console.WriteLine(list[1]); // Вывод элемента по индексу 1

            Console.WriteLine();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }



            Console.WriteLine();



            // Создание экземпляра MyList с типом данных String
            MyList<String> myList = new MyList<String>();
            myList.Add("alalal"); // Добавление строки в myList
            myList.Add("bybybyby"); 
            myList.Add("gagagga"); 

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.WriteLine();

            // Создание экземпляра MyList с типом данных int
            MyList<int> moyList = new MyList<int>();
            moyList.Add(321); // Добавление числа в moyList
            moyList.Add(123); 

            for (int i = 0; i < moyList.Count; i++)
            {
                Console.WriteLine(moyList[i]);
            }
        }
    }

    // Класс MyList, представляющий собой обобщенный список
    public class MyList<T> // T - обобщенный тип данных
    {
        private T[] _array = Array.Empty<T>(); // Инициализация пустого массива

        // Индексатор позволяет обращаться к коллекции по индексу
        public T this[int index]
        {
            // Возвращает элемент по индексу
            get
            {
                return _array[index];
            }
            // Присваивает элемент по индексу
            set
            {
                _array[index] = value;
            }
        }

        // Возвращаем количество текущих элементов в коллекции
        public int Count { get { return _array.Length; } }

        // Метод для добавления элементов в коллекцию
        public void Add(T value)
        {
            var newArray = new T[_array.Length + 1]; // Создаем новый массив, на один элемент больше

            // Копируем элементы из старого массива в новый
            for (int i = 0; i < _array.Length; i++)
            {
                newArray[i] = _array[i];
            }

            // Добавляем новый элемент в конец массива
            newArray[_array.Length] = value;

            // Переназначаем старый массив на новый
            _array = newArray;
        }
    }
}






//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Вопрос №3 - Функция Map/Filter/Reduce. Лямбда выражения


//Пример делегата
namespace Vopros3
{
    class Program
    {
        public delegate double MathDelegate(double value1, double value2);

        public static double Add(double value1, double value2)
        {
            return value1 + value2;
        }
        public static double Product(double value1, double value2)
        {
            return value1 * value2;
        }

        public static void Main()
        {
            MathDelegate mathDelegate = Add; // Создание экземпляра делегата
            var result = mathDelegate(5, 2);
            Console.WriteLine(result);
            // вывод: 7

            mathDelegate = Product;
            result = mathDelegate(5, 2);
            Console.WriteLine(result);
            // вывод: 10

        }
    }
}




/*
//Map
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Использование Select для возведения каждого числа в квадрат
        List<int> squaredNumbers = numbers.Select(x => x * x).ToList();

        Console.WriteLine(string.Join(", ", squaredNumbers)); // Выведет "1, 4, 9, 16, 25"
    }
}
*/


/*
//Filter
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Использование Where для фильтрации четных чисел
        List<int> evenNumbers = numbers.Where(x => x % 2 == 0).ToList();

        Console.WriteLine(string.Join(", ", evenNumbers)); // Выведет "2, 4"
    }
}
*/


/*
//Reduce
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        // Использование Aggregate для суммирования всех чисел
        int sum = numbers.Aggregate((acc, x) => acc + x);

        Console.WriteLine("Sum: " + sum); // Выведет "15"
    }
}
*/






































/*

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// Вопрос №6 - Словарик

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //Словарь
        //1 Вариант
        //var frequencyDict = new Dictionary<int, string>()
        //2 Вариант
        Dictionary<int,string> Dict = new Dictionary<int, string>()
        //Первый способ добавления
        {
            // {5," Тест" }, - Можно и так 
            [1] = "аабб",
            [2] = "ггдд"
        };
        
        //Второй способ добавления
        Dict.Add(3, "ллрр");
        //Третий способ добавления
        Dict[4] = "ххч";

        // Выводим содержимое вашего словаря
        foreach (var conclusion in Dict)
        {
            Console.WriteLine($"Ключ: {conclusion.Key}, Значение: {conclusion.Value}");
        }

        // Создаем новый словарь для хранения частоты каждой буквы
        var letter = new Dictionary<char, int>();

        // Обрабатываем строки из вашего словаря
        foreach (var word in Dict)
        {
            string text = word.Value;

            // Подсчитываем количество каждой буквы
            foreach (char c in text)
            {
                if (char.IsLetter(c)) //IsLetter - Проверка, является ли указанный символ буквой
                {
                    // Если символ уже есть в словаре, увеличиваем его частоту
                    if (letter.ContainsKey(c)) 
                    {
                        letter[c]++; 
                    }
                    // Иначе добавляем символ в словарь с начальной частотой 1
                    else
                    {
                        letter[c] = 1;
                    }
                }
            }
        }

        // Общее количество букв в тексте
        int total = letter.Values.Sum();

        // Вычисляем и выводим долю каждой буквы
        foreach (var k in letter)
        {
            double frequency = (double)k.Value / total;
            Console.WriteLine($"Буква: {k.Key}, Частота: {k.Value}, Доля: {frequency:P2}");
        }
    }
}

*/