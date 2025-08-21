// Solicita ao usuário o número de horas de treinamento por dia
Console.WriteLine("Digite o número de horas de treinamento por dia:");
int horasTreinamento = int.Parse(Console.ReadLine());

int DiasdaSemana = 5; // Assume 5 dias de treino por semana

// Calcula o total de horas de treino por semana
double horasTreinamentoPorSemana = horasTreinamento * DiasdaSemana;
Console.WriteLine("O número de horas de treinamento por semana é: " + horasTreinamentoPorSemana);

double horasTotal = 1000; // Total de horas desejadas
double semanasNecessarias = horasTotal / horasTreinamentoPorSemana; // Calcula semanas necessárias
double diasNecessarios = semanasNecessarias * DiasdaSemana;          // Converte para dias
double mesesNecessarios = semanasNecessarias / 4.5;                  // Converte para meses (aprox. 4,5 semanas por mês)

// Exibe o resultado
Console.WriteLine("Para você alcançar 1000 horas de treinamento, você precisará de:");
Console.WriteLine($"{semanasNecessarias} semanas");
Console.WriteLine($"{diasNecessarios} dias");
Console.WriteLine($"{mesesNecessarios} meses");