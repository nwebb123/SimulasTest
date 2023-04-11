/*
- Define an enumeration for the state of the chest 

- Make a variable whose type is this new enumeration

-Write code that allows the user to manipulate the chest with lock, unlock, open, and close commands.
**Ensure that the user cannot transition between states that don't support it
 
- Loop forever, asking for the next command
 
*/

using SimulasTest;

Console.WriteLine("*****  Simula's Test  *****\n");


//Initialize state of chest
string userInput = "";
ChestState simulasChest = ChestState.Locked;
Console.WriteLine("A locked chest lies before you. You can manipulate the state of the chest by performing the following actions: \nopen, close, lock, unlock.\n");


Console.Write("\nThe chest is locked. What do you want to do? ");

while (userInput != "Exit")
{
    userInput = Console.ReadLine(); //User should say unlock.
                                    //If user says closed, locked, or open, warning should ask user to try another action.

    //If Chest is Locked
    if (simulasChest == ChestState.Locked && userInput == "unlock")
    {
        simulasChest = ChestState.Unlocked;
        Console.WriteLine("\nThe chest is unlocked. What do you want to do? ");
    }


    //If Chest is unlocked
    else if (simulasChest == ChestState.Unlocked && userInput == "open")
    {
        simulasChest = ChestState.Open;
        Console.WriteLine("\nThe chest is open, the treasure is yours!");
    }
    else if (simulasChest == ChestState.Unlocked && userInput == "lock")
    {
        simulasChest = ChestState.Locked;
        Console.WriteLine("\nThe chest is locked. What do you want to do?");
    }
    //else
    //{
    //    Console.WriteLine("\nHmm, that didn't work. Try a different action:  ");
    //}

    //If Chest is open
    else if (simulasChest == ChestState.Open && userInput == "close")
    {
        simulasChest = ChestState.Closed;
        Console.WriteLine("\nThe chest is closed. What do you want to do? ");
    }
    else if (simulasChest == ChestState.Unlocked && userInput == "lock")
    {
        simulasChest = ChestState.Locked;
        Console.WriteLine("\nThe chest is locked. What do you want to do? ");
    }

    //If Chest is closed
    else if (simulasChest == ChestState.Closed && userInput == "lock")
    {
        simulasChest = ChestState.Locked;
        Console.WriteLine("\nThe chest locked back up. What do you want to do? ");
    }
    else if (simulasChest == ChestState.Closed && userInput == "open")
    {
        simulasChest = ChestState.Locked;
        Console.WriteLine("\nThe chest is open. What do you want to do? ");
    }
    else
    {
        Console.WriteLine("\nHmm, that didn't work. Try a different action:  ");
    }
 
}


Console.WriteLine("\nThank you! Visit again.");
Console.ReadKey();

//static int ValidateUserInput(string input)
//{
//    int result;

//    /*  
//        TryParse is .NET C# method that allows you to try and parse a string into a specified type.
//        It returns a boolean value indicating whether the conversion was successful or not.
//        If conversion succeeded, the method will return true and the converted value will be assigned to the output parameter.
//    */

//    if (!int.TryParse(input, out result))
//    {
//        return -999;
//    }
//    else
//    {
//        return result;
//    }
//}


