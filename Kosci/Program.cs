// static - część całej klasy a nie obiektu

/*
 * function licz(x:int, y:int){  PARAMETRY
 * }
 *
 * licz(2, 3) ARGUMENTY
 *
 *
 * wlasciwosci to funkcje udajace pola z getami i setami, z duzej litery
 * 
 */


Kosc k1 = new Kosc();
ShowInfo(k1);

Console.WriteLine("");

Console.Write("Podaj liczbe oczek: ");
var daneZKonsoli = Console.ReadLine();
Kosc k2 = new Kosc(Convert.ToInt32(daneZKonsoli));
ShowInfo(k2);

void ShowInfo(Kosc kosc)
{
    Console.WriteLine($"Liczba utworzonych instancji klasy Kosc: {Kosc.liczbaInstancji}");
    Console.WriteLine($"Liczba wyrzuconych oczek {kosc.liczbaOczek} / {kosc.WyswietlWartoscKosci()}");
    Console.WriteLine($"Nazwa pliku dla wyrzuconych oczek to: {kosc.listaPlikow[kosc.idPlikuGraficznego]}");
}




public class Kosc
{
    public static int liczbaInstancji = 0;

    public string[] listaPlikow = ["kosc0.png", "kosc1.png", "kosc2.png", 
        "kosc3.png",  "kosc4.png", "kosc5.png", "kosc6.png"];
    
    public int liczbaOczek = 0;

    public int idPlikuGraficznego = 0;

    public bool czyDostepna = false;

    public Kosc(int wartosc)
    {
        if (wartosc < 1 || wartosc > 6)
        {
            wartosc = 0;
        }
        liczbaOczek = wartosc;
        idPlikuGraficznego = wartosc;
        czyDostepna = true;
        liczbaInstancji++;
    }

    public Kosc()
    {
        var random = new Random();
        int liczbaLosowa = random.Next(1, 7);
        liczbaOczek = liczbaLosowa;
        idPlikuGraficznego = liczbaLosowa;
        czyDostepna = true;
        Kosc.liczbaInstancji++;
    }

    public void RzutKoscia()
    {
        if (!czyDostepna) return;
        var random = new Random();
        int liczbaLosowa = random.Next(1, 7);
        liczbaOczek = liczbaLosowa;
        idPlikuGraficznego = liczbaLosowa;
    }

    public void BlokadaKosci()
    {
        czyDostepna = false;
    }

    public string WyswietlWartoscKosci()
    { 
        return liczbaOczek switch
        {
            1 => "Jeden",
            2 => "Dwa",
            3 => "Trzy",
            4 => "Cztery",
            5 => "Pięć",
            6 => "Sześć",
            _ => ""
        };
    }







}