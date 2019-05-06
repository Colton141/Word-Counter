using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class Counter
  {
    private string _word;
    private string _phrase;
    private string[] _splitPhrase;
    private int _count;

    public string Word {get=> _word; set=> _word = value;}
    public string Phrase {get=> _phrase; set=> _phrase = value;}
    public string[] SplitPhrase {get=> _splitPhrase; set=> _splitPhrase = value;}
    public int Count {get=> _count; set=> _count = value;}

    public Counter (string Word, string Phrase)
    {
    _word = Word;
    _phrase = Phrase;
    _splitPhrase = _phrase.Split(" ");
    _count = 0;
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
      public int WordCounter()
      {
        int count = 0;
        for (int i = 0; i <= _splitPhrase.Length - 1; i++)
        {
          string newSentence = String.Join("", _splitPhrase[i]).ToLower();
          if (newSentence == _word.ToLower())
          {
            count += 1;
          } else if (newSentence == (_word.ToLower() + "."))
          {
            count += 1;
          } else if (newSentence == (_word.ToLower() + "!"))
          {
            count += 1;
          } else if (newSentence == (_word.ToLower() + "?"))
          {
            count += 1;
          } else if (newSentence == (_word.ToLower() + ","))
          {
            count += 1;
          } else if (newSentence == (_word.ToLower() + "s"))
          {
            count += 1;
          }
        }
        return count;
      }
      public int GetResult()
      {
        return _count;
      }
    }
  }
