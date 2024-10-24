using UpcastingDowncasting;

Fruit[] basket = new Fruit[]
       {
            new Apple() { Price = 0.8, Sort = "Quba almasi", VitaminA = 4, VitaminB = 2 },
            new Orange() { Price = 3.2, Sort = "Naringi", VitaminC = 15 },
            new Pineapple() { Price = 3.0, Sort = "evde ilde bir defe gorunen ananas", VitaminD = 17 ,VitaminE=11}
       };

foreach (var fruit in basket)
{
    if (fruit is Apple apple)
    {
        Console.WriteLine("\nMeyve: Apple");
        Console.WriteLine($"Price: {apple.Price}\n sort:{apple.Sort}\n Vitamin A deyeri: {apple.VitaminA}\n vitamin B deyeri:{apple.VitaminB}");

    }
    else if (fruit is Orange orange)
    {
        Console.WriteLine($"\nMeyve : Orange \n Price: {orange.Price}\n  Sort: {orange.Sort}\n  Vitamin C deyeri: {orange.VitaminC}");

    }
    else if (fruit is Pineapple pineapple)
    {
        Console.WriteLine($"\nMeyve: Pineapple  Price: {pineapple.Price}\n   Sort: {pineapple.Sort}\n     Vitamin D deyeri: {pineapple.VitaminD}\n   Vitamin E deyeri: {pineapple.VitaminE}");

    }
    else
    {
        Console.WriteLine("Naməlum meyvə növü.");
    }
}
