Console.WriteLine("Введите текст для шифрования:");
string input = Console.ReadLine();
Console.WriteLine("Зашифрованный текст: " + Encrypt(input));

    static string Encrypt(string text)
{
    const string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
    char[] result = new char[text.Length];

    for (int i = 0; i < text.Length; i++)
    {
        int index = alphabet.IndexOf(text[i]);
        result[i] = index >= 0 ? alphabet[alphabet.Length - 1 - index] : text[i];
    }
    return new string(result);
}