/* 3. Herança – Sistema de Veículos
Objetivo: aplicar hierarquia de classes e reaproveitamento de código.
Descrição:
Crie uma classe base Veiculo com propriedades: Marca, Modelo, Ano.
Crie classes derivadas Carro, Moto e Caminhao.
Cada uma deve ter uma propriedade específica (ex: NumeroDePortas para Carro, CapacidadeDeCarga para Caminhao).
Crie um método ExibirInformacoes() em Veiculo e sobrescreva nas subclasses para mostrar dados adicionais. */

using _03;

Vehicle[] vehicles = new Vehicle[3];

vehicles[0] = new Car();

vehicles[0].SetBrand("Corolla");
vehicles[0].SetModel("Toyota");
vehicles[0].SetYear(2020);
((Car)vehicles[0]).SetDoorsNumber(5);
((Car)vehicles[0]).SetGasType("Flex");
((Car)vehicles[0]).ShowInfo();

Console.WriteLine("\n--------------------------------------\n");

vehicles[1] = new Motorcicle();

vehicles[1].SetBrand("Yamaha");
vehicles[1].SetModel("FZ25");
vehicles[1].SetYear(2020);
((Motorcicle)vehicles[1]).SetPreviousOwners(2);
((Motorcicle)vehicles[1]).SetGasType("Flex");
((Motorcicle)vehicles[1]).ShowInfo();

Console.WriteLine("\n--------------------------------------\n");

vehicles[2] = new Truck();

vehicles[2].SetBrand("Volvo");
vehicles[2].SetModel("X");
vehicles[2].SetYear(2025);
((Truck)vehicles[2]).SetLoudCapacity(200);
((Truck)vehicles[2]).ShowInfo();









