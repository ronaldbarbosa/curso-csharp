namespace RestricoesGenerics.Services
{
    internal class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0) throw new ArgumentException("The list can not be empty");

            T max = list[0];
            for (int i = 1; i < list.Count; i++) 
            {
                if (list[i].CompareTo(max) > 0) max = list[i];
                //  1 = list[i] > max
                // -1 = list[i] < max
                //  0 = list[i] = max
            }

            return max;
        }
    }
}
