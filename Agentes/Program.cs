using Agentes;
using Agentes.Interfaces;


class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione el agente (A, B o C): ");
        char agentType = char.ToUpper(Console.ReadKey().KeyChar);

        IAgent agent = AgentSelect.CreateAgent(agentType);

        Console.WriteLine("\nFuncionalidad 1 - Obtener Media");
        Console.WriteLine("Ingrese números separados por espacios:");
        List<double> numeros = LeerNumeros();
        double media = agent.GetMedia(numeros);
        Console.WriteLine($"El resultado de la media es: {media}");

        Console.WriteLine("\nFuncionalidad 2 - Escalera");
        Console.WriteLine("Ingrese un número entero para la escalera:");
        int n = int.Parse(Console.ReadLine());
        string staircase = agent.GetStartCase(n);
        Console.WriteLine("La escalera es:\n" + staircase);

        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }

    static List<double> LeerNumeros()
    {
        string[] numerosStr = Console.ReadLine().Split(' ');
        return numerosStr.Select(double.Parse).ToList();
    }
}
