using Lab1.Helpers;
using Lab1.Models;

List<string> values = new List<string>();
values.Add("width");
values.Add("length");
values.Add("height");


Room newRoom = new Room();
UserInput userInput = new UserInput();
Calculations calculations = new Calculations();

Console.WriteLine("Welcome to the Room Calculator App.");
Console.WriteLine();

for (int i = 0; i <= values.Count - 1; i++)
{
    userInput.GetUserInput(values[i], newRoom, out bool redoLoop);

    if (redoLoop) { i--; }
}

Console.WriteLine();

Console.WriteLine($"The perimeter of your room is: { calculations.GetPerimeter(newRoom).ToString() } linear feet");
Console.WriteLine($"The area of your room is: { calculations.GetArea(newRoom).ToString() } square feet");

Console.WriteLine();

Console.WriteLine(calculations.DetermineSizeMessage(newRoom));

Console.WriteLine();

Console.WriteLine("Some additional information about your room...");

Console.WriteLine();

Console.WriteLine($"The volume of your room is: { calculations.GetVolume(newRoom).ToString() } square feet");
Console.WriteLine($"The surface of your room is: { calculations.GetSurfaceArea(newRoom).ToString() } square feet");