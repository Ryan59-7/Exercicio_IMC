Console.WriteLine("Digite sua altura(m): ");
string alturadigitada = Console.ReadLine()!;

Console.WriteLine("Digite seu peso: ");
string pesodigitado = Console.ReadLine()!;

double altura = Convert.ToDouble (alturadigitada);
double peso = Convert.ToDouble (pesodigitado);

double imc = peso / Math.Pow (altura, 2) ;

Console.WriteLine ($"Seu IMC é: {imc} kg/m²");




