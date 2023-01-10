// See https://aka.ms/new-console-template for more information

//initializing the bool value goagain to repeat the process at the end
bool goagain = false;
//asking the user to input thier information to refer to them by name in the program
Console.WriteLine("Please type in your name ");
string username = Console.ReadLine();
Console.WriteLine("Thank you " + username+ " for writing your name!");
do
{
    //promting the user to input a number between 1-100 and storing it as the variable userinput
    Console.WriteLine("Please enter a integer ranging from 1-100 (inclusive)");
    int userinput = int.Parse(Console.ReadLine());
    if (userinput > 100 || userinput < 0)
    {
        Console.WriteLine("Unfortunetly " + username + ", your input is invalid please exit the program and try again");
        break;
    //reittereating the user input for clarity
    Console.WriteLine(username + " you have entered " + userinput + ".");
        //using if statments to test the userinput and see if it satisys any of the parameters
        if (userinput % 2 != 0 && userinput < 60)
        {
            Console.WriteLine(username + " your number, " + userinput + " is odd and less than 60");
        }
        if (userinput % 2 == 0 && userinput <= 24 && userinput >= 2)
        {
            Console.WriteLine(username + " your number, " + userinput + " is even and between the values of 2 and 24 (inclusive)");
        }
        if (userinput % 2 == 0 && userinput <= 60 && userinput >= 26)
        {
            Console.WriteLine(username + " your number, " + userinput + " is even and between the values of 26 and 60 (inclusive)");
        }
        if (userinput % 2 == 0 && userinput > 60)
        {
            Console.WriteLine(username + " your number, " + userinput + " is even and greater than 60");
        }
        if (userinput % 2 != 0 && userinput > 60)
        {
            Console.WriteLine(username + " your number, " + userinput + " is odd and greater than 60");
        }
        Console.WriteLine("Would you like to repeat the process? y/n");
        string answer = Console.ReadLine();
        if (answer == "y")
        {
            goagain = true;
        }
        else
        {
            goagain = false;
        }
    }
} while (goagain == true);