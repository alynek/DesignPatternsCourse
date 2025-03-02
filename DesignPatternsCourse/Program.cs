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

using DesignPatternsCourse.State;

Contexto contexto = new(new Donkey());
contexto.Troca();


#endregion
