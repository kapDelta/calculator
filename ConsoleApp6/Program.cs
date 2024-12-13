// калкулатор
Console.WriteLine("Введите кол-во дней на которое положите деньги");
double dayInMonth = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите сумму вклада");
double vklad = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите процентную ставку в десятичной дроби (15% == 0,15%)");
double procent = Convert.ToDouble(Console.ReadLine());
int day = 365;
double pribil = vklad * Math.Pow((1 + procent / day), dayInMonth);
 pribil = Math.Floor(pribil);
Console.WriteLine("Общая прибыль: " + pribil);
 Task.Delay(10000).Wait();
