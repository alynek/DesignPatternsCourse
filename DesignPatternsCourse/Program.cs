using DesignPatternsCourse.EnergiaBase;
using DesignPatternsCourse.Factory;
using DesignPatternsCourse.RevestimentoBase;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddScoped<IRevestimento, RevestimentoBaseTerran>()
    .AddScoped<IEnergia, EnergiaBaseTerran>()
    .BuildServiceProvider();

var revestimento = serviceProvider.GetService<IRevestimento>();
var energia = serviceProvider.GetService<IEnergia>();

var baseterran = new FabricaBaseTerran(revestimento, energia);
