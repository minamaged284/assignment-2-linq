using ASSLINQ;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region element operators

            //#region question 1
            //var result1 = ListGenerators.ProductList.FirstOrDefault(p => p.UnitsInStock == 0, new Product() { ProductID = -1, ProductName = "no items", Category = "no items", UnitPrice = 0, UnitsInStock = 0 });

            //Console.WriteLine(result1);
            //#endregion

            //#region question 2
            //var result2 = ListGenerators.ProductList.FirstOrDefault(p => p.UnitPrice >1000, null);

            //Console.WriteLine(result2);

            //#endregion

            #region question 3
            int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result3 = Arr.Where(p => p > 5).ToList();

            //result3.RemoveAt(0);

            //Console.WriteLine(result3.FirstOrDefault(n => n > 5, -1));

            #endregion

            #endregion

            #region aggregate operators

            //#region question1


            //var result4 = Arr.Count(n => n % 2 != 0);
            //Console.WriteLine(result4);
            //#endregion


            //#region question 2

            //var result5 = ListGenerators.CustomerList.Select(p => p);

            //foreach (var i in result5)
            //{
            //    Console.WriteLine($"{i} num of orders =  {i.Orders.Count()}");
            //}
            //#endregion

            #region question 3

            //var result6 = ListGenerators.ProductList.GroupBy(c => c.Category);
            //foreach (var i in result6)
            //{
            //    Console.WriteLine($"{i.Key},{i.Count()}");
            //}
            #endregion

            #region question 4

            //var result7 = Arr.Sum();
            //Console.WriteLine(result7);
            #endregion

            #region question 5
            string[] dictionary = File.ReadAllText("dictionary_english.txt").Split(new char[] { '\n', '\r', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //var result8 = dictionary.Sum(s => s.Count()); 
            //Console.WriteLine(result8);
            #endregion

            #region question 6

            //var result9 = dictionary.OrderBy(x => x.Count()).First().Length;
            //Console.WriteLine(result9);


            #endregion

            #region question 7

            //var result10 = dictionary.OrderByDescending(x => x.Count()).First().Length;
            //Console.WriteLine(result10);



            #endregion

            #region question 8

            //var result11 = dictionary.Average(w=>w.Count());



            //Console.WriteLine(result11);
            #endregion


            //#region question 9
            var cats = from product in ListGenerators.ProductList
                       group ListGenerators.ProductList by product.Category;


            //foreach( var cat in cats)
            //{ int total = 0;
            //    foreach( var item in cat)
            //    {
            //        total = item.Where(u=>u.Category.Equals(cat.Key.ToString())).Sum(p=>p.UnitsInStock);

            //    }
            //        Console.WriteLine($"{cat.Key} /{total}");

            //}



            //#endregion

            //#region question 10
            //foreach (var cat in cats)
            //{
            //    decimal cheapes = 0;
            //    foreach (var item in cat)
            //    {
            //        cheapes = item.Where(u => u.Category.Equals(cat.Key.ToString())).OrderBy(p => p.UnitPrice).First().UnitPrice;

            //    }
            //    Console.WriteLine($"{cat.Key} /{cheapes}");

            //}


            //#endregion

            //#region question 11
            //foreach (var cat in cats)
            //{
            //    var cheapestProduct = new Product();
            //    foreach (var item in cat)
            //    {
            //        cheapestProduct = item.Where(u => u.Category.Equals(cat.Key.ToString())).OrderBy(p => p.UnitPrice).First();

            //    }
            //    Console.WriteLine($"{cat.Key} /{cheapestProduct}");

            //}


            //#endregion




            //#region question 12
            //foreach (var cat in cats)
            //{
            //    decimal mostExpensive = 0;
            //    foreach (var item in cat)
            //    {
            //        mostExpensive = item.Where(u => u.Category.Equals(cat.Key.ToString())).OrderBy(p => p.UnitPrice).Last().UnitPrice;

            //    }
            //    Console.WriteLine($"{cat.Key} /{mostExpensive}");

            //}


            //#endregion

            //#region question 13
            //foreach (var cat in cats)
            //{
            //    var mostExpensiveProduct = new Product();
            //    foreach (var item in cat)
            //    {
            //        mostExpensiveProduct = item.Where(u => u.Category.Equals(cat.Key.ToString())).OrderBy(p => p.UnitPrice).Last();

            //    }
            //    Console.WriteLine($"{cat.Key} /{mostExpensiveProduct}");

            //}


            //#endregion

            //#region question 14

            //foreach (var cat in cats)
            //{
            //    decimal averagePrice = 0;
            //    foreach (var item in cat)
            //    {
            //        averagePrice = item.Where(u => u.Category.Equals(cat.Key.ToString())).Average(p => p.UnitPrice);

            //    }
            //    Console.WriteLine($"{cat.Key} /{averagePrice}");

            //}


            //#endregion





            #endregion

            #region set operators

            #region question 1

            #endregion
            #endregion

            #region partitioning

            #region question 1

            //var result20 = ListGenerators.CustomerList.Where(c => c.City == "Berlin").SelectMany(o => o.Orders).Take(3);
            //foreach (var i in result20)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region question 2
            //var result21 = ListGenerators.CustomerList.Where(c => c.City == "Berlin").SelectMany(o => o.Orders).Skip(2);
            //foreach (var i in result20)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region question 3
            //var result23 = Arr.TakeWhile((n, i) => n > i);
            //foreach (var i in result23)
            //{
            //    Console.WriteLine(i);
            //}
            //#endregion

            //#region question 4
            //var result24 = Arr.SkipWhile((n) => n %3!=0);
            //foreach (var i in result24)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region question 5

            //var result25 = Arr.SkipWhile((n, i) => n > i);
            //foreach (var i in result25)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #endregion


            #region quantifiers
            #region question 1

            //Console.WriteLine(dictionary.Any(w => w.Contains("ei")));
            #endregion
            #region question 2

            
            //var result27 = ListGenerators.ProductList.GroupBy(c=>c.Category).ToList();

            

            //foreach (var cat in result27.ToList())
            //{
            //    if(cat.All(p => p.UnitsInStock != 0))
            //    {
            //        result27.Remove(cat);
            //    }
            //}

            //foreach (var i in result27)
            //{
            //    Console.WriteLine(i.Key);
            //}
            #endregion


            //var result28 = ListGenerators.ProductList.GroupBy(c => c.Category).ToList();



            //foreach (var cat in result28.ToList())
            //{
            //    if (cat.Any(p => p.UnitsInStock == 0))
            //    {
            //        result28.Remove(cat);
            //    }
            //}

            //foreach (var i in result28)
            //{
            //    Console.WriteLine(i.Key);
            //}
            #endregion

            #region grouping

            #region question 1

            List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            var result29 = numbers.GroupBy(n => n % 5);
            foreach (var number in result29)
            {
                switch (number.Key)
                {
                    case 0:
                        Console.WriteLine("numbers with remainder of 0 when devided with 5");

                        break;

                    case 1:
                        Console.WriteLine("numbers with remainder of 1 when devided with 5");

                        break;

                    case 2:
                        Console.WriteLine("numbers with remainder of 2 when devided with 5");

                        break;

                    case 3:
                        Console.WriteLine("numbers with remainder of 3 when devided with 5");

                        break;

                    case 4:
                        Console.WriteLine("numbers with remainder of 4 when devided with 5");

                        break;
                }
                foreach (var n in number)
                {
                    Console.WriteLine(n);

                }
                
            }
            #endregion


            #region question 2

            var result30 = dictionary.GroupBy(w => w[0]);
            foreach (var letter in result30)
            {
                Console.WriteLine(letter.Key);
            }
            #endregion

            #region question 3

            #endregion
            #endregion
        }
    }
}
