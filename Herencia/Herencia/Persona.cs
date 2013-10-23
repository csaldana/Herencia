
using System;
namespace herencia{
	
public class Persona 
{
public string nombre;
public string apellido;
public int edad;

public void persona() {
this.nombre = "";
this.apellidos = "";
this.edad=0;
}
public virtual String informacion(){
return "Informacion de la persona \n" + "Nombre:" + this.nombre + "\n" + 
"Edad:" + this.edad;
}
}
}