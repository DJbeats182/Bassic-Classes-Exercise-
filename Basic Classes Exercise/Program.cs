namespace Basic_Classes_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Tesla";
            myCar.Model = "Model X";
            myCar.Year = 2023;

            var myCar2 = new Car()
            {
                Make = "Honda",
                Model = "Civic",
                Year = 2020,
            };

            Car myCar3 = new Car() {Make= "Audi", Model= "R8", Year= 2022 };

            var carList = new List<Car>() { myCar, myCar2, myCar3 };

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make}-{vehicle.Model}-{vehicle.Year}");
            }
        }
    }
}