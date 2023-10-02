// See https://aka.ms/new-console-template for more information

//Part 1
string firstName = "Christopher", favMovie = "The Matrix";
Console.WriteLine("Part 1\n");
Console.WriteLine("hello my name is " + firstName.ToLower() + " and my favorite movie is " + favMovie.ToLower());
favMovie  = favMovie.ToUpper();
Console.WriteLine(favMovie.Contains("THE"));
favMovie = favMovie.Replace("A", "@");
favMovie = favMovie.Replace("E", "3");
Console.WriteLine(favMovie);
Console.WriteLine();

//Part 2
string favQuote = "I've been dead for 35 years, today is the day I live"; //From the video game Lisa The Painful
Console.WriteLine("Part 2\n");
favQuote = favQuote.Replace("a", "").Replace("e", "").Replace("I", "").Replace("i", "").Replace("o", "").Replace("u", "").Replace("y", "");
Console.WriteLine(favQuote);
Console.WriteLine();

//Part 3
Console.WriteLine("Part 3\n");
Console.WriteLine("        //               .:' ");
Console.WriteLine("       (oo\\         __ :'__ ");
Console.WriteLine("       / ._)      .'`__`-'__``. ");
Console.WriteLine("      J _ =\\=    :__________.-' ");
Console.WriteLine("      |   /      :_________: ");
Console.WriteLine("3._.' |_|_);      :_________`-; ");
Console.WriteLine("                   `.__.-.__.' ");