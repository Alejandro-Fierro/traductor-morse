// See https://aka.ms/new-console-template for more information
int menu;

do
{
    Console.Clear();
    Console.WriteLine("\n\rMENU DE OPCIONES\n\r------------------------------------");
    Console.WriteLine("1. Cambiar de Español a Morse.\n\r2. Cambiar de Morse a Español\n\r3. Salir");
    Console.Write("Que quiere realizar: ");
    menu = Convert.ToInt16(Console.ReadLine());
    string codigo;
    switch (menu)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Ingrese la palabra u oracion a Traducir: ");
            codigo = Console.ReadLine();
            Traduccion(codigo);
            Console.ReadKey();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Ingrese el codigo Morse a Traducir (Utilice / para separar palabras): ");
            codigo = Console.ReadLine();
            morse(codigo);
            Console.ReadKey();
            break;
        case 3:
            Console.WriteLine("Gracias por utilizar este programa\n\rPresione enter.");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Ingrese un Numero dentro del Menu");
            Console.ReadKey();
            break;
    }

} while (menu != 3);

void Traduccion(string x)
{
    Dictionary<string, string> codigo = new Dictionary<string, string>
        {
            {"a",".-"},    {"b","-..."},  {"c","-.-."},  {"d","-.."},
            {"e","."},     {"f","..-."},  {"g","--."},   {"h","...."},
            {"i",".."},    {"j",".---"},  {"k","-.-"},   {"l",".-.."},
            {"m","--"},    {"n","-."},    {"o","---"},   {"p",".--."},
            {"q","--.-"},  {"r",".-."},   {"s","..."},   {"t","-"},
            {"u","..-"},   {"v","...-"},  {"w",".--"},   {"x","-..-"},
            {"y","-.--"},  {"z","--.."},
            {"0","-----"}, {"1",".----"}, {"2","..---"},    {"3","...--"},
            {"4","....-"}, {"5","....."}, {"6","----."}, {"7","---.."},
            {"8","--..."}, {"9","-...."}, {" ","/"}
        };

    foreach (char letra in x)
    {
        Console.Write(codigo[letra.ToString()] + " ");
    }
}
void morse(string codigo)
{
    string[] espacio = codigo.Split(" ");
    Dictionary<string, string> presentar = new Dictionary<string, string>
        {
            {".-","a"},    {"-...","b"},  {"-.-.","c"},  {"-..","d"},
            {".","e"},     {"..-.","f"},  {"--.","g"},   {"....","h"},
            {"..","i"},    {".---","j"},  {"-.-","k"},   {".-..","l"},
            {"--","m"},    {"-.","n"},    {"---","o"},   {".--.","p"},
            {"--.-","q"},  {".-.","r"},   {"...","s"},   {"-","t"},
            {"..-","u"},   {"...-","v"},  {".--","w"},   {"-..-","x"},
            {"-.--","y"},  {"--..","z"},
            {"-----","0"}, {".----","1"}, {"..---","2"}, {"...--","3"},
            {"....-","4"}, {".....","5"}, {"----.","6"}, {"---..","7"},
            {"--...","8"}, {"-....","9"}, {"/","  "}
        };

    foreach (var letras in espacio)
    {
        Console.Write(presentar[letras.ToString()]);
    }
}