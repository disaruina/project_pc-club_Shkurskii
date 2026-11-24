public class Club
{
    public const int StandardPrice = 140;
    public const int VipPrice = 175;
    public const int BootcampPrice = 1000;

    public int Seatnumber { get; private set; } // отвечает за место в пк клубе
    public string Zone { get; private set; } // отвечает за тариф компа
    public int Balance { get; private set; } // баланс который тратится на часы
    public int Hours { get; private set; } // часы сколько может посидеть человек за пк
    public bool Busy { get; private set; } // место свободно да или нет

    public Club(int balance, int hours, int seatnumber, string zone)
    {
        if (balance < 0) balance = 0;
        if (hours <= 0) hours = 1;
        if (seatnumber <= 0) seatnumber = 1;
        if (zone != "standard" && zone != "vip" && zone != "bootcamp")
        {
            zone = "standard";
        }

        Balance = balance;
        Hours = hours;
        Seatnumber = seatnumber;
        Zone = zone;
        Busy = false;
    }

    public int Price() // возвращает стоимость часа в зависимости от тарифа
    {
        if (Zone == "vip") return VipPrice;
        if (Zone == "bootcamp") return BootcampPrice;
        return StandardPrice;
    }

    public void Start() // проверка хватает ли денег на то количество часов которое захотел пользователь 
    {
        if (Busy || Hours <= 0) return;

        int totalCost = Price() * Hours;
        if (Balance < totalCost)
        {
            Console.WriteLine($"Место №{Seatnumber}: недостаточно денег (нужно {totalCost} руб, на балансе {Balance} руб)");
            return;
        }

        Balance -= totalCost;
        Busy = true;
        Console.WriteLine($"Место №{Seatnumber}: сессия запущена на {Hours} ч, остаток баланса: {Balance} руб");
    }

    public void AddHours(int DopHours) // добавление часов пользователю 
    {
        if (DopHours <= 0) return;
        Hours += DopHours;
    }
}
