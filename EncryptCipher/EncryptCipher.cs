using System.Text;

namespace EncryptCipher;

public class EncryptCipher
{
     public static StringBuilder Encrypt(String text, int shift)
     {
          StringBuilder singleWordResult = new StringBuilder();
          StringBuilder multiWordResult = new StringBuilder();
          char[] delimiters = {' ', '\r', '\n', '\t', '.', ',', ';', ':'};
          
          if (text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length == 1)
          {
               for (int i = 0; i < text.Length; i++)
               {
                    if (char.IsUpper(text[i]))
                    {
                         char character = (char) ((text[i] + shift - 65) % 26 + 65);
                         singleWordResult.Append(character);
                    }
                    else
                    {
                         char character = (char) ((text[i] + shift - 97) % 26 + 97);
                         singleWordResult.Append(character);
                    }    
               }
               return singleWordResult;
          }

          if (text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length > 1)
          {
               String[] textArray = text.Split(delimiters);

               for (int i = 0; i < textArray.Length; i++)
               {
                    singleWordResult.Clear();

                    for (int n = 0; n < textArray[i].Length; n++)
                    {
                         if (char.IsUpper(textArray[i][n]))
                         {
                              char character = (char) ((textArray[i][n] + shift - 65) % 26 + 65);
                              singleWordResult.Append(character);
                         }
                         else
                         {
                              char character = (char) ((textArray[i][n] + shift - 97) % 26 + 97);
                              singleWordResult.Append(character);
                         }
                    }

                    String currentString = singleWordResult.ToString();
                    
                    if (i == textArray.Length - 1)
                    {
                         multiWordResult.Append(currentString);
                    }
                    else
                    {
                         multiWordResult.Append(currentString).Append(' ');
                    }
               }
               return multiWordResult;
          }
          return null!;
     }
     // Driver
     public static void Main(String[] args)
     {
          Console.WriteLine("Input text for encryption: ");
          String text = Console.ReadLine();
          Console.WriteLine("Input shift for encryption: ");
          int shift = Int32.Parse(Console.ReadLine());
          Console.WriteLine("Text: " + text);
          Console.WriteLine("Shift: " + shift);
          Console.WriteLine("Cipher: " + Encrypt(text, shift));
     }
}