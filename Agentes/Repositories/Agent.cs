using Agentes.Interfaces;
using System.Text;

namespace Agentes.Repositories
{
    public class AgentA : IAgent
    {
        public double GetMedia(List<double> numbers)
        {
            return numbers.Sum()/ numbers.Count();
        }

        public string GetStartCase(int n)
        {
            if (n <= 0 || n >= 100)
            {
                throw new ArgumentException("El valor de 'n' debe estar en el rango 0 < n < 100");
            }

            StringBuilder staircase = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                staircase.Append(new string(' ', n - i));

                staircase.Append(new string('#', i));

                if (i < n)
                {
                    staircase.AppendLine();
                }
            }

            return staircase.ToString();
        }
    }

}
public class AgentB : IAgent
{
    public double GetMedia(List<double> numbers)
    {
        return numbers.Sum() / numbers.Count();
    }

    public string GetStartCase(int n)
    {
        if (n <= 0 || n >= 100)
        {
            throw new ArgumentException("El valor de 'n' debe estar en el rango 0 < n < 100");
        }

        StringBuilder staircase = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            staircase.Append(new string(' ', i));

            staircase.Append(new string('#', n - i));

            if (i < n - 1)
            {
                staircase.AppendLine();
            }
        }

        return staircase.ToString();
    }
}

public class AgentC : IAgent
{
    public double GetMedia(List<double> numbers)
    {
        numbers.Sort();

        int middle = numbers.Count / 2;
        return numbers.Count % 2 == 0
            ? (numbers[middle - 1] + numbers[middle]) / 2
            : numbers[middle];
    }

    public string GetStartCase(int n)
    {
        if (n <= 0 || n >= 100)
        {
            throw new ArgumentException("El valor de 'n' debe estar en el rango 0 < n < 100");
        }

        StringBuilder staircase = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            staircase.Append(new string(' ', n - i));

            staircase.Append(new string('#', i * 2 + 1));

            staircase.AppendLine();
        }
        for (int i = n - 2; i >= 0; i--)
        {
            staircase.Append(new string(' ', n - i));

            staircase.Append(new string('#', i * 2 + 1));
            if (i > 0)
            {
                staircase.AppendLine();
            }
        }
        return staircase.ToString();
    }
}
