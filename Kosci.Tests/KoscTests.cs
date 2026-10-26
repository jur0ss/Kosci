namespace Kosci.Tests;

public class KoscTests
{
    [Fact]
    public void RzutKoscia_LiczbaLosowa_Miedzy_1_6()
    {
        var kosc = new Kosc();
        
        kosc.RzutKoscia();
        
        Assert.InRange(kosc.liczbaOczek, 1, 6);
    }

    [Fact]
    public void RzutKoscia_KoscNiedostepna_BrakZmianLiczbyOczek()
    {
        var kosc = new Kosc();
        
        kosc.RzutKoscia();
        var liczbaOczek = kosc.liczbaOczek;

        kosc.BlokadaKosci();
        
        kosc.RzutKoscia();
        
        Assert.Equal(liczbaOczek, kosc.liczbaOczek);
    }
}