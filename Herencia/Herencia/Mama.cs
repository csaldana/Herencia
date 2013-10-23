using System;
namespace Herencia{
	
 public class Mama : Persona{
		
public string parentesco;

public Mama (){
}
public override string informacion (){
return "informacion de Mama \n" + "Nombre:" + this.nombre + "\n" +
"Edad:" + this.edad + "\n" +"parentesco:" + this.parentesco+ "\n";
}
}
}
