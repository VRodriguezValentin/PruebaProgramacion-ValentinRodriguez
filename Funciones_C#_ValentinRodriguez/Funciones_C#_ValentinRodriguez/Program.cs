/* Pregunta #1:
Escriba una función en C# que reciba tres variables, una de tipo int, una de tipo string, y una de tipo object. Dentro de la función, hacer lo siguiente: 

- Si la variable de tipo object es un número, sumarla a la variable de tipo int y escriba el resultado en la consola. 
- Si la variable de tipo object es una cadena de caracteres, adjúntela a la variable de tipo string y escriba el resultado en la consola 
- Si la variable de tipo object no cumple con los requisitos anteriores, arroje una excepción. 
*/

static void ProcesarVariables(int numero, string texto, object objeto)
{
    if (objeto is int objetoNumero)
    {
        Console.WriteLine("Suma: " + (numero + objetoNumero));
    }
    else if (objeto is string objetoString)
    {
        Console.WriteLine("Concatenacion: " + texto + objetoString);
    }
    else
    {
        throw new ArgumentException("El objeto no es un entero o un string");
    }
}

ProcesarVariables(5, "No se usa", 10);
ProcesarVariables(0, "Hola", " Mundo");
//ProcesarVariables(404, "Error", 3.14); //Descomentar para probar la excepcion

/* Pregunta #2:
Escriba una función en C# que reciba como parámetro un Dictionary cuya llave sea un int y valor sea un string. 
Dentro de la función, recorrer el Dictionary y separar sus registros en dos listas, 
una lista se debe llenar con todos los valores del Dictionary cuya llave sea un numero par y la otra se debe llenar con todos los valores del Dictionary cuya llave sea un numero impar. 
*/

static void ListarParesImpares(Dictionary<int, string> diccionario, out List<string> pares, out List<string> impares)
{
    pares = new List<string>();
    impares = new List<string>();

    foreach (var item in diccionario)
    {
        if (item.Key % 2 == 0)
            pares.Add(item.Value);
        else
            impares.Add(item.Value);
    }
}

var diccionarioNumeros = new Dictionary<int, string>();

for (int i = 1; i <= 10; i++)
{
    diccionarioNumeros.Add(i, "Numero " + i);
}

ListarParesImpares(diccionarioNumeros, out var listaPares, out var listaImpares);

Console.WriteLine("\nLista de Numeros Pares:");
foreach (var par in listaPares)
{
    Console.WriteLine("- " + par);
}

Console.WriteLine("\nLista de Numero Impares:");
foreach (var impar in listaImpares)
{
    Console.WriteLine("- " + impar);
}