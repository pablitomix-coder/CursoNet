//Inicialisacion de un humano

using System.Threading.Channels;

Human pablito = new Human(new DateTime(1992, 2, 13), Nationalities.Mexicano, "Pablo");
Human Dani = new Human(new DateTime(1994, 5, 25), Nationalities.Argentino, "Daniel");
Human Irving = new Human(new DateTime(1996, 8, 3), Nationalities.Brazileño, "Carlos");
Human Andrew = new Human(new DateTime(1996, 5, 15), Nationalities.Brazileño, "Andrew");
Human Edwin = new Human(new DateTime(1986, 5, 15), Nationalities.Hamster, "Edwin");

//Este es un metodo de instancia y se manda a llamar los metodos pero cuando ya se inicializo la instancia
Irving.Name = "Irving";
//Creacion de una lista
// List<Human> humans = new List<Human>();
//Agregar objetos a la lista
// humans.Add(pablito);
// humans.Add(Dani);
// humans.Add(Irving);
// humans.Add(Andrew);
// humans.Add(Edwin);

//Collection initializer list otra forma de agregar objetos a una lista
var humans = new List<Human>()
{
    pablito, Dani, Irving, Andrew, Edwin
}; //var es una manera de que c# infiere el tipo de dato que este despues del igual
List<Human> humans2 = new() { pablito, Dani, Irving, Andrew, Edwin }; //otra manera de hacer lo de arriba
humans.RemoveAt(4);
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
//humans.Remove(Edwin);//Remover un elemento conocido de una lista

Console.WriteLine(humans.Count); //saber el tamaño de la lista
//Formas de inicializar un arreglo en c# 8
var array = new Human[] { pablito, Dani };
Human[] array2 = { Irving, Andrew };
var array3 = new Human[1];
array3[0] = Edwin;

Console.WriteLine(array[1].Introduce());
Andrew = null; //Quitar la referencia a el objeto
//array2[1] = null;//Borra la referencia el en arreglo
Console.WriteLine(array2[1].Introduce());
Console.WriteLine(array2.Length); //para saber el tamaño de mi arreglo