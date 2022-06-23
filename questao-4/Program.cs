using Model;


var Contribuidores = new List<Contribuidor>
{
    new Contribuidor
        {
            Estado = "SP",
            Contribuicao = 67836.43
        },
    new Contribuidor
        {
            Estado="RJ",
            Contribuicao=36678.66
        },
    new Contribuidor
        {
            Estado="MG",
            Contribuicao=29229.88
        },
    new Contribuidor
        {
            Estado="ES",
            Contribuicao=27165.48
        },
    new Contribuidor
        {
            Estado="Outros",
            Contribuicao=19849.53
        }
};

var Total = Contribuidores.Sum(x => x.Contribuicao);
Console.WriteLine("Contribuidor         %valor\n");

foreach (var Contribuidor in Contribuidores)
{
    Console.WriteLine($"{Contribuidor.Estado,8} {((Contribuidor.Contribuicao / Total) * 100).ToString("F"),17}%");
}
