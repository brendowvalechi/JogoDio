using JogoDio.Entities;

class Program
{
    static void Main (string[] args)
    {
        Knight knight = new Knight ("Arus", 23, "Knight");
        Wizard wizard = new Wizard ("Jennica", 23, "White Wizard");
        Ninja ninja = new Ninja("Wedee", 23, "Ninja");
        BlackWizard blackWizard = new BlackWizard("Maleficus", 23, "Black Wizard");


        Console.WriteLine(knight.Attack());
        Console.WriteLine (wizard.Attack(20));
        Console.WriteLine (ninja.Attack(7));
        Console.WriteLine(blackWizard.Attack(5));
    }
}