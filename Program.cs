Club pc1 = new Club(1, "standart", 130);
Club pc2 = new Club(3, "vip", 175);
Club pc3 = new Club(1, "bootcamp", 200);

Console.WriteLine(">>> места в клубе <<<");
Console.WriteLine($"номер места: {pc1.Seatnumber}");
Console.WriteLine($"какой тариф: {pc1.Zone}");
Console.WriteLine($"сколько стоит час: {pc1.Money_an_hour}");
Console.WriteLine($"занято(да или нет): {pc1.Busy}");
Console.WriteLine();
Console.WriteLine(">>> места в клубе <<<");
Console.WriteLine($"номер места: {pc2.Seatnumber}");
Console.WriteLine($"какой тариф: {pc2.Zone}");
Console.WriteLine($"сколько стоит час: {pc2.Money_an_hour}");
Console.WriteLine($"занято(да или нет): {pc2.Busy}");
Console.WriteLine();
Console.WriteLine(">>> места в клубе <<<");
Console.WriteLine($"номер места: {pc3.Seatnumber}");
Console.WriteLine($"какой тариф: {pc3.Zone}");
Console.WriteLine($"сколько стоит час: {pc3.Money_an_hour}");
Console.WriteLine($"занято(да или нет): {pc3.Busy}");

