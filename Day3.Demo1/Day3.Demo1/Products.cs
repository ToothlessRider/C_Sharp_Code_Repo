using System;
using System.Collections.Generic;
using System.Linq;

namespace Day3.Demo1
{
    internal class Products
    {
        int ProductId;
        string ProductName;
        double Price;
        string AvailabilityLocation;
        string FeedBack;

        List<Products> ProductList;

        public void StoreProducts()
        {
            ProductList = new List<Products>()
            {
                new Products(){ ProductId = 100, ProductName = "Mogu Mogu", Price = 70.00, AvailabilityLocation = "PUNE", FeedBack = "Best drink ever"},
                new Products(){ProductId = 101, ProductName = "Redbull", Price = 125, AvailabilityLocation = "BLR", FeedBack = "Pricey but gives you wings"},
                new Products(){ProductId = 102, ProductName = "Monster", Price=180.00,AvailabilityLocation = "DEL", FeedBack = "Expensive but efficiency boost"},
                new Products(){ProductId = 103, ProductName = "Sting", Price = 25.00, AvailabilityLocation = "DEL", FeedBack = "Cheap efficiency boost with side effect"},
                new Products(){ProductId = 104, ProductName = "Amul Cool Milkshake", Price = 30.00, AvailabilityLocation = "BLR" , FeedBack = "Just a chill drink"}
            };

            // Query for full products
            var Query = from p in ProductList
                        where p.Price > 100
                        orderby p.ProductName
                        select p;
            
            //Console.WriteLine("Products with price > 100:\n");
            //PrintProducts(Query);


            // Query for selected fields (anonymous type)
            var custQuery = from p in ProductList
                            where p.Price > 100
                            orderby p.ProductName
                            select new { p.Price, p.ProductName, p.FeedBack };


            //Console.WriteLine("\nCustom Query Output:");
            //PrintProducts(custQuery);

            var groupQuery = from p in ProductList
                             group p by p.AvailabilityLocation into productGroup
                             select new
                             {
                                 // This is a pre defined option that will let you get the information of the groups
                                 productGroup.Key, // This will elect location
                                 Names = productGroup.Select(p => p.ProductName),
                                 // This is a lambda expression. names is an Alias
                             };
            
            //Console.WriteLine("\nCustom Group By Query: ");
            //PrintGroupedProducts(groupQuery);

            Console.WriteLine("\n==========");
            var LambdaQuery = ProductList.Where(p => p.Price > 100).
                OrderBy(p => p.ProductName).
                Select(p => new 
                { 
                    p.ProductName, p.Price 
                });
            
            PrintProducts(LambdaQuery);

            var LambdaQuery2 = ProductList.GroupBy(p => p.AvailabilityLocation).
                Select(g => new 
                { 
                    AvailabilityLocation = g.Key, 
                    Products = g.Select(p => new 
                    { 
                        // This is to select the specific values that are to be displayed
                        p.ProductName, 
                        p.Price 
                    }) 
                });


            Console.WriteLine("\n=====");

            foreach (var product in LambdaQuery2)
            {
                Console.WriteLine($"Availabile Location: {product.AvailabilityLocation}");
                foreach (var x in product.Products)
                {
                    Console.WriteLine($"ProductName: {x.ProductName}, Price: {x.Price}");
                }
            }

            Console.WriteLine("\n===== Lambda Group ======");

            var lambdaQuery3 = ProductList.GroupBy(p => p.AvailabilityLocation).
                Select(g => new
                    {
                        g.Key, 
                        Names = g.Select(p => p.ProductName),
                        totalAmount = g.Sum(p => p.Price),
                        MaxAmount = g.Max(p => p.Price)
                    });
            
            foreach (var item in lambdaQuery3)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine("Product Names: " + string.Join(", ", item.Names));
                Console.WriteLine(item.totalAmount);
                Console.WriteLine(item.MaxAmount);
            }
            Console.WriteLine("\n=====Element Operators===========");
            Console.WriteLine("\n=====First or Default===========");

            //First or Default can handle null values, but if you try and further access the Null values properties (firstOrDefaultQuery.ProductName) then it'll throw an err
            var firstOrDefaultQuery = (from p in ProductList where p.ProductId == 10 select p).FirstOrDefault();
            //Console.WriteLine("{0} \t{1}",firstOrDefaultQuery.ProductName,firstOrDefaultQuery.Price);
            Console.WriteLine("First Or Default: \t ",firstOrDefaultQuery);

            var firstQuery = (from p in ProductList where p.ProductId == 100 select p).First();
            Console.WriteLine("{0} \t{1}", firstQuery.ProductName, firstQuery.Price);

            Console.WriteLine("\n=====Single or Default===========");

            //First or Default can handle null values, but if you try and further access the Null values properties (firstOrDefaultQuery.ProductName) then it'll throw an err
            var singleOrDefaultQuery = (from p in ProductList where p.ProductId == 100 select p).SingleOrDefault();
            Console.WriteLine("{0} \t{1}",singleOrDefaultQuery.ProductName,singleOrDefaultQuery.Price);
            //Console.WriteLine("Single Or Default: \t ", singleOrDefaultQuery);

            var singleQuery = (from p in ProductList where p.ProductId == 100 select p).Single();
            Console.WriteLine("{0} \t{1}", singleQuery.ProductName, singleQuery.Price);

            Console.WriteLine("\n=====Partition Operators===========");
            Console.WriteLine("\n=====Take() Operator=======");
            var takeQuery = ProductList.Select(p => new
            {
                p.ProductId,
                p.ProductName,
                p.Price
            }).Take(2);

            PrintProducts(takeQuery);
            Console.WriteLine("\n=====TakeWhile() Operator=======");

            var takeWhileQuery = ProductList.Select(p => new 
            { 
                p.ProductName,
                p.Price,
                p.AvailabilityLocation
            }).TakeWhile(n => n.Price > 60);
            // It keeps taking products from the first one (which also has to satisfy the condition) till it reaches one who's price is lesser than 60

            PrintProducts(takeWhileQuery);

            Console.WriteLine("\n=====Al, Any() Methods===========");

            Console.WriteLine("\n=====All and Any Methods===========");


            bool allExpensive = ProductList.All(p => p.Price > 20); // Check if all are priced above 20
            Console.WriteLine("All products priced above 20: " + allExpensive);

            bool anyCheap = ProductList.Any(p => p.Price < 30); 
            // Are there any priced below 30 (No, sting is super cheap, but not that cheap)
            Console.WriteLine("Any product priced below 30: " + anyCheap);

            Console.WriteLine("\n=====Set Operators===========");

            // Let's say we have two product lists for demo
            var ProductList2 = new List<Products>()
                {
                    new Products(){ ProductId = 105, ProductName = "Sprite", Price=40, AvailabilityLocation="BLR", FeedBack="Refreshing"},
                    new Products(){ ProductId = 101, ProductName = "Redbull", Price=125, AvailabilityLocation="BLR", FeedBack="Pricey but gives you wings"},
                    new Products(){ ProductId = 106, ProductName = "Pepsi", Price=50, AvailabilityLocation="PUNE", FeedBack="Classic, but it's a toilet cleaner"}
                };

            // Gives a list of unique products in both the lists
            var distinctProducts = ProductList.Select(p => new 
            { 
                p.ProductId, 
                p.ProductName 
            }).Union(ProductList2.Select(p => new 
            { 
                p.ProductId, 
                p.ProductName 
            }));

            Console.WriteLine("Union of ProductLists (distinct by ID/Name):");
            PrintProducts(distinctProducts);

            // Checking whch products exist in both the lists (Basic intersection concepts from 10th)
            var intersectProducts = ProductList.Select(p => new 
            { 
                p.ProductId, 
                p.ProductName 
            }).Intersect(ProductList2.Select(p => new 
            { 
                p.ProductId, 
                p.ProductName 
            }));

            Console.WriteLine("\nCommon products in both lists:");
            PrintProducts(intersectProducts);

            // Except (products that exist in the first list but not in the second)
            var exceptProducts = ProductList.Select(p => new 
            {
                p.ProductId, 
                p.ProductName 
            }).Except(ProductList2.Select(p => new 
            { 
                p.ProductId, 
                p.ProductName 
            }));

            Console.WriteLine("\nProducts only in first list:");
            PrintProducts(exceptProducts);

            Console.WriteLine("\n=====Stack, Queue, SortedDictionary===========");

            Stack<string> productStack = new Stack<string>();
            productStack.Push("Mogu Mogu");
            productStack.Push("Redbull");
            productStack.Push("Monster");

            Console.WriteLine("\nStack (LIFO) - Pop elements:");
            while (productStack.Count > 0)
            {
                Console.WriteLine(productStack.Pop());
            }

         

        }

        public void PrintProducts<T>(IEnumerable<T> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        public void PrintGroupedProducts(IEnumerable<dynamic> groupedProducts)
        {
            foreach (var group in groupedProducts)
            {
                Console.WriteLine($"Location: {0}", group.Key);
                Console.WriteLine("Products: " + string.Join(", ", group.Names));
                Console.WriteLine("---------------------------");
            }
        }

    }
}
