public class Human
{
    private readonly DateTime dateOfBirth;
    private string? name;
    private Nationalities nationality;

    //Este es el constructo y es un metodo especial y sirve para crear instancias d eesta clase y es un metodo
    public Human(DateTime dateOfBirth, Nationalities nationality)
    {
        this.dateOfBirth = dateOfBirth; //assigning the constructor parameter to the instance field
        this.nationality = nationality;
    }

    //Con este metodo estamos reliazando una sobrecarga de metodos
    //La firma de un metodo esta formado por los tipos de parametros
    public Human(DateTime dateOfBirth, Nationalities nationality, string name) :
        this(dateOfBirth, nationality) //llamar un constructor desde otro constructor
    {
        this.name = name;
    }

    //Propiedades
    public DateTime DateOfBirth
    {
        get { return dateOfBirth; }
    } //devolver el valor del campo

    public int Age
    {
        get => (DateTime.Now - dateOfBirth).Days / 365;
    } //diferente sintaxis. Solo devuelve el valor

    public Nationalities Nationality => nationality; //sintaxis para solo devolver un valor

    public string? Name
    {
        get => name;
        //set => name = value; //asignar valor "value" y pasarlo a name
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                name = value;
        }
    }

    //metodo de instancia
    //Clase es la reseta para hacer galletas
    //Que es una instancia? es el objeto creado en este caso seria la galleta
    //Metodo de instancia es aque que podemos llamar una vez que se aya creado el objeto
    //Metodo de clase
    public string Introduce() =>
        $"{Hello()}, mi nombre es {Name}, tengo {Age} años y soy {Nationality}"; //Metodo que regresa un string solo se puede configurar asi si es que se se puede realizar en una linea


    public string IntroduceTo(Human human)
    {
        string greeting = $"{Hello()} {human.Name}, yo soy {this.name}, y ";
        
        //este es un if termario y no ayuda a reducir el codigo
        greeting += this.nationality == human.nationality
            ? $"tambien soy {this.nationality} madafaka"
            : $"soy {this.nationality}";
        // if (this.nationality == human.nationality)
        // {
        //     greeting += $"tambien soy {this.nationality} madafaka";
        // }
        // else
        // {
        //     greeting += $"soy {this.nationality}";
        // }

        return greeting;
    }

    public static string Hello() //static nos dice que es un metodo de clase y no de instancia
    {
        return "holi";
    }
}