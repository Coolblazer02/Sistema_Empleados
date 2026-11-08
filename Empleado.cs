class Empleado
{
    //Atributos de la clase
    public string Nombre = "";
    public int Edad;
    public double SalarioBase;

//Constructor sin parametros
     public Empleado()
    {
        Nombre = "Desconocido";
        Edad = 18;
        SalarioBase = 1500;
    }

    //Constructor con parametros
    public Empleado(string nombreInicial, int edadInical, double salarioBaseInicial)
    {
        Nombre = nombreInicial;
        Edad = edadInical;
        SalarioBase = salarioBaseInicial;
    }

    //metodo para Mostrar Informacion
    public void MostrarInformacion()
    {
         Console.WriteLine();
        Console.WriteLine($"Nombre del empleado: {Nombre}");
         Console.WriteLine();
        Console.WriteLine($"Edad del empleado: {Edad}");
         Console.WriteLine();
        Console.WriteLine($"El salario inicial del empleado es de: ${SalarioBase:F2}");
         Console.WriteLine();
    }

    //Metodo para calcular salario anual de los empleados
    public double CalcularSalarioAnual()
    {
        double salarioAnual = SalarioBase * 12;

        return salarioAnual;
    }
}