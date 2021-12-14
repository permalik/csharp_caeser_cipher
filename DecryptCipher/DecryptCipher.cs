using System.Text;

namespace DecryptCipher;

public class DecryptCipher
{
    public static StringBuilder Decrypt(String text, int shift)
    {
        StringBuilder result = new StringBuilder();

        foreach (var t in text)
        {
            if (char.IsUpper(t))
            {
                char character = (char) ((t - shift - 65) % 26 + 65);
                result.Append(character);
            }
            else
            {
                char character = (char) ((t - shift - 97) % 26 + 97);
                result.Append(character);
            }
        }
        return result;
    }
    // Driver
    public static void Main(String[] args)
    {
        Console.WriteLine("Input text to decrypt: ");
        String text = Console.ReadLine();
        Console.WriteLine("Input shift for decryption: ");
        int shift = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Text: " + text);
        Console.WriteLine("Shift: " + shift);
        Console.WriteLine("Cipher: " + Decrypt(text, shift));
    }
}