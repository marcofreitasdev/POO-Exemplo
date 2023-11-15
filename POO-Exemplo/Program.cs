public class Animal
{
    public string Name { get; set; }

    public virtual string EmitirSom()
    {
        return "O animal emite um som";
    }
}

public class Cachorro : Animal
{
    public override string EmitirSom()
    {
        return "O cachorro late";
    }
}

public class Gato : Animal
{
    
}

class Program
{
    static void Main()
    {
        Console.WriteLine("O exemplo POO está iniciando");

        Cachorro cachorro = new Cachorro();
        Gato gato = new Gato();

        cachorro.Name = "Rex";
        gato.Name = "Gato";

        Console.WriteLine("O nome do cachoro é " + cachorro.Name);
        Console.WriteLine("O nome do gato é " + gato.Name);

        Console.WriteLine(cachorro.EmitirSom());
        Console.WriteLine(gato.EmitirSom());
    }
}