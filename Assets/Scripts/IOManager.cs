// using UnityEngine;
// using UnityEngine.InputSystem;

// public class IOManager : MonoBehaviour
// {
//     private Row[] rows;
//     private int currentRowIndex;
//     private int currentColumnIndex;
//     private char[] hiddenNumber;
//     private int maxAttempts; // ???????
//     private ButtonManager buttonManager;

//     public void HandleNumberInput(char inputNumber)
//     {
//         if (currentColumnIndex < rows[currentRowIndex].tiles.Length)
//         {
//             rows[currentRowIndex].tiles[currentColumnIndex].SetNumber(button);
//             currentColumnIndex++;
//         }
//     }

//     public void HandleSubmit()
//     {

//     }

//     public void HandleDelete()
//     {

//     }

//     public void GenerateHiddenNumber()
//     {
//         // no duplicates 
//         Random rnd = new Random();
//         for (char i = 0; i < 4; i++)
//         {
//             char temp = 0;
//             temp = rnd.Next(0, 9);
//             hiddenNumber[i] = temp;
//         }
//     }

//     public int CompareGuess(char[] uhhh)
//     {

//     }
// }