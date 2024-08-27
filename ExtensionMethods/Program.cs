using ExtensionMethods;

//string who = "Ramazon Ustoz";
//Console.WriteLine(who.ToLower());
//Console.WriteLine(who.ToUpper());
//Console.WriteLine(who.Words());
//Console.WriteLine(who.Count());


List<int> sonlar = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
sonlar.FaqatJuftlar().ToList().
    ForEach(x=> Console.WriteLine(x));