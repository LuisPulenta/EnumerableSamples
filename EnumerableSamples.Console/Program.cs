using EnumerableSamples.Console;

Console.WriteLine("-----------");
Console.WriteLine("Enumerables");
Console.WriteLine("-----------");

#region List
//Console.WriteLine("-----------");
//Console.WriteLine("  List<T>  ");
//Console.WriteLine("-----------");

//var products = new List<Product>
//{
//    new Product{Id=1,Name="Coca Cola",Price=2.15M},
//    new Product{Id=2,Name="Leche",Price=5.58M},
//    new Product{Id=3,Name="IPhone",Price=354.99M},
//    new Product{Id=4,Name="IWatch",Price=121.99M},
//};

//Console.WriteLine($"{products.Count} products");
//Console.WriteLine("---- ForEach ----");
//foreach (var product in products)
//{
//    Console.WriteLine(product);
//}
//Console.WriteLine("---- For ----");

//for (int i = 0; i < products.Count; i++)
//{
//    Console.WriteLine(products[i]);
//}
//Console.WriteLine("-----------");

//Console.WriteLine("---- Sort ----");
//products = products.OrderBy(p => p.Price).ToList();
//for (int i = 0; i < products.Count; i++)
//{
//    Console.WriteLine(products[i]);
//}
//Console.WriteLine("-----------");

#endregion

#region Dictionary1
//Console.WriteLine("-------------------------------");
//Console.WriteLine("  Dictionary<TKey, TValue>  ");
//Console.WriteLine("-------------------------------");

//var fruits = new Dictionary<string, int>
//{
//    { "Manzanas", 10 },
//    { "Peras", 12 },
//    { "Sandias", 7 },
//    { "Uvas", 30 },
//    { "Aguacates", 12 },
//    { "Kiwis", 4 }
//};

//foreach (var fruit in fruits)
//{
//    Console.WriteLine($"{fruit.Key} => {fruit.Value}");
//}

//if (fruits.ContainsKey("Kiwis"))
//{
//    fruits["Kiwis"] += 20;
//}
//else
//{
//    fruits.Add("Kiwis", 20);
//}
//Console.WriteLine("-------------------------------");
//foreach (var fruit in fruits)
//{
//    Console.WriteLine($"{fruit.Key} => {fruit.Value}");
//}
#endregion

#region Dictionary2
//Console.WriteLine("-------------------------------");
//Console.WriteLine("  Dictionary<TKey, TValue>  ");
//Console.WriteLine("-------------------------------");

//var products = new Dictionary<int, Product>
//{
//    { 1, new Product{Id=1,Name="Coca Cola",Price=2.15M} },
//    { 2, new Product{Id=2,Name="Leche",Price=5.58M} },
//    { 3, new Product{Id=3,Name="IPhone",Price=354.99M} },
//    { 4, new Product{Id=4,Name="IWatch",Price=121.99M} },

//};



//foreach (var product in products)
//{
//    Console.WriteLine($"{product.Key} => {product.Value}");
//}

//if (products.ContainsKey(5))
//{
//    products[5].Price *= 1.10M;
//}
//else
//{
//    products.Add(5, new Product { Id = 5, Name = "Camisa", Price = 33.33M });
//}
//Console.WriteLine("-------------------------------");

//foreach (var product in products)
//{
//    Console.WriteLine($"{product.Key} => {product}");
//}
#endregion

#region LinkedList
Console.WriteLine("------------");
Console.WriteLine("Linked Lists");
Console.WriteLine("------------");

var numbers = new LinkedList<int>();

numbers.AddFirst(5);
numbers.AddLast(10);
numbers.AddLast(20);
numbers.AddLast(30);
numbers.AddLast(40);
numbers.AddLast(50);
numbers.AddLast(60);
numbers.AddLast(65);

foreach (var number in numbers)
{
    Console.WriteLine(number);
}
Console.WriteLine("------------");

var node30 = numbers.Find(30);
numbers.AddAfter(node30!, 35);

var node50 = numbers.Find(50);
numbers.Remove(node50!);

var pointer = numbers.Last;
while (pointer != null){
    Console.WriteLine(pointer.Value);
    pointer = pointer.Previous;
}

Console.WriteLine("------------");
var pointer2 = numbers.First;
while (pointer2 != null)
{
    Console.WriteLine(pointer2.Value);
    pointer2 = pointer2.Next;
}

#endregion