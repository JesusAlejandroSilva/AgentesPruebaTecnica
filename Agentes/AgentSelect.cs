using Agentes.Interfaces;
using Agentes.Repositories;

namespace Agentes
{
    
        public static class AgentSelect
        {
            public static IAgent CreateAgent(char agentType)
            {
                switch (char.ToUpper(agentType))
                {
                    case 'A':
                        return new AgentA();
                    case 'B':
                        return new AgentB();
                    case 'C':
                        return new AgentC();
                    default:
                        throw new ArgumentException("Tipo de agente no válido.");
                }
            }
        }
    
}
