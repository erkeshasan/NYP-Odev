Console.WriteLine(string.Join(", ", StringFiltresi(new string[] {"hasan", "abcdefg", "berkay", "emir", "ali"})));

static List<string> StringFiltresi(string[] Strings)
{
    List<string> geçen = new List<string> {};

    foreach (string str in Strings)
    {
        if (str.Length > 5)
        {
            geçen.Add(str);
        }
    }

    return geçen;
}
