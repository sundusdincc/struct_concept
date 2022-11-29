internal class Program
{
    private static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        rectangle.ShortEdge = 3;
        rectangle.LongEdge = 4;
        Console.WriteLine("Class alan hesabı: {0} ", rectangle.Area());

        Rectangle_Struct rectangle_struct = new Rectangle_Struct();
        rectangle_struct.ShortEdge = 3;
        rectangle_struct.LongEdge = 4;
        Console.WriteLine("Struct alan hesabı: {0} ", rectangle_struct.Area());

        Rectangle_Struct rectangle_struct1;
        rectangle_struct1.ShortEdge = 3;
        rectangle_struct1.LongEdge = 4;
        Console.WriteLine("Struct alan hesabı: {0} ", rectangle_struct1.Area());

        Rectangle_Struct rectangle_struct2 = new Rectangle_Struct(5,7);
        Console.WriteLine("Struct alan hesabı: {0} ", rectangle_struct2.Area());

        Person p1;
        p1.Name = "Raman";
        p1.Age = 12;

        p1.A1.City = "ABC_City";
        p1.A1.State = "XYZ_State";

        Console.WriteLine("\nValues Stored in p1");
        Console.WriteLine("Name: " + p1.Name);
        Console.WriteLine("Age: " +p1.Age);
        Console.WriteLine("City: " +p1.A1.City);
        Console.WriteLine("State: " +p1.A1.State);

        Car c1;
        c1.Brand = "Bugatti";
        c1.Model = "Bugatti Veyron EB 16.4";
        c1.Color = "Gray";

        Console.WriteLine("\nName of brand: " + c1.Brand + 
                          "\nModel name: " + c1.Model + 
                          "\nColor of car: " + c1.Color);
    }
}

class Rectangle
{
    public int ShortEdge;
    public int LongEdge;

    public long Area()
    {
        return this.ShortEdge * this.LongEdge;
    }
}

struct Rectangle_Struct
{
    public int ShortEdge;
    public int LongEdge;

    public Rectangle_Struct(int shortEdge, int longEdge)
    {
        ShortEdge = shortEdge;
        LongEdge = longEdge;
    }



    public long Area()
    {
        return this.ShortEdge * this.LongEdge;
    }
}

public struct Address
{
     
    // data member of Address structure
    public string City;
    public string State;
}
 
 
// Another structure
struct Person
{
     
    // data member of Person structure
    public string Name;
    public int Age;
     
    // Nesting of Address structure
    // by creating A1 of type Address
    public Address A1;
}

public struct Car
{
  
    // Declaring different data types
    public string Brand;
    public string Model;
    public string Color;
}