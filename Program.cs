Console.WriteLine("Digite sua altura(m) e seu peso(Kg),cada um em uma linha: ");
string alturadigitada = Console.ReadLine()!;
string pesodigitado = Console.ReadLine()!;

double altura = Convert.ToDouble (alturadigitada);
double peso = Convert.ToDouble (pesodigitado);

double imc = peso / Math.Pow (altura, 2) ;

Console.WriteLine ("Seu IMC é: {imc}");




