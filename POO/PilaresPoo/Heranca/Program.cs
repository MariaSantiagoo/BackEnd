using Heranca;


Carro fusca = new Carro();
Veiculo generic = new Veiculo();

Aviao Airbus230 = new Aviao();
Moto HarleyDavison = new Moto();
HarleyDavison.Marca = "Harley Davison";
HarleyDavison.Modelo = "Fat Boy";
HarleyDavison.Ano = 2028;
HarleyDavison.SomDaMoto();
HarleyDavison.ExibirInfo();

Airbus230.Marca = "LATAM airlines";
Airbus230.Modelo = "Airbus 320";
Airbus230.Ano = 2025;
Airbus230.QtdAssentos = 67;
Airbus230.Voar();
Airbus230.ExibirInfo();

