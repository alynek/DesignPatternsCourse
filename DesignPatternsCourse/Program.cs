//using DesignPatternsCourse.Factory;
//using DesignPatternsCourse.Factory.EnergiaBase;
//using DesignPatternsCourse.Factory.RevestimentoBase;
//using Microsoft.Extensions.DependencyInjection;

////Padrão factory
//var serviceProvider = new ServiceCollection()
//    .AddScoped<IRevestimento, RevestimentoBaseTerran>()
//    .AddScoped<IEnergia, EnergiaBaseTerran>()
//    .BuildServiceProvider();

//var revestimento = serviceProvider.GetService<IRevestimento>();
//var energia = serviceProvider.GetService<IEnergia>();

//var baseterran = new FabricaBaseTerran(revestimento, energia);


//Padrão state