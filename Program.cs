Human pablito = new Human(new DateTime(1992, 2, 13), Nationalities.Mexicano, "Pablo");
Human Dani = new Human(new DateTime(1994, 5, 25), Nationalities.Argentino, "Daniel");
Human Irving = new Human(new DateTime(1996, 8, 3), Nationalities.Brazileño, "Carlos");
Human Andrew = new Human(new DateTime(1996, 5, 15), Nationalities.Brazileño, "Andrew");

//Este es un metodo de instancia y se manda a llamar los metodos pero cuando ya se inicializo la instancia
Irving.Name = "Irving";
//Creacion de una lista
List<Human> humans = new List<Human>();
//agregar objetos a la lista
humans.Add(pablito);
humans.Add(Dani);
humans.Add(Irving);
humans.Add(Andrew);

foreach (var human in humans)
{
    Console.WriteLine(human.Introduce());
}

// Console.WriteLine(pablito.Introduce());
// Console.WriteLine(Dani.Introduce());
// Console.WriteLine(Irving.Introduce());
// Console.WriteLine(Andrew.Introduce());
Console.WriteLine(pablito.IntroduceTo(Irving));
Console.WriteLine(Andrew.IntroduceTo(Irving));