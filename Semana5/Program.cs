

//static void saludar(string nomsal)
//{
//    Console.WriteLine($"Un gran saludo a {nomsal}");
//}

//static int Calcul_oaño_nacimiento(int edad)
//{
//    int añon = 2023 - edad;
//    return añon;
//}


//static void marque(string palabra)
//{
//    int longitud = palabra.Length;

//    for (int c = longitud - 1; c >= 0; c--)
//    {
//        Console.SetCursorPosition(5 + c, 10 + c);
//        Console.WriteLine(palabra[c]);
//        Thread.Sleep(1000);
//    }




//    Console.Write(palabra[2]);
//}
//string palabra;
//palabra = "maria";
//marque(palabra);




static bool palindromo(string palabra)
{
    int longitud = palabra.Length;

    string pal = "";
    for (int c = longitud - 1; c >= 0; c--)
    {
        pal = pal + palabra[c].ToString().ToUpper();
    }

    if (palabra.ToUpper().Equals(pal));
    {
        return true;
    }
    return false;

}








bool esPlindromo=palindromo("oso");

if (esPlindromo)
{
    Console.WriteLine("Es palindromo");
}
else
{
    Console.WriteLine("No se palindromo");
}




//char letra= 'a';
//string palabra = letra;


//string nombre;
//int edad;
//int año_nac;
//Console.WriteLine("Como te llamas?");



//nombre = Console.ReadLine();

//saludar(nombre);

//Console.WriteLine($"Hola, un gusto saludarte {nombre}");
//Console.WriteLine("Cuantos años tienes?");
//edad = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Bonita edad: {edad} \nNaciste en {Calcul_oaño_nacimiento(edad)}");
