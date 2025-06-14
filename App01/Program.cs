// Este comentario es de una sola línea

/*
    Este es mi comentario de múltiples líneas 
    para mi curso de C# 12.0 y .NET 8.0
 */

using System;

// Mensajes de bienvenida
Console.WriteLine("Hello, World!");
Console.WriteLine("Este es una prueba de C# 12.0 y .NET 8.0");

// ---------------------------
// CONSTANTES EN C#
// ---------------------------

const double Pi = 3.1415926535;           // Constante de tiempo de compilación: no se puede modificar
const int MaximoIntentos = 5;             // Constante entera
const string MensajeBienvenida = "¡Bienvenido al curso!"; // Constante string

Console.WriteLine("\n--- CONSTANTES ---");
Console.WriteLine($"Constante Pi: {Pi}");
Console.WriteLine($"Constante MaximoIntentos: {MaximoIntentos}");
Console.WriteLine($"Constante Mensaje: {MensajeBienvenida}");

// Variables
string nombre = "Luis"; // Tipo de referencia que representa texto (cadena de caracteres)
var apellido = "Vasquez"; // Inferencia de tipo (el compilador detecta que es string)
Console.WriteLine($"Hola, {nombre} {apellido}!");

// ---------------------------
// TIPOS DE DATOS EN C# 12.0
// ---------------------------

Console.WriteLine("\n--- TIPOS DE VALOR ---");

// ---------------------------
// Tipos numéricos enteros
// ---------------------------

byte miByte = 255;             // Entero sin signo (0 a 255), 8 bits
sbyte miSByte = -128;          // Entero con signo (-128 a 127), 8 bits
short miShort = -32000;        // Entero corto con signo (-32,768 a 32,767), 16 bits
ushort miUShort = 65000;       // Entero corto sin signo (0 a 65,535), 16 bits
int miInt = 123456;            // Entero con signo (-2.1B a 2.1B), 32 bits
uint miUInt = 4000000000;      // Entero sin signo (0 a 4.2B), 32 bits
long miLong = 9223372036854775807; // Entero largo con signo, 64 bits
ulong miULong = 18446744073709551615; // Entero largo sin signo, 64 bits

// ---------------------------
// Tipos numéricos reales (punto flotante)
// ---------------------------

float miFloat = 3.14f;         // Número decimal de precisión simple, 32 bits
double miDouble = 3.1415926535; // Número decimal de doble precisión, 64 bits
decimal miDecimal = 123456.78901234567890m; // Alta precisión decimal (usado para dinero), 128 bits

// ---------------------------
// Otros tipos de valor
// ---------------------------

bool esEstudiante = true;      // Booleano: solo puede ser true o false
char inicial = 'L';            // Carácter Unicode (un solo símbolo entre comillas simples)

// ---------------------------
// Tipos anulables (Nullable)
// ---------------------------

int? edad = null;              // Tipo int que puede ser null (útil para bases de datos)
bool? aprobado = true;         // Tipo bool que también puede ser null

Console.WriteLine($"byte: {miByte}, sbyte: {miSByte}");
Console.WriteLine($"short: {miShort}, ushort: {miUShort}");
Console.WriteLine($"int: {miInt}, uint: {miUInt}");
Console.WriteLine($"long: {miLong}, ulong: {miULong}");
Console.WriteLine($"float: {miFloat}, double: {miDouble}, decimal: {miDecimal}");
Console.WriteLine($"bool: {esEstudiante}, char: {inicial}");
Console.WriteLine($"nullable int: {edad}, nullable bool: {aprobado}");

// ---------------------------
// Enum (conjunto de constantes)
// ---------------------------

Dia diaActual = Dia.Viernes; // Enumeración (tipo definido por el usuario con valores constantes)
Console.WriteLine($"\nenum: {diaActual}");

// ---------------------------
// Struct (estructura de valor compuesta)
// ---------------------------

Punto p = new Punto { X = 10, Y = 20 }; // Estructura definida por el usuario (tipo de valor)
Console.WriteLine($"struct: Punto({p.X}, {p.Y})");

// ---------------------------
// TIPOS DE REFERENCIA
// ---------------------------

Console.WriteLine("\n--- TIPOS DE REFERENCIA ---");

string saludo = "Hola mundo";     // Cadena de texto
object cualquierCosa = 42;        // Tipo base de todos los objetos en C#
dynamic dinamico = "Texto dinámico"; // Tipo dinámico, se evalúa en tiempo de ejecución
dinamico = 10.5;                  // Puede cambiar de tipo

int[] numeros = { 1, 2, 3 };      // Arreglo de enteros

Console.WriteLine($"string: {saludo}, object: {cualquierCosa}, dynamic: {dinamico}");
Console.WriteLine($"array: {string.Join(", ", numeros)}");

// ---------------------------
// Clase e interfaz
// ---------------------------

Persona persona = new() { Nombre = "Luis", Edad = 22 }; // Clase (tipo de referencia)
Console.WriteLine($"class: {persona.Nombre}, {persona.Edad}");

ISaludable s = persona; // Interface (contrato que define comportamiento)
s.Saludar();            // Método definido en la interfaz

// ---------------------------
// Delegado (referencia a métodos)
// ---------------------------

Operacion suma = (a, b) => Console.WriteLine($"Suma: {a + b}"); // Delegado con expresión lambda
suma(5, 10);

// ---------------------------
// Record (estructura inmutable con valor por contenido)
// ---------------------------

RegistroPersona rp = new("Ana", 30); // Tipo record (inmutable por defecto)
Console.WriteLine($"record: {rp.Nombre}, {rp.Edad}");

// ---------------------------
// Tuplas y tipos anónimos
// ---------------------------

var tupla = (Nombre: "Carlos", Edad: 25); // Tupla con nombres
Console.WriteLine($"tupla: {tupla.Nombre}, {tupla.Edad}");

var anonimo = new { Nombre = "Eva", Curso = "C#" }; // Tipo anónimo, útil para proyecciones rápidas
Console.WriteLine($"anónimo: {anonimo.Nombre}, {anonimo.Curso}");

// ---------------------------
// Finalizar ejecución
// ---------------------------

Console.WriteLine("\nPresiona cualquier tecla para cerrar el programa...");
Console.ReadKey();

// ---------------------------
// Tipos auxiliares definidos
// ---------------------------

// Enum personalizado
enum Dia { Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo }

// Estructura (tipo de valor compuesto)
struct Punto
{
    public int X;
    public int Y;
}

// Clase e interfaz
class Persona : ISaludable
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public void Saludar()
    {
        Console.WriteLine($"Hola, soy {Nombre} y tengo {Edad} años.");
    }
}

// Interfaz (contrato)
interface ISaludable
{
    void Saludar();
}

// Delegado (firma de método)
delegate void Operacion(int a, int b);

// Record (estructura de datos inmutable)
record RegistroPersona(string Nombre, int Edad);
