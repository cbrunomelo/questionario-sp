namespace Model
{
    [Serializable]
    public class faturamento : IComparable<faturamento>
    {
        public int Dia { get; set; }
        public double Valor { get; set; }

        public int CompareTo(faturamento? other)
        {
            if (Valor == other?.Valor)
                return 0;

            if (Valor > other?.Valor)
                return 1;
            return -1;
        }
    }



}