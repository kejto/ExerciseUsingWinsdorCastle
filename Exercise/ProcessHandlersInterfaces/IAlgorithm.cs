using System.Collections.Generic;

namespace Exercise.ProcessHandlersInterfaces
{
    public interface IAlgorithm
    {
        List<string> ProcessInput(List<Field> fields);
    }
}