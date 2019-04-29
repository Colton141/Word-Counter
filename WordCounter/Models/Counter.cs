using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Counter
  {
    // private string _word;
    public bool IsWord(string word)
    {
    return true;
    }
    public bool DoesContain(string word, string sentence)
    {
      string[] sentenceArray = sentence.Split(" ");
      string[] wordArray = word.Split(" ");
      // for (int i = 0; i <= SentenceArray.Length - 1; i++)
      {
        string[] value =  Array.FindAll(sentenceArray, s => s.Equals(wordArray));
          if (value.Length == 1)
          {
            return true;
          }
          return false;
        }

      }
    }
  }
