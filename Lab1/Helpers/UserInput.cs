
using Lab1.Models;

namespace Lab1.Helpers
{
    public class UserInput
    {
        public void GetUserInput(string input, Room room, out bool redoLoop)
        {
            double validNumber;

            redoLoop = false;

            Console.WriteLine($"Enter the {input}:");

            if (!double.TryParse(Console.ReadLine(), out validNumber) ||
                validNumber <= 0)
            {
                Console.WriteLine("Enter a valid number greater than 0.");
                redoLoop = true;
            }

            else if (input == "width")
            {
                room.roomWidth = validNumber;
            }
            else if (input == "length")
            {
                room.roomLength = validNumber;
            }
            else
            {
                room.roomHeight = validNumber;
            }

        }

    }

}
