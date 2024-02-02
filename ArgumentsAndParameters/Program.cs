
Console.WriteLine("Enter a word");
string userWord = Console.ReadLine();

PrintAnyWord(userWord);//lubadus täitud userWord - argument

static void PrintAnyWord(string anyString) //anyString - parameter
{
    anyString = anyString.ToUpper();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}