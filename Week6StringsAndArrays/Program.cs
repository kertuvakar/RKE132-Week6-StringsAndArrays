
string hello = "wii, world! Here I am?";
//peale wordi hüüumärgi ja jutumärgi vahel on tühik

int stringLength = hello.Length;

hello = hello.Trim();

char firstLetter = hello[0];
Console.WriteLine(firstLetter);

hello = hello.Replace(hello[0],char.ToUpper(hello[0])).Replace('?', '!');
//teen suuremaks ükskõik, mis tähe, mis lause alguses on.
//replace võib ükskõik kui palju kasutada
firstLetter = hello[0];

Console.WriteLine(firstLetter);

Console.WriteLine($"{firstLetter}ii, world! Here I am!");




//Muudan lause esimese tähe suureks. Arvuti jaoks on suur ja väike täht erinevad asjad.





//vana väärtus "hello, world!" eemaldatakse ja kirjutatakse ümber uus
//väärtus ilma tühikuteta muutujasse hello

//int wordCounter = 1;//meie lauses on kasvõi üks sõna ja üks tühik
//for (int i = 0; i < hello.Length; i++) //luubime nüüd läbi terve uue muutuja "hello,world!"
//{
//    if (char.IsWhiteSpace(hello[i]))//otsib tühikuid, true/false väärtused
//    {
//        wordCounter++;

//    }
//}

//Console.WriteLine($"Word count in {hello}:{wordCounter} words.");


//string trimmedString = hello.Trim();
//eemaldame stringist üleliigsed tühikud, kuna need on ka sümbolid
//kahekordse sulud tähendavad käsku
// Console.WriteLine($"{i} symbol in string: {hello[i]}"); kirjutab, mis koha peal asuvad sümbolid muutujas hello,world!
// if (hello[i] == ' ')
//{
//    wordCounter++; sõnade lugeja saab +1, kui if leiab tühiku
//}