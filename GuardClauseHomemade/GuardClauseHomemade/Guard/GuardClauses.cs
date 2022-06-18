using System;


namespace GuardClauseHomemade.Guard
{
    internal class GuardClauses
    {
        public bool EvaluateInput<T>(Func<T, bool> condicion, string message, T data)
        {
            return condicion(data) ? true : throw new Exception(message);
        }
    }
}
