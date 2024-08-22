// See https://aka.ms/new-console-template for more information

try
{
    Console.Write("Enter an integer: ");
    int number = Convert.ToInt16(Console.ReadLine());

}
catch (FormatException ex)
{
    Console.WriteLine("Input is not an integer");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    
}