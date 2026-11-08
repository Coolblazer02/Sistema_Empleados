class Programador : Empleado
{
    string Lenguaje = "";

    public Programador(string nombreInicial, int edadInical, double salarioBaseInicial, string lenguajeProgramacion) : base(nombreInicial, edadInical, salarioBaseInicial)
    {
        Lenguaje = lenguajeProgramacion;
    }

    public void MostrarLenguaje()
    {
        Console.WriteLine($"Lenguaje de programacion utilizado por el empleado: {Lenguaje}");
    }
}