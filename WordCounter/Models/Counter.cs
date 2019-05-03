using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Counter
  {
    private string _word;
    private string _phrase;
    private string[] _splitPhrase;

    public counter(string Word, string Phrase)
    {
    _word = Word;
    _phrase = Phrase;
    _splitPhrase = phrase.Split(" ");

    }
    public bool DoesContain()
    {

      for (int i = 0; i <= _splitPhrase.Length; i++)
      {
        string newSentence = String.Join("", _splitPhrase[i]);
        if (newSentence == _word)
        {
          return true;
        }
      }
      return false;
    }
      public int CountContains()
      {
        int count = 0;
        for (int i = 0; i <= _splitPhrase.Length - 1; i++)
        {
          string newSentence = String.Join("", _splitPhrase[i]);
          if (newSentence == _word)
          {
            count += 1;
            } else if (newSentence == (_word + "."))
            {
              count += 1;
            } else if (newSentence == (_word + "!"))
            {
              count += 1;
            } else if (newSentence == (_word + "?"))
            {
              count += 1;
            } else if (newSentence == (_word + ","))
            {
              count += 1;
            }

            }
            return count;
            }
    }
  }
