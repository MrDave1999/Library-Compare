# Library-Compare
[![LibraryCompare](https://shields.southcla.ws/badge/SCompare-v1.0-2f2f2f.svg?style=flat-square)](https://github.com/MrDave1999/Library-Compare)

En C# puedes comparar cadenas con el operador ==, dado que la clase string sobrecarga automáticamente este operador; sin embargo, no se puede hacer una igualdad sin que el caso sea ignorado.

Por ejemplo:
```C#
using System;

class Program
{
	  static void Main(string[] args)
    {
		string a = "Hola";
		string b = "HOLA";
		if(a == b)
			Console.Write("TRUE");
		Console.Read();
	}
}
```
Usando el operador sobrecargado de la clase string, esa condicional dará como resultado un false, esto quiere decir, que en ningún momento se va a imprimir en pantalla el mensaje de "TRUE"; si embargo, con esta biblioteca si se podrá usar el operador == para comparar cadenas sin importar el caso: Hola == HOLA (Verdadero).

## Instalación

Para poder instalar, debes añadir una referencia de la biblioteca `sCompare.dll` en el proyecto actual del programa. Esto se logra yendo a la pestaña de Proyecto/Agregar referencia (en esta opción buscas el DLL y luego le das aceptar).

## Constructores

`SCompare(string)`: Crea una nueva instancia de la clase SCompare e indica la segunda cadena para la comparación.
`SCompare(bool)`: Crea una nueva instancia de la clase SCompare e indica si el caso es ignorado o no.

Si el parámetro recibe un false, el caso no es ignorado, esto quiere decir, que al momento de comparar un HOLA == hola dará como resultado un false. También se debe tomar en cuenta que el caso por defecto es ignorado.

`SCompare(string, bool)`: Crea una nueva instancia de la clase SCompare e indica la segunda cadena para la comparación y hace que el caso pueda ser ignorado o no.

## Propiedades

`IgnoreCase`: Hace que el caso pueda ser ignorado o no.

`Strin`: Permite asignar la segunda cadena para la comparación.

## Uso

- Usando los constructores:
```C#
using System;
using sCompare;

class Program
{
	static void Main(string[] args)
    {
		SCompare a = new SCompare("Hola");
		SCompare b = new SCompare("Pepe", false);
		if(a == "HOLA") //La condicional da como resultado TRUE
			Console.Write(" ");
		
		if(b == "PEPE") //La condicional da como resultado FALSE
			Console.Write(" ");
		
		Console.Read();
	}
}
```
- Usando las propiedades:
```C#
using System;
using sCompare;

class Program
{
	static void Main(string[] args)
  {
		SCompare a = new SCompare();
		SCompare b = new SCompare();
		
		a.Strin = "Hola";
		b.Strin = "Pepe";
		b.IgnoreCase = false;
		
		if(a == "HOLA") //La condicional da como resultado TRUE
			Console.Write("TRUE");
		
		if(b == "PEPE") //La condicional da como resultado FALSE
			Console.Write("TRUE");
		
		Console.Read();
	}
}
```

## Créditos

- [MrDave](https://github.com/MrDave1999/Library-Compare)

- [Microsoft](https://github.com/microsoft)
