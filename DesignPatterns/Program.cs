using DesignPatterns.CreationalPatterns;
using System;
class Program
{
    public static void Main(string[] args)
    {
        SingleTonPattern s=new SingleTonPattern();
        s.PrintDetails("This is my first Object Creation");
        //s.PrintDetails("This is my second");
        SingleTonPattern employee = new SingleTonPattern();
        s.PrintDetails("Employee Object");
        

    }
    
}