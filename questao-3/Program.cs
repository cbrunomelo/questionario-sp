using Model;
using Newtonsoft.Json;

string filejson = @".\dados\dados.json";

if (File.Exists(filejson))
{
    var faturamentos = JsonConvert.DeserializeObject<List<faturamento>>(File.ReadAllText(filejson));


    Console.WriteLine($"Menor valor do mês: {faturamentos.Min().Valor}");
    Console.WriteLine($"Maior valor do mês: {faturamentos.Max().Valor}");

    //remover os dias sem faturamento
    var FaturamentosSemDiasNulo = faturamentos.FindAll(x => x.Valor > 0);

    Console.WriteLine($"Menor valor do mês sem considerar dias nulo: {FaturamentosSemDiasNulo.Min().Valor}");
    Console.WriteLine($"Maior valor do mês: {FaturamentosSemDiasNulo.Max().Valor}");
    var media = (FaturamentosSemDiasNulo.Sum(x => x.Valor)) / FaturamentosSemDiasNulo.Count;

    var FaturamentosAcimaDaMedia = FaturamentosSemDiasNulo.FindAll(x => x.Valor > media);
    Console.WriteLine($"O número de dias com faturamento acimda da media são de {FaturamentosAcimaDaMedia.Count} dias");

}


