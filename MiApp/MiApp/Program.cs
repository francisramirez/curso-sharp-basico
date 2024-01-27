

// Llamadas de metodos //
/*
 *   Multiples
 */
using MiApp;

//Suma();
CalcularImporte();

void Suma()
{
    int num1 = 0;
    int num2 = 0;
    int suma = 0;
    // decimal
    //double
    //float


    Console.WriteLine("Digitel el primer num: ");
   
    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite el segundo num: ");

    num2 = Convert.ToInt32(Console.ReadLine());

    suma = (num1 + num2);

    Console.WriteLine($"El resultado es: {suma}");
    Console.Read();

}

void CalcularImporte() 
{
    int cantidad = 0;
    decimal? precio = null;
    decimal importe = 0;
    decimal impuesto = 0;
    decimal total = 0; //(importe + impuesto);
    string? linea = string.Empty;
    double valorImpuesto = 0.05;

    try
    {
        //Capturar la informacion de la cantidad de productos //
        Console.WriteLine("Ingrese la cantidad de productos: ");
        linea = Console.ReadLine();
        //cantidad = int.Parse(linea);
        cantidad = Convert.ToInt32(linea);

        Console.WriteLine("Ingrese el valor del precio del producto: ");
        linea = Console.ReadLine();
        precio = Convert.ToDecimal(linea);

        importe = (cantidad * precio.Value);


        // Si el importe es mayor a 1000 entonces debe aplicarle un impuesto de 5%;

        if (importe > 1000)
        {
            impuesto = (importe * Convert.ToDecimal(valorImpuesto));
            total = (importe + impuesto);
        }
       



        Console.WriteLine($"El valor del impuesto es: { impuesto } y el total es: { total } ");
    }
    catch (ArgumentOutOfRangeException exp)
    {
        Console.WriteLine(exp.Message);
    }
    catch (ImporteException iex) 
    {
        Console.WriteLine(iex.Message);
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
    }

    Console.ReadLine();

}
