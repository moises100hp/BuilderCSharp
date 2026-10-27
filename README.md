# Padrão Builder — exemplo de montagem de hambúrguer

Este projeto de estudo demonstra o padrão de projeto **Builder** usando a montagem de hambúrgueres. A ideia é separar a criação de um objeto com várias opções da própria representação desse objeto, permitindo configurá-lo em etapas e combinar apenas os ingredientes desejados.

## Como o exemplo funciona

O produto é um `Hamburguer`, que armazena o tipo de pão, o tipo de carne e a presença de ingredientes opcionais. O `HamburguerBuilder` oferece métodos encadeáveis para configurar essas propriedades. Cada método retorna o próprio builder (`this`), formando uma interface fluente; ao final, `Build()` retorna o hambúrguer montado.

O programa usa uma nova instância do builder para cada receita. Assim, as configurações de um hambúrguer não são reaproveitadas no seguinte.

## Estrutura do projeto

- [`Builder/Hamburguer.cs`](Builder/Hamburguer.cs): produto criado pelo padrão, com os dados do hambúrguer e sua descrição.
- [`Builder/HamburguerBuilder.cs`](Builder/HamburguerBuilder.cs): builder concreto, responsável por configurar o produto e entregá-lo por meio de `Build()`.
- [`Builder/Program.cs`](Builder/Program.cs): cliente do builder; define as receitas e exibe seus resultados.

## Receitas demonstradas

- **X-Salada**: pão branco, carne bovina e salada.
- **X-Bacon**: pão branco, carne bovina, bacon, batata palha e queijo.
- **X-Tudo**: pão branco, carne bovina, bacon, batata palha, queijo e salada.

Uma receita é montada encadeando as opções necessárias:

```csharp
var hamburguer = new HamburguerBuilder()
    .SetTipoPao("Branco")
    .SetTipoCarne("Bovina")
    .TemBacon()
    .TemQueijo()
    .Build();
```

Os métodos `TemBacon()`, `TemBatataPalha()`, `TemQueijo()` e `TemSalada()` ativam cada ingrediente opcional. Para criar outra combinação, basta escolher uma sequência diferente de opções.

## Executar

É necessário ter o SDK do .NET 8 instalado. Na raiz do repositório, execute:

```bash
dotnet run --project Builder/Builder.csproj
```

O programa imprime a descrição dos três hambúrgueres no console.
