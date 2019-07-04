#  Collection.




                    static void Main(string[] args)
                        {
                            ArrayList list = new ArrayList();
                            list.Add(1);
                            list.Add(3.14);
                            list.Add("Строка");
                            list.Add(new int[] { 1,2,3});
                            foreach (object element in list)
                                Console.WriteLine(element);
                            Console.ReadKey();
                        }




#  event





                    class Asteroid
                    {
                        public static event Action<string> CreateAsteroid;

                        public static event Action<string> CollisionAsteroid;
                       
                        public Asteroid()
                        {
                            CreateAsteroid?.Invoke($"{DateTime.Now}: Asteroid created ");
                        }

                        public void Col()
                        {
                            CollisionAsteroid?.Invoke($"{DateTime.Now}: Asteroid deleted ");
                        }
                    }





# To add data in a file log.txt with System.IO.StreamWriter





                    class Game
                        {
                            static public void Init()
                            {
                                Random random = new Random();

                                Asteroid.CreateAsteroid += s => Console.WriteLine(s);
                    

                                Asteroid.CreateAsteroid += s => 
                                { var sw = new System.IO.StreamWriter("log.txt", true); sw.WriteLine(s); sw.Close(); };

                                Asteroid.CollisionAsteroid += s => Console.WriteLine(s);
                                Asteroid.CollisionAsteroid += s => 
                                { var sw = new System.IO.StreamWriter("log.txt", true); sw.WriteLine(s); sw.Close(); };

                                for (int i = 0; i < 50; i++)
                                {
                                    if(i%4==0)  new Asteroid().Col();
                                    else new Asteroid();
                                    Debug.WriteLine("++++"); Debug.WriteLine("++++");
                                    Thread.Sleep(random.Next(1000, 2000));
                                }

                            }
                        }





#    CreateInstance (instead  -> new int[10]; )




                var Crr = Array.CreateInstance(typeof(int), 10);



# ArrayList  ( System.Collections.)




                ArrayList arrList = new ArrayList();
                arrList.Add(1990);  




# List<T> 



                Console.WriteLine("--- List<T> ---");
                            // Add
                            // Remove
                            // Contains
                            // IndexOf
                            // LastIndexOf
                            // []
                            // RemoveAt
                            // Insert
                            // Count
                            // Clear
                            //Сортировка списка
                            // Sort или Sort(функция_сравнения)
                            // Reverse

                            List<int> parametricArrList = new List<int>() { 1, 2, 3, 4, 5, 5, 5, 1, 1, 2, 2, 3, 6 };

                            parametricArrList.Add(123);




# SortedList<>  or IComparabl


# Dictionary<string, string> dicArr = new Dictionary<string, string>(); 
# Dictionary key - value 




                    Dictionary<string, string> dicArr = new Dictionary<string, string>();
                                //         ключ ,  значение
                                // Count
                                // Clear
                                // []
                                // ContainsKey
                                // Remove
                                // Keys
                                // Values
                                // KeyValuePair<string, string>

                                dicArr.Add("left", "влево");



<p>Example</p>



                        Dictionary<int, string> dictionary2 = new Dictionary<int, string>
                                    {
                                        [1] = "Roman",
                                        [2] = "Roman",
                                        [3] = "Roman",
                                        [4] = "Roman"
                      
                      
                                    };

<p>Example</p>




                        Dictionary<int, string> dictionary = new Dictionary<int, string>
                                    {
                                        {1,"Roman" },
                                        {2,"Ivan" },
                                        {3,"Igor" },
                                        {4,"Vova" }
                                    };




# SortedDictionary<> 



# for multy Collections  HashSet 


# HashSet (   or SortedSet<>)




            Console.WriteLine("--- HashSet ---");

            // Add
            // Remove
            // Contains
            // UnionWith
            // IntersectWith
            // ExceptWith
            // IsSubsutOf
            // IsSuperSetOf
            // IsProperSubsetOf
            // IsProperSupersetOf

            HashSet<int> setInt1 = new HashSet<int>(new int[] { 1, 1, 1, 1, 1, 1, 1, 2, 3, 4, 5 });
   
            HashSet<int> setInt2 = new HashSet<int>();

            setInt2.Add(1);




# Queue  (First In First Out = FIFO)

                            // Enqueue
                            // Dequeue
                            // Peek
                            // Count
                            // Clear
                            //First In First Out = FIFO
                            //queueStr.Peek    - показать элемент в начале очереди без его удаления 
                            //queueStr.Enqueue - Добавляет объект в очередь
                            //queueStr.Dequeue - Извлекает элемент из очереди
                            //queueStr.Count   - возвращает количество элементов в очереди
                            //queueStr.Clear   - очищает очередь





<p>Example</p>



                                private void ExampleQueue()
                                {
                                    var arr = new Queue<int>(4);

                                    arr.Enqueue(1); // 1
                                    arr.Enqueue(1); // 1 1 
                                    arr.Enqueue(5); // 1 1 5
                                    arr.Enqueue(2); // 1 1 5 2

                                    Console.WriteLine(arr.Peek()); // 1 1 5 2
                                    Console.WriteLine(arr.Dequeue());// 1 5 2
                                }




<p>Example</p>



# Stack   First In Last Out - FILO




                                Console.WriteLine("--- Stack ---");
                                // Push
                                // Pop
                                // Peek
                                // Count
                                // Clear


                                Stack<int> staskArr = new Stack<int>();
                               

                                //staskArr.Push - Добавить элемент в стек
                                //staskArr.Pop - извлечь элемент из стека
                                //staskArr.Peek - показать последний элемент стека
                                //staskArr.Count - количество элементов в стеке
                                //staskArr.Clear - очистить стек


                                staskArr.Push(2014);
                                staskArr.Push(9);
                                staskArr.Push(28);
                                staskArr.Push(1900);





<p>Example</p>




                        private void ExampleStack()
                        {
                            var arr = new Stack<int>(4);

                            arr.Push(1);
                            arr.Push(1);
                            arr.Push(5);
                            arr.Push(2);

                            Console.WriteLine(arr.Peek());
                            Console.WriteLine(arr.Pop());
                        }



# init Collections



                    List<int> list = new List<int>() { 1, 2, 3, 4, 5 }; 
                    Dictionary<int, string> dict = new Dictionary<int, string>() { { 1, "One" }, {2, "Two" } }; 




<b>Example </b>




                                public class Worker 
                                {
                                    private Worker() { }
                                    public Worker(string Name, int Age, int Salary)
                                    {
                                        this.Name = Name;
                                        this.Age = Age;
                                        this.Salary = Salary;
                                    }

                                    public string Name { get; set; }
                                    public int Age { get; set; }
                                    public int Salary { get; set; }

                                    public override string ToString()
                                    {
                                        return $"{this.Name,10} {this.Age,3} {this.Salary,3} ";
                                    }

                                }



                                List<NewWorker> report = new List<NewWorker>();

                                foreach (var e in db)
                                    {
                                            if (e.Age > 20) report.Add(new NewWorker { Name = e.Name, Salary = e.Salary });
                                    }



                                db.Add(new Worker($"Имя_777", r.Next(20, 22), 777));

                                foreach (var e in report)
                                {
                                    Console.WriteLine(e.NewName);
                                }
                        


 <b>Example:   var report = db.Where(SEARCH).Select(SELECT_NEWWORKER); </b>


                       

                        var report = db.Where(w => w.Age >= 20)
                             .Select(w => new NewWorker(q.Name, q.Salary));


                        static Worker SELECT(Worker w)
                        {
                            return w;
                        }

                        static NewWorker SELECT_NEWWORKER(Worker w)
                        {
                            return new NewWorker { Salary = w.Salary, Name = w.Name };
                        }
                        static bool SEARCH(Worker w)
                        {
                            return w.Age>20;
                        }
                        static int ORDER(NewWorker w)
                        {
                            return w.Salary;

                        }



 <b>Example</b>



                        var report = from q in db
                            where q.Age > 20
                            select new NewWorker(q.Name, q.Salary);

                   

- ToList()
- ToArray()

 <b>Example with IEnumerable  </b> 



                        IEnumerable<NewWorker> report = from q in db
                            where q.Age > 20
                            select new NewWorker(q.Name, q.Salary);


 <b>Example</b>



 <b>Example, request to db </b>



            var report = db.Where(e => e.Age >= 20 && e.Salary > 5).Select(e => e);

            var report = from q in db
                        where q.Age >= 20 
                        where q.Salary > 5
                        select q;

            var report = db.OrderBy(e => e.Age).ThenBy(e => e.Salary);





# _ LINQ _ Language Integrated Query


<p>(Language Integrated Query) is uniform query syntax in C# and VB.Net to save and retrieve data from different sources. It is integrated in C# or VB,Â thereby eliminating the impedance mismatch between programming languages and databases, 
as well as providing a single querying interface for different types of data sources.</p>
<b> s => s.age > 18; </b>

-  from ~ foreach






                class SimpQuery
                {
                    static void Main()
                    {
                        int[] nums = { 1, -2, 3, 0, -4, 5 };

                        var posNums = from n in nums  where n > 0  select n;      
                        Console.Write("Positive numbers: ");

                        foreach (int i in posNums) Console.Write(i + " ");
                        Console.WriteLine();
                    }
                }


- where 



                static void Main()
                    {
                        int[] nums = { 1, -2, 3, -3, 0, -8, 12, 19, 6, 9, 10 };
                        var posNums = from n in nums
                                    where n > 0 
                                    where n < 10
                                    select n;
                        Console.Write("Положительные числа меньше 10: ");        
                        foreach (int i in posNums) Console.Write(i + " ");
                        Console.WriteLine();
                    }
                }








                    class LINQQueryExpressions
                    {
                        static void Main()
                        {
                            int[] scores = new int[] { 97, 92, 81, 60 };          // Specify the data source.

                            IEnumerable<int> scoreQuery =
                                from score in scores
                                where score > 80
                                select score;                                   // Define the query expression.

                            foreach (int i in scoreQuery)                       // Execute the query.
                            {
                                Console.Write(i + " ");
                            }            
                        }
                    }
                    // Output: 97 92 81




# 


ISequerence<T> Where (ISequerence <T> input); 

# 

                public interface ISequerence<T>
                {
                    ISequerence<T>  Where (ISequerence <T> input);
                    // Where 
                    // Group
                    // Join
                    // Skip
                    // Take 
                    // Select
                    // Count 
                    // Average
                    // Min
                    // Max 
                    // ... 
                    
                }

                public class SqLSequence<T> : ISequerence<T>

                {

                    ISequerence<T>  Where (ISequerence <T> input);
                    // Where 
                    // Group
                    // Join
                    // Skip
                    // Take 
                    // Select
                    // Count 
                    // Average
                    // Min
                    // Max 
                    // ... 
                    
                }




# 2



                        public interface ISequerence<out T>: IEquatable
                        {
                            new  <T> IEquatable
                        };

                    namespace GreekB.Linq
                    {
                            static void Main(string[] arg)
                            {
                                IEquatable<string> cities = mew[] {"Ghent", "London", "Las Vegas", "Hyderabad" }

                                foreach (var city in cities)
                                {
                                    Console.WriteLine(city)
                                }
                            }
                    }




# 3




                    class Program
                    {
                        static void Main(string[] arg)
                        {
                            IEnumerable<string> cities = new[] { "Kiev", "London", "Dublin", "Mumbai" };
                            IEnumerable<string> query = cities.StringThatStartsWith("L");

                            foreach (var city in query)
                            {
                                Console.Write(city)
                            }

                        }
                    }

                    // method 
                    public static class FilterExtensions {

                        public static IEnumerable<string> StringThatStartsWith
                            (this IEnumerable<string> input , string start)
                        {
                            foreach (var s in input)
                            {
                                if(s.StartsWith(start)) yield return s;
                            }
                        }




# using System.Linq; 
# Extensions Methods and LINQ Select , OrderBy, Where ..  





public static class Enumerable
    {
        public static IEnumerable<TSource>Where<TSource>
            (this IEnumerable <TSource> source, Func<TSource, bool>predicate)
    }





* how to do the filter 




namespace GreekB.Linq
{
        static void Main(string[] arg)
        {
            IEnumerable<string> cities = new[] { "Kiev", "London", "Dublin" };

            IEnumerable<string> query =
                cities.Filter(StringThatStartsWithL)

            foreach (var city in query)
            {
                Console.Write(city)
            }

        }
        static bool StringThatStartsWithL(string s)
        {
            return s.StartsWith("L")
        }
}

namespace Extensions
{
    public static class FilterExtensions
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> input, FilterExtensions<T> predicate)
        {
            foreach (var item in input)
            {
                if (predicate(item))
                {
                    yield return item;
                }

            }
        }
    }
    public delegate bool FilterDelegate<T>(T item);

}




*(delegate takes a string returns Bool )
* or  delegate (string item ) { return item.StartWith("L");  }





            IEnumerable<string> query = cities.Filter(  
                                        delegate (string item ) {  
                                                return item.StartWith("L");   
                                        }
                     )


# or Lambdos 



            IEnumerable<string> query = cities.Filter((item )  => item.StartWith("L"))




# Func generic types and it is encapsulate delegate
##  Func<int, bool>  params -> takes as int, return as bool 



// params when we  want to add 

    Func<int, int> square = x => x * x;
    Func<int, int, int> Add = (x, y) => x + y;
    Console.Write(square(3)); // 9




# if we don't want to return (insted of Func) -> Action 





                    static void Main(string[] arg)
                    {
                                IEnumerable<string> cities = new[] { "Kiev", "London", "Dublin" };


                                Func<int, int> square = x => x * x;
                                Func<int, int, int> Add = (x, y) => x + y;

                                Action<int> Write = x => Console.WriteLine(x);
                                Write(square(Add(1, 3)));

                                IEnumerable<string> query =
                                    cities
                                    .Where((city) => city.StartsWith("L"))
                                    .OrderByDescending(city => city.Length); //    Where 

                    } 





# Lambdas for LINQ + SQL server  " IEnumerable<string> filteredList  = cities.Where(s=> s.StartsWith("L")) " 

# web servises / databases 




                static void Main(string[] arg)
                        {
                            MovieDB db = new MovieDB();

                            IEnumerable<Movie> query = db.Movies
                                .Where(m => m.Title.StartWith("Star"))
                                .OrdeBy(m => m.ReleaseDate.Year);

                            foreach (var movie in query)
                            {
                                Console.Write(movie.Title)
                            }
                            WorkWithFunc();

                        }

                        private static void WorkWithFunc()
                        {
                            Expression<Func<int, int> >square = x => x * x;
                            Func<int, int, int> Add = (x, y) => x + y;
                            Action<int> Write = x => Console.WriteLine(x);
                        }
                }




#Comprehension Query Syntax 







                    string[] cities = { "Kiev", "London", "Dublin", "Mumbai" };

                    IEnumerable<string> fileteredCities =
                        from city in cities
                        where city.StartsWith("L") && city.Length < 15
                        orderby city
                        select city;
                        
                    
                    IEnumerable<string> fileteredCities =  cities
                                                                .Where(c=> c.StartsWith("L") && city.Length < 15)
                                                                .OrderBy( c=> c)
                                                                .Select(c => c)

// or (the same  )






                    IEnumerable<Movie> query2 =
                                                from m in db.Movies
                                                where m.Title.StartsWith("L")
                                                select m;


// or 




                            var  query3 =
                                            from m in db.Movies
                                            where m.Title.StartsWith("L")
                                            select m;





