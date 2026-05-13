// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
public  abstract class Vehicle{
    public IDrive obj;
    public Vehicle(){
        
    }
    public Vehicle(IDrive d){
        obj = d;
    }
    public void Drive(){
        obj.Drive();
    }
}
public class Sporty : Vehicle{
    public Sporty() : base(new SportyDrive()){
        
    }
}
public class Passenger : Vehicle{
    public Passenger() : base(new NormalDrive()){
        
    }
}
public class OffRoad : Vehicle{
   public OffRoad() : base(new SportyDrive()){
        
    }
}
public interface IDrive{
    void Drive();
}
public class SportyDrive : IDrive{
    public void Drive(){
        Console.WriteLine("Sportyyyyyyy");
    }
}
public class NormalDrive : IDrive{
    public void Drive(){
        Console.WriteLine("Normallllll");
    }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Vehicle v = new Sporty();
        v.Drive();
        Vehicle u = new Passenger();
        u.Drive();
    }
}
