namespace HwS12;

class Program
{
    static void Main(string[] args)
    {
        Imachine[]vehicles=new Imachine[]{
            new Bicycle("Hammer","Blue"),
            new Machine("BMW","White"),
            new Bus("Volvo","Black"),
            new Motorcycle("Beneli","Red")
        };
        int sum_capacity=0;
        int sum_wheels=0;
        foreach(var vehicle in vehicles){
            sum_capacity+=vehicle.capacity();
            sum_wheels+=vehicle.count_wheels();
            if(vehicle.fuel()=="Renewable Fuel")
            {
                System.Console.WriteLine($"{vehicle.model()} doesnt hurt the enviroment!");
            }
            else{
                System.Console.WriteLine($"{vehicle.model()} hurts the enviroment!");
            }
        }

        System.Console.WriteLine(sum_capacity);
        System.Console.WriteLine(sum_wheels);

    }
}
