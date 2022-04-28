// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using Udemy.GameActions;

namespace Udemy //entrypoint to application
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var game = new SetField();
            // game.SetBoard();
            game.TakePlayerTurn();
        }
        
        
    }
};
// Console.WriteLine("      |      |      |");
// Console.WriteLine("   {0}  |   {1}  |   {2}  |", 1, 2, 3);
// Console.WriteLine("______|______|______|_____");
// Console.WriteLine("      |      |      |");
// Console.WriteLine("   {0}  |   {1}  |   {2}  |", 4, 5, 6);
// Console.WriteLine("______|______|______|_____");
// Console.WriteLine("      |      |      |");
// Console.WriteLine("   {0}  |   {1}  |   {2}  |",  7, 8, 9);
// Console.WriteLine("      |      |      |");

// Console.WriteLine("Enter value: ");
// string userInput = Console.ReadLine();
// char c = userInput[0];
// Console.WriteLine(Char.IsLetter(c));
//
// //declare a 2D Array
// int[,] matrix = new int[,]
// {
//     {1, 2, 3},
//     {4, 5, 6},
//     {7, 8, 9}
// };

//declare a 3D Array
// int[,,,] threeD;
//
// Console.WriteLine("central value is {0}", matrix[2,0]);

//outter for loop
// for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
// {
//     Console.Write(matrix[i, j] + " ");
//         //inner for loop
// }

// for (int k = 0; k < matrix.GetLength(0); k++)
// {
//     Console.Write(matrix[k,k] + " ");
// }

// for (int l = 0; l < matrix.GetLength(0); l++)
// {
//     for (int m = 0; m < matrix.GetLength(0); m++)
//     {
//         Console.Write(matrix[l,m] + " ");
//     }
// }


