namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Audi";
            myCar.Model = "R8";
            myCar.Year = 2020;

            //var carList = new List<car>();
            Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year}");

        }
    }
}
