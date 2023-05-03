using System;

public static class Kata
{
  public static string ToWeirdCase(string s)
  {
    string result = "";
    int count = 0;
    foreach (char c in s)
    {
      if (Char.IsWhiteSpace(c))
      {
        count = 0;
        result += c;
      }
      else
      {
        if (count % 2 == 0)
        {
          result += Char.ToUpper(c);
        }
        else
        {
          result += Char.ToLower(c);
        }
        count++;
      }
    }
    return result;
  }
}
