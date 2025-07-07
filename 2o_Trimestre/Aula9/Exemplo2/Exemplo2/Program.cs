namespace Exemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> pessoa = new Dictionary<string, int>
            { {"João",17},{"Maria",18},{"Pedro",16},{"Ana",19},{"Lucas", 20} };
            pessoa.Add("Carla",21);
            pessoa["Pedro"] = 17;
            bool contemF = pessoa.ContainsKey("Fernando");
            int maior = 0;
            foreach(var i in pessoa)
            {
                if (i.Value > 18)
                {
                    maior++;
                }
            }
            int igual = 0;
            foreach(var i in pessoa)
            {
                if (i.Value == 17)
                {
                    igual++;
                }
            }
            pessoa.Remove("Ana");
            foreach(var i in pessoa)
            {
                Console.WriteLine($"Aluno: {i.Key}, Idade: {i.Value} ");
            }
        }
    }
}
