Console.WriteLine("Digite o número de horas de treinamento por dia:");
int horasTreinamento = int.Parse(Console.ReadLine());

int DiasdaSemana = 5;

double horasTreinamentoPorSemana = horasTreinamento * DiasdaSemana;

Console.WriteLine("O número de horas de treinamento por semana é: " + horasTreinamentoPorSemana);

double horasTotal = 1000;
double semanasNecessarias = totalHoras / horasPorSemana;
double diasNecessarios = semanasNecessarias * diasPorSemana;
double mesesNecessarios = semanasNecessarias / 4.5;

Console.WriteLine("Para você alcançar 1000 horas de treinamento, você precisará de:");
Console.WriteLine($"{semanasNecessarias} semanas");
Console.WriteLine($"{diasNecessarios} dias");
Console.WriteLine($"{mesesNecessarios} meses");



