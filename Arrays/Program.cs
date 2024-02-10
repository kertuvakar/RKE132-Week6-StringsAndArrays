

//string[] fruit = { "apples", "bananas", "oranges" };
    //string ja kandilised sulud tähendab massiiv-kogumik sõnedest
    //numbbrit ja boolean tüüpi andmeid siia stringi massiivi sisse lisada ei saa

string[] fruit = new string[3];
    //loon uue massivi ja reserveerin kolm kohta mälus
    //hiljem massiivi suurust muuta ei saa, kolm kohta on ja jääb

fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";
Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitArrayLength = fruit.Length;
//ka massiivil on pikkus
Console.WriteLine($"There are {fruitArrayLength} in your array.");

for (int i = 0; i < fruitArrayLength; i++) 
//loen massiivi läbi ja kuvan väärtused, mis on massiivis
//see for asendab neid kolme arrayd eespool
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}
//Asendame i esimese tähe suure tähega.fruit i kohal 0 asendada char.ToUpper fruit i kohal null
foreach (string element in fruit)
//ma saan teha midagi iga sõne massiivis
//see element tähistab kõiki väärtusi massiivis fruit (1 kuni 3)
//foreach kuvab väärtusi ja salvestab, aga sisu ei saa muuta
//element = element.Replace(element[0], char.ToUpper(element[0]));
{

    Console.WriteLine(element);
}