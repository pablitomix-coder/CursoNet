// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

List<string> lista = new() { "holi", "muchas", "cositas", "pablito","agrega","mas","palabras","por favor","Solera","Autosource","Hamster","Batman" };
//var lista2 = new List<string>() {"holi","muchas","cositas","pablito"};

//looping (Do,While,For,Foreache)

Console.WriteLine("Foreach");
foreach (string buffer in lista)
{
    Console.WriteLine(buffer);
}

Console.WriteLine("For");
for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}

Console.WriteLine("while");
int count = 0;

while (count < lista.Count)
{
    Console.WriteLine(lista[count++]);
}

Console.WriteLine("do-while");

int count2 = 0;
do
{
    Console.WriteLine(lista[count2++]);
} while (count2 < lista.Count);

for (int j = 0; j < lista.Count; j++)
{
    if(j%2 == 0)
        continue;
    if(j == 5)
        break;
    Console.WriteLine("posicion {0}: {1}",j,lista[j]);
}