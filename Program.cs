Console.WriteLine("==================================\n");
Console.WriteLine("тарифы клуба (за 1 час) ");
Console.WriteLine($"Standard: {Club.StandardPrice} руб");
Console.WriteLine($"VIP: {Club.VipPrice} руб");
Console.WriteLine($"Bootcamp: {Club.BootcampPrice} руб");
Console.WriteLine("==================================\n");

Club pc1 = new Club(567, 2, 1, "standard");
Club pc2 = new Club(42, 2, 4, "vip");
Club pc3 = new Club(3000, 3, 7, "bootcamp");

// pc1.Balance = -9999;
// pc1.Busy = true;

Console.WriteLine($"pc1 до: Баланс = {pc1.Balance}, Занято = {pc1.Busy}");
pc1.Start();
Console.WriteLine($"pc1 после: Баланс = {pc1.Balance}, Занято = {pc1.Busy}\n");

Console.WriteLine($"pc2 до: Баланс = {pc2.Balance}, Занято = {pc2.Busy}");
pc2.Start();
Console.WriteLine($"pc2 после: Баланс = {pc2.Balance}, Занято = {pc2.Busy}\n");

Console.WriteLine($"pc3 часы до: {pc3.Hours}");
pc3.AddHours(2);
Console.WriteLine($"pc3 после AddHours(2): {pc3.Hours}");
pc3.AddHours(-3);
Console.WriteLine($"pc3 после AddHours(-3): {pc3.Hours}\n");

Club pc4 = new Club(-6767, -42, 0, "ещкере");
Console.WriteLine($"pc4 (проверка): Место = {pc4.Seatnumber}, Зона = {pc4.Zone}, Баланс = {pc4.Balance}, Часы = {pc4.Hours}");

