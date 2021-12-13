using System.Text;

namespace EncryptCipher;

public class EncryptCipher
{
    // Encrypt text by leveraging shift value
    public static StringBuilder Encrypt(String text, int shift)
    {
        StringBuilder result = new StringBuilder();

        foreach (var i in text)
        {
            if (char.IsUpper(i))
            {
                char character = (char) ((i + shift - 65) % 26 + 65);
                result.Append(character);
            }
            else
            {
                char character = (char) ((i + shift - 97) % 26 + 97);
                result.Append(character);
            }
        }
        return result;
    }
    // Driver
    public static void Main(String[] args)
    {
        String text = "Caeser Cypher";
        int shift = 5;
        Console.WriteLine("Text: " + text);
        Console.WriteLine("Shift: " + shift);
        Console.WriteLine("Cipher" + Encrypt(text, shift));
    }
}