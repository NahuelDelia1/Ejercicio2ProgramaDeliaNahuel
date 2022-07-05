using System;

namespace Ejercicio2ProgramaDeliaNahuel {
	class program {

		static void Main(string[] args) {
			double ladoa;
			double ladob;
			double ladoc;
			double p;
			double perimetro;
			double superficie;
			Console.WriteLine("Ingrese los datos:");
			Console.Write("LADO A:");
			ladoa = Double.Parse(Console.ReadLine());
			Console.Write("LADO B:");
			ladob = Double.Parse(Console.ReadLine());
			Console.Write("LADO C:");
			ladoc = Double.Parse(Console.ReadLine());
			p = (ladoa+ladob+ladoc)/2;
			superficie = Math.Sqrt(p*(p-ladoa)*(p-ladob)*(p-ladoc));
			perimetro = (ladoa+ladob+ladoc);
			Console.WriteLine("La superficie del triangulo es:"+superficie);
			Console.WriteLine("El perimetro del triangulo es:"+perimetro);
			if (ladoa>0 && ladob>0 && ladoc>0) {
				if (ladoa<ladob+ladoc && ladob<ladoa+ladoc && ladoc<ladoa+ladob) {
					if (ladoa*ladoa==ladob*ladob+ladoc*ladoc) {
						Console.WriteLine("Se formo un triangulo rectangulo.");
					} else {
						if (ladoa*ladoa>ladob*ladob+ladoc*ladoc) {
							Console.WriteLine("Se formo un triangulo obtusangulo.");
						} else {
							if (ladoa*ladoa<ladob*ladob+ladoc*ladoc) {
								Console.WriteLine("Se formo un triangulo acutangulo.");
							} else {
								Console.WriteLine("Error de calculo");
							}
						}
					}
				}
			}
		}

	}

}


