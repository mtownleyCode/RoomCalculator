using Lab1.Models;

namespace Lab1.Helpers
{
    public class Calculations
    {
        public double GetPerimeter(Room room) => (room.roomWidth * 2) + (room.roomLength * 2);

        public double GetArea(Room room)
        {
            room.roomSquareFeet = room.roomWidth * room.roomLength;
            return room.roomSquareFeet;

        }

        public double GetSurfaceArea(Room room) => (2 * (room.roomWidth * room.roomHeight)) +
                                                   (2 * (room.roomLength * room.roomHeight)) +
                                                   (2 * (room.roomWidth * room.roomLength));

        public double GetVolume(Room room) => (room.roomWidth * room.roomLength * room.roomHeight);

        public string DetermineSizeMessage(Room room)
        {
            string displayMessage = "";

            switch (room.roomSquareFeet <= 250 ? "small" :
                    room.roomSquareFeet > 250 && room.roomSquareFeet < 650 ? "medium" : 
                    "large")
            {
                case "small":
                    room.roomSize = "small";
                    displayMessage = "Your room is small.";
                    break;
                case "medium":
                    room.roomSize = "medium";
                    displayMessage = "Your room is medium sized.";
                    break;
                case "large":
                    room.roomSize = "large";
                    displayMessage = "You have a large room.";
                    break;
            }

            return displayMessage;

        }

    }

}
