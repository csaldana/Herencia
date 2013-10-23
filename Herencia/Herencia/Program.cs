/*
 * Created by SharpDevelop.
 * User: jonathan
 * Date: 19/10/2013
 * Time: 08:11 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Herencia{
	
	public class principal{
		
		public void polimorfismo(){
			ArraList arreglo = new ArrayList();
			Hijo hijo = new Hijo();
			hijo.nombre = "jonathan";
			hijo.apellido = "saldañan";
			hijo.edad = 20;
			hijo.parentesco = "Hijo"
			arreglo.Add(hijo);
			
			Mama mama = new Mama();
			mama.nombre = "Maria";
			mama.apellido = "Saldaña";
			mama.edad = 38;
			mama.parentesco = "Madre";
			arreglo.Add(mama);
			foreach(Persona persona in arreglo){
				Console.WriteLine(persona.informacion());
			}
			public static void Main(string[] arg){
				principal principal = new principal();
				principal.polimorfismo();
			}
		}
	}


	