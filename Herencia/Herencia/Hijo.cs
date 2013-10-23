using System;
namespace herencia{
	
public class Hijo : Persona {
public string parentesco;
public Hijo() {
}
public override String informacion (){
return "informacion del hijo \n" 
	+ "Nombre:" + this.nombre + "\n" 
	+ "Edad:" + this.edad + "\n" 
	+"parentesco:" + this.parentesco+ "\n";

}
}
}