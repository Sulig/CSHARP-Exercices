using System;

public class Util
{
    //Repaso Declaracion de variables:
    public static void DeclaracionVariables()
    {
        //Variables:
        int num = 3;
        float vel = 3.5f;
        double grande = 3.6;
        decimal dec = 10 / 100;

        string nombre = "nombre";
        char letra = nombre[0];

        string[] nombres;

        //Aparecer o ecribir:
        Console.WriteLine("Aparece por pantalla");
        nombre = Console.ReadLine();

        //Metodos de poner una variable en el texto:
        Console.WriteLine(num);
        Console.WriteLine("Hola " + nombre);
        Console.WriteLine($"Vas a {vel} m/s");
    }

    //Repaso Operadores
    /// <summary>
    /// /// - Aritmeticos:
    ///- binarios: +, -, *, /, %
    ///- urinario: ++, --, - (cambiar el signo), ! (negacion)
    /// - Logicos:
    ///- AND (&&) -> Se cumplen ambas condiciones.
    ///- OR (||)-> Se cumple una de las condiciones.
    ///- NOT o ! -> No se cumple esa condicion, se cumple la contraria
    /// - De Asignacion:
    ///- =, +=, -=, *=, /=, %=  ej.(num = num + 5-> = ->num += 5;)
    ///* ej de uso: 
    /// int num = 10;
    ///num += 5;
    /// ConsoleWriteLine(num); *Y te saldra la respuesta*
    ///  - De Comparacion:
    ///- <, >, <=, >=; != (no es igual), == ,(=== (*no es necesario))
    /// </summary>
    /// <returns></returns>
    public static int Operadores()
    {
        int v = 3;
        return 3;
    }

    //Controles de flujo:
    /// <summary>
    /// Controles de flujo:
    /// 
    /// **If**:
    ///  Condicion -> si es true haz {}, si no, saltatelo
    ///  
    /// **Else if**:
    /// Siempre debajo de un if. Se cumple si if ^ no ha dado true y si esta condicion es true
    /// 
    /// **Else**:
    /// Si "if" ni "else if" no han dado true 
    /// 
    /// **Switch** (case)
    /// Solo valido para strings y chars
    /// case "":  break;
    /// default:  break;  Caso por defecto
    /// </summary>
    public static void ControldeFlujo()
    {
        int num = 0;
        string acso = "n";

        //if:
        if (num == 0)  //Condicion -> si es true haz {}
        {
            Console.WriteLine(num);
        }

        //else if:
        else if (num == 1) //Se cumple si if ^ no ha dado true y si esta condicion es true
        {
            Console.WriteLine(num);
        }

        //else:
        else //Si if y else if no han dado true 
        {
            num = 10;
            Console.WriteLine(num);
        }

        //Switc - Case:
        switch (acso) //Solo se puede usar con strings y chars //NO <>=
        {
            case "n":
                num++;
                Console.WriteLine(num);
                break;

            default:
                Console.WriteLine(num);
                break;
        }
    }

    //Conversiones:
    /// <summary>
    /// Conversion de Int a String //Necessita un int
    /// </summary>
    /// <param name="entrada"></param>
    /// <returns></returns>
    public static string ConversionIntAString(int entrada)
    {
        string salida = entrada.ToString();
        return salida;
    }

    /// <summary>
    /// Conversion de Float a String //Necessita un float //Para pasar a String// nombre.ToString()
    /// </summary>
    /// <param name="entrada"></param>
    /// <returns></returns>
    public static string ConversionFloatAString(float entrada)
    {
        string salida = entrada.ToString();
        return salida;
    }

    //Con un formato especifico:
    /// <summary>
    /// Conversion de Int a String Con el formato 00000
    /// </summary>
    /// <param name="entrada"></param>
    /// <returns></returns>
    public static string ConversionIntAStringConZero(int entrada)
    {
        string salida = entrada.ToString("00000");
        return salida;
    }

    /// <summary>
    /// Conversion de Int a String en Hexadecimal *En Unity se deve usar la libreria "using.System;" para usar esta conversion*
    /// </summary>
    /// <param name="entrada"></param>
    /// <returns></returns>
    public static string ConversionIntAStringHexadecimal(int entrada)
    {
        string salida = entrada.ToString("X2");
        return salida;
    }

    /// <summary>
    /// De String a Int. variable.Parse(algo);
    /// </summary>
    /// <param name="entrada"></param>
    /// <returns></returns>
    public static int ConversionStringaInt(string entrada)
    {
        int salida = int.Parse(entrada);
        return salida;
    }

    //Funciones Array:

    /// <summary>
    /// Funciones Array:
    /// *String.Join* 
    /// Ver toda la matriz:
    /// Console.WriteLine(String.Join(", ", array));  *el ", " es como se separaran las distintas partes
    /// 
    /// *Array.Sort*
    /// Ordenar de A-Z
    /// </summary>
    /// <param name=""></param>
    /// <returns></returns>
    public static int[] FuncionesArray(int[] entrada)
    {
        Array.Sort(entrada);
        return entrada;
    }

    /// <summary>
    /// *Array.Reverse*
    /// Ordenar de Z-A
    /// 
    /// *Array.IndexOf*
    /// Que posicion ocupa ese dato en la array
    /// 
    /// 
    /// **Listas**
    /// List<string> ciclosMerce = new List<string>() {"A3D", "VDJ", "SO"};
    /// 
    /// *Add* && *Remove*
    /// Añaden o quitan una opcion
    /// </summary>
    /// <param name="entrada"></param>
    /// <returns></returns>
    public static int[] MasFuncionesArray(int[] entrada)
    {
        Array.Reverse(entrada);
        return entrada;
    }

    /// <summary>
    /// Numero Aleatorio:
    /// Random x = new Random();
    /// int i = x.Next(min, max);
    /// 
    /// **Para Unity:**
    /// int numeroAleatorio = Random.Range(0, 8);
    /// </summary>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <returns></returns>
    public static int NumeroAleatorio(int min, int max)
    {
        Random x = new Random();
        int i = x.Next(min, max);

        return i;
    }

    //Bucles:
    /// <summary>
    /// Bucles:
    /// 
    /// *For*:
    /// Se repite hasta que la condicion no se cumpla, definido.
    /// for(int i = 0; i<10; i++){ Accion }
    /// 
    /// *Foreach*:
    /// Solo utilizable para recorrer ENTERA (sin atajo) toda una array o lista
    /// foreach variable i in variableX { Accion }
    /// 
    /// *While*:
    /// Se repite hasta que la condicion no se cumpla, indefinido.
    /// while(condicion) { Accion y volver a introducir un valor }
    /// 
    /// *Do-While*:
    /// Lo mismo, pero se produce una vez:
    /// do { Accion 1 } while (condicion);
    /// </summary>
    /// <returns></returns>
    public static int Bucles()
    {
        int c = 3;
        return c;
    }

    //Utilidades:
    /// <summary>
    /// Raiz cuadrada
    /// float variableF = (float)Math.Sqrt(variable); 
    /// </summary>
    /// <param name="entrada"></param>
    /// <returns></returns>
    public static float RaizCuadrada(float entrada)
    {
        float salida = (float)Math.Sqrt(entrada); //Raiz cuadrada.
        return salida;
    }

    /// <summary>
    /// Elevar un numero
    /// float salida = (float)Math.Pow(entrada, elevar);
    /// </summary>
    /// <param name="entrada"></param>
    /// <param name="elevar"></param>
    /// <returns></returns>
    public static float ElevarA(float entrada, int elevar)
    {
        float salida = (float)Math.Pow(entrada, elevar);
        return salida;
    }

    /// <summary>
    /// Redondear un numero
    ///  int salida = (int)Math.Round(entrada);
    /// </summary>
    /// <param name="entrada"></param>
    /// <returns></returns>
    public static int Redondear(float entrada)
    {
        int salida = (int)Math.Round(entrada);
        return salida;
    }

    /// <summary>
    /// Logaritmo en base 10
    /// float salida = (float)Math.Log10(entrada);
    /// </summary>
    /// <param name="entrada"></param>
    /// <returns></returns>
    public static float Logaritmo(float entrada)
    {
        float salida = (float)Math.Log10(entrada);
        return salida;
    }

    /// <summary>
    /// Coseno, Sin y Tan de un angulo
    ///  float cos = (float)Math.Cos(entrada);
    ///  
    /// *Salida*:
    /// [0] -> sin, [1] -> cos y [2] -> tan
    /// </summary>
    /// <param name="entrada"></param>
    /// <returns></returns>
    public static float[] SinCosTan(float entrada)
    {
        float sin = (float)Math.Sin(entrada);
        float cos = (float)Math.Cos(entrada);
        float tan = (float)Math.Tan(entrada);

        float[] salida = new float[] { sin, cos, tan };
        return salida;
    }

    /// <summary>
    /// Pi:
    ///  float pi = (float)Math.PI;
    /// </summary>
    /// <returns></returns>
    public static float Pi()
    {
        float pi = (float)Math.PI;
        return pi;
    }

    /// <summary>
    /// *Maximo*
    /// Math.Max(num1, num2);
    /// 
    /// *Minimo*
    /// Math.Min(num1, num2);
    /// </summary>
    /// <param name="entrada1"></param>
    /// <param name="entrada2"></param>
    /// <returns></returns>
    public static float[] MaxMin(float entrada1, float entrada2)
    {
        float max = Math.Max(entrada1, entrada2);
        float min = Math.Min(entrada1, entrada2);

        float[] salida = new float[] { max, min };
        return salida;
    }

    /// <summary>
    /// Util para fechas:
    ///  DateTime fecha = new DateTime(2020, 1, 31);
    ///  fecha = fecha.AddMonths(1s);
    /// </summary>
    /// <returns></returns>
    public static DateTime Fecha()
    {
        DateTime fecha = new DateTime(2021, 1, 31);
        fecha = fecha.AddMonths(10);
        Console.WriteLine(fecha);
        return fecha;
    }

    /// <summary>
    /// Numeros Primos, pon tu cantidad.
    /// 
    /// ** ->//Solo senares:
    ///   for (int x = 0; x<cantidad; x++) {
    ///   res = a % 2;
    ///   while (res == 0) { a++; res = a % 2; }
    /// Llenar la matriz
    /// numerosPrimos[x] = a;  a++; }
    /// </summary>
    /// <param name="cantidad"></param>
    /// <returns></returns>
    public static int[] NumerosPrimos(int cantidad)
    {
        int a = 0;
        int res = 0;

        //Matriz
        int[] numerosPrimos = new int[cantidad];

        //Solo senares:
        for (int x = 0; x < cantidad; x++)
        {
            res = a % 2;

            while (res == 0)
            {
                a++;
                res = a % 2;
            }

            //Llenar la matriz
            numerosPrimos[x] = a;
            a++;
        }

        return numerosPrimos;
    }

    /// <summary>
    /// Try-Catch:
    /// Se usa como metodo de exepcion
    /// int salida = -1;
    /// while (salida == -1) {
    /// try { salida = int.Parse(numero); }
    /// catch { Console.WriteLine("Introduce un numero, no en letras"); salida = -1; } }
    /// </summary>
    /// <param name="numero"></param>
    /// <returns></returns>
    public static int TryCatch(string numero)
    {
        int salida = -1;

        while (salida == -1)
        {
            try
            {
                salida = int.Parse(numero);
            }

            catch
            {
                Console.WriteLine("Introduce un numero, no en letras");
                salida = -1;
            }
        }

        return salida;
    }
}