// using UnityEngine;

// public class Row : MonoBehaviour
// {
//     public Tile[] tiles { get; private set; }
//     private bool isSubmitted;
//     private int presentCount;
//     private int correctCount;

//     // checks for repeating numbers, true if the digit exists, false if it doesn't.
//     public bool ContainsNumber(char )
//     {
//         foreach (Tile tile in tiles)
//         {
//             if (tile.number == number)
//             {
//                 digitCount++;
//                 return true;
//             }
//         }
//         return false;
//     }

//     public bool IsFull()
//     {
//         foreach (Tile tile in tiles)
//         {
//             if (tile.number == 0)
//             {
//                 Debug.Log("Row is not full");
//                 return false;
//             }
//             return true;
//             // if guessed number == hidden number
//             // { reveal hidden number, wait for 3 seconds, EndGamePanel.isVisible(true)}
//         }
//     }

//     public char[] GetGuess()
//     {

//     }

//     public void SetFeedback(int presentCount, int correctCount)
//     {

//     }

//     public bool ClearLastDigit()
//     {

//     }
// }