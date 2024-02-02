
Console.WriteLine("Are you coming or leaving?");
string userChoice = Console.ReadLine();
if (userChoice == "coming" )
{
    PrintHello();
}
else
{
    PrintGoodBye();
}    
PrintHello();  
PrintGoodBye(); //ilma selleta static void ei tööta

static void PrintHello()  //function ehk method
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodBye ()
{
    Console.WriteLine("See you later, Katrin.");
}