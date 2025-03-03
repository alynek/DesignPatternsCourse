#region padrão factory

//using DesignPatternsCourse.Factory;
//using DesignPatternsCourse.Factory.EnergiaBase;
//using DesignPatternsCourse.Factory.RevestimentoBase;
//using Microsoft.Extensions.DependencyInjection;

//var serviceProvider = new ServiceCollection()
//    .AddScoped<IRevestimento, RevestimentoBaseTerran>()
//    .AddScoped<IEnergia, EnergiaBaseTerran>()
//    .BuildServiceProvider();

//var revestimento = serviceProvider.GetService<IRevestimento>();
//var energia = serviceProvider.GetService<IEnergia>();

//var baseterran = new FabricaBaseTerran(revestimento, energia);

#endregion

#region padrão state

using DesignPatternsCourse.State.Exemplo2;
using DesignPatternsCourse.State.Exemplo2.Implementacao;
using Microsoft.Extensions.DependencyInjection;

//Exemplo1

//Personagem contexto = new(new Donkey());
//contexto.Troca();
//contexto.Troca();
//contexto.Troca();
//contexto.Troca();


//Exemplo2

var serviceProvider = new ServiceCollection()
    .AddScoped<IEstadoDocumento, Inativo>()
    .AddScoped<IEstadoDocumento, Publicado>()
    .AddScoped<IEstadoDocumento, Rascunho>()
    .BuildServiceProvider();

//um documento sempre vai começar  no modo rascunho
var rascunho = serviceProvider.GetService<IEstadoDocumento>();

Documento documento = new(rascunho);
//Publicando um documento que estava em modo rascunho
documento.Publicar();

//Inativando um documento que estava em modo publicado
documento.Inativar();

//Publicando um documento que estava em modo inativo
documento.Publicar();

//Publicando um documento que estava em modo rascunho
documento.Publicar();

#endregion
