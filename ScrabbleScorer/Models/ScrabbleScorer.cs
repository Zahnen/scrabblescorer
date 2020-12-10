using System;
using System.Collections.Generic;


namespace Scrabble.Models
{
  public class Word
  {
    //Field or maybe a property? idk
    public string UWord {get; set;}//auto implemented property

    //Constructor
    public Word(string uWord) // Constructor creates object,
    {
      UWord = uWord;  
    }

    public char[] IntoArray(string uWord)
    {
      char[] letters = uWord.ToCharArray();
      return letters;
    }

    public static Dictionary<string, int> letterScore = new Dictionary<string, int>() { {"a", 1}, {"b", 3}, {"c", 3}, {"d", 2}, {"e", 1}, {"f", 4},{"g", 2}, {"h", 4},{"i", 1}, {"j", 8}, {"k", 5}, {"l", 1}, {"m", 3}, {"n", 1}, {"o", 1}, {"p", 3}, {"q", 10}, {"r", 1}, {"s", 1}, {"t", 1}, {"u", 1}, {"v", 4}, {"w", 4}, {"x", 8}, {"y", 4}, {"z", 10} };
  }
} 

// namespace Palindromes
// {
//   public class Words
//   {
//     public string TurnIntoArray(string word)
//     {
//       char[] letters = word.ToCharArray();
//       Array.Reverse(letters);
//       string reversedWord = new String(letters);
//       return reversedWord;
//     }
//   }
// }


// namespace RPS.Models
// {
//   public class Round
//   {
//     public string Hand1 { get; }
//     public string Hand2 { get; }
//     public Round(string hand1, string hand2)
//     {
//       Hand1 = hand1;
//       Hand2 = hand2;
//     }

//     public bool GetWinner(string hand1, string hand2)
//     {
//       if (hand1 == "rock" && hand2 == "scissors" || hand1 == "paper" && hand2 == "rock" || hand1 == "scissors" && hand2 == "paper")
//       {
//         return true;
//       }
//       else
//       {
//         return false;
//       }
//     }
//   }
// }