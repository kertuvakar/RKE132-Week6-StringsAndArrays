

string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "porridge" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);
//Ma tahan genereerida suvalist väärtust, et anda talle indeks massiivis
//indeks massiivis vastab toidule, sushi "0" kuni porridge "4"

Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}.");
