


using interface_abstract_class;
class Program {

    static void Main(string[] args)
    {
        Dog dog = new Dog();
        Console.Write("Enter a dog name: ");
        dog.Name = Console.ReadLine();


        Console.Write("Enter dog colour: ");
        dog.Colour = Console.ReadLine();

        Console.Write("Enter dog age: ");
        dog.Age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Dog name: {dog.Name}");
        Console.WriteLine($"Dog color: {dog.Colour}");
        Console.WriteLine($"Dog age: {dog.Age}");
        dog.Eat();

        Cat cat = new Cat();
        Console.Write("Enter a cat name: ");
        cat.Name = Console.ReadLine();


        Console.Write("Enter cat colour: ");
        cat.Colour = Console.ReadLine();

        Console.Write("Enter cat age: ");
        cat.Age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Cat name: {cat.Name}");
        Console.WriteLine($"Cat color: {cat.Colour}");
        Console.WriteLine($"Cat age: {cat.Age}");
        cat.Eat();
    }
}