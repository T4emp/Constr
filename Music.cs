class Music
{
    public string name1;
    public string name2;
    public Music() { name1 = "Джаз"; name2 = "Прогрессив-джаз"; }
    public Music(string n1) { name1 = n1; name2 = "Блюграсс, Кантри-поп"; }
    public Music(string n1, string n2) { name1 = n1; name2 = n2; }

    public void Print()
    {
        Console.WriteLine($"Критерий: {name1}, Подкритерий: {name2}");
    }
}