// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter a word: ");
string s = Console.ReadLine();
string[] arr = s.Split(" ");
foreach (string str in arr)
{
    char s1 = str[0];
    char s2 = str[str.Count()-1];
    string ilk = str.Remove(0, 1);
    string iki = ilk.Remove(ilk.Count()-1, 1);
    string fin = s2 + iki + s1;
    Console.Write(fin + " ");
}