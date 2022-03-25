string a;
Console.WriteLine("wpisz tekst");
a = Console.ReadLine();
int b;
Console.WriteLine("WPisz o ile chcesz przesunac");
b = Int32.Parse(Console.ReadLine());

char[] tab = a.ToCharArray();
bool space;

for (int i = 0; i < tab.Length; i++)
{
    space = Char.IsWhiteSpace(tab[i]);
    if (space == true) {
        continue;
    }
    else
    {
        tab[i] = (char)((char)tab[i] + b);
    }


}
string wyjscie = string.Join("", tab);
Console.WriteLine("Zaszyfrowany kod to: " + wyjscie);