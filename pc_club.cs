using System.Reflection.Metadata;

public class Club
{
    public int Seatnumber; // отвечает за место в пк клубе
    public string Zone; // отвечает за зону в пк клубе випка или обычное 
    public int Money_an_hour; // денег в час за место 
    public bool Busy; // свободно ли место или нет

    public Club(int seatnumber, string zone, int money_an_hour)
    {
        Seatnumber = seatnumber;
        Zone = zone;
        Money_an_hour = money_an_hour;
        Busy = false;
    }
}