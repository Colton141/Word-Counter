using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Counter
  {
    private string _word;
    private string _phrase;
    public bool IsWord(string word)
    {
    return true;
    }
    public bool DoesContain(string word, string sentence)
    {
      string[] sentenceArray = sentence.Split(" ");

      for (int i = 0; i <= sentenceArray.Length; i++)
      {
        string newSentence = String.Join("", sentenceArray[i]);
        if (newSentence == word)
        {
          return true;
        }
      }
      return false;
    }
      public int CountContains(string word, string sentence)
      {
        // char[] sentenceArray = sentence.ToCharArray();
        string[] sentenceArray = sentence.Split(" ");
        int count = 0;
        for (int i = 0; i <= sentenceArray.Length - 1; i++)
        {
          string newSentence = String.Join("", sentenceArray[i]);
          if (newSentence == word)
          {
            count += 1;
          } else if (newSentence == (word + "."))
          {
            count += 1;
        } else if (newSentence == (word + "!"))
        {
          count += 1;
        } else if ( newSentence == (word + "?"))
        {
          count += 1;
        }

        }
        return count;
      }
    }
  }
