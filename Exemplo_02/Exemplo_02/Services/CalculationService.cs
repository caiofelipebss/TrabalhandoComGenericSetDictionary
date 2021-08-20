using System;
using System.Collections.Generic;
using System.Text;

namespace Exemplo_02.Services
{
    class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable // Minha Lista list deve ser de um tipo T qualquer desde que seja IComparable (possa ser comparada).
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("The list cannot be empty.");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
