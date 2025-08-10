namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            var r1 = ListGenerators.ProductList.Where(p => p.UnitsInStock == 0).First();
            var r2 = ListGenerators.ProductList.Where(p => p.UnitPrice > 1000).FirstOrDefault();//fristordefault if got match return null
            int[] Arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var r3 = Arr1.Where(p => p > 5).Skip(1).First();

            var r4 = Arr1.Where(p => p % 2 == 0).Count();
            var r5 = ListGenerators.CustomerList.Select(c => new
            {
                id = c.CustomerID,
                count = c.Orders.Count()
            });
            var r6 =
                 from p in ListGenerators.ProductList
                 group p by p.Category into g
                 select new
                 {
                     Category = g.Key,
                     Count = g.Count()
                 };
            var r7 = Arr1.Sum();
            string[] arr2 = File.ReadAllLines("dictionary_english.txt");

            var r8 = arr2.Sum(w => w.Length);
            var r9 = arr2.Min(w => w.Length);
            var r10 = arr2.Max(w => w.Length);
            var r11 = arr2.Average(w => w.Length);
            var r12 = ListGenerators.ProductList.GroupBy(p => p.Category).Select(g => new
            {
                category = g.Key,
                Total = g.Sum(x => x.UnitsInStock)
            });
            var r13 = ListGenerators.ProductList
                     .GroupBy(p => p.Category)
                        .Select(g => new
                        {
                            Category = g.Key,
                            Price = g.Min(x => x.UnitPrice)
                        });
            var r14 = ListGenerators.ProductList
                     .GroupBy(p => p.Category)
                        .Select(g => new
                        {
                            Category = g.Key,
                            Product = g.MinBy(x => x.UnitPrice)
                        });
            var r15 = ListGenerators.ProductList
                   .GroupBy(p => p.Category).Select(g => new
                   {
                       Category = g.Key,
                       Price = g.Max(x => x.UnitPrice)
                   });
            var r16 = ListGenerators.ProductList
                  .GroupBy(p => p.Category)
                  .Select(g => new
                  {
                      Category = g.Key,
                      Price = g.MaxBy(x => x.UnitPrice)
                  });
            var r17 = ListGenerators.ProductList
                  .GroupBy(p => p.Category)
                  .Select(g => new
                  {
                      Category = g.Key,
                      Price = g.Average(x => x.UnitPrice)
                  });
            var r18 = ListGenerators.ProductList
                   .Select(p => p.Category).Distinct();

            var r19 = ListGenerators.ProductList.Select(p => p.ProductName[0]).Union(
        ListGenerators.CustomerList.Select(c => c.CustomerName[0])).Distinct();
            var r20 = ListGenerators.ProductList.Select(p => p.ProductName[0]).Intersect(
        ListGenerators.CustomerList.Select(c => c.CustomerName[0]));
            var r21 = ListGenerators.ProductList
        .Select(p => p.ProductName[^3..]).Concat(ListGenerators.CustomerList.Select(c => c.CustomerName[^3..]));

            var r22 = ListGenerators.CustomerList.Where(c => c.Region == "WA").SelectMany(c => c.Orders).Take(3);
            var r23 = ListGenerators.CustomerList.Where(c => c.Region == "WA").SelectMany(c => c.Orders).Skip(2);
            int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var r25 = arr.TakeWhile((num, index) => num >= index);
            var r26 = arr.SkipWhile(n => n % 3 != 0);
            var r27 = arr.SkipWhile((num, index) => num >= index);
            var r28 = arr2.Any(w => w.Contains("ei"));
            var r29 = ListGenerators.ProductList.GroupBy(p => p.Category).Where(g => g.Any(p => p.UnitsInStock == 0));
            var r30 = ListGenerators.ProductList.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock > 0));

            List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var r31 = numbers.GroupBy(n => n % 5);

            foreach (var group in r31)
            {
                Console.WriteLine($"Remainder {group.Key}:");
                foreach (var num in group)
                    Console.WriteLine($"{num}");
            }
            var r32 = arr2.GroupBy(w => w[0]);
            string[] arr3 = { "from", "salt", "earn", "last", "near", "form" };

            var r33 = arr3.GroupBy(w =>
            {
                char[] chars = w.ToCharArray();
                Array.Sort(chars);
                return new string(chars);
            });


            var r34 = ListGenerators.ProductList.Select(p => p.ProductName);
            string[] arr4 = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var r35 = arr4.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
            var r36 = ListGenerators.ProductList.Select(p => new { p.ProductName, Price = p.UnitPrice, p.Category });
            var r37 = Arr1.Select((value, index) => new { Index = index, Value = value, IsMatch = value == index });

            //foreach (var rr in r23)
            //Console.WriteLine(rr);
        }
    }
}
