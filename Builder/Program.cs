using Builder;

HamburguerBuilder hamburguerBuilder = new();

//X-Salada
var XSalada = 
    hamburguerBuilder
    .SetTipoPao("Branco")
    .SetTipoCarne("Bovina")
    .TemSalada()
    .Build();

//X-Bacon
hamburguerBuilder = new();
var XBacon = 
    hamburguerBuilder
    .SetTipoPao("Branco")
    .SetTipoCarne("Bovina")
    .TemBacon()
    .TemBatataPalha()
    .TemQueijo()
    .Build();

//X-Tudo
hamburguerBuilder = new();
var XTudo = 
    hamburguerBuilder
    .SetTipoPao("Branco")
    .SetTipoCarne("Bovina")
    .TemBacon()
    .TemBatataPalha()
    .TemQueijo()
    .TemSalada()
    .Build();

Console.WriteLine(XSalada.getDescricao());
Console.WriteLine("===============================================");
Console.WriteLine(XBacon.getDescricao());
Console.WriteLine("===============================================");
Console.WriteLine(XTudo.getDescricao());