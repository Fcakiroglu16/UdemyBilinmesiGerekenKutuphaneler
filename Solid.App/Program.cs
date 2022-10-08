// See https://aka.ms/new-console-template for more information
using Solid.App.OCPBad;

Console.WriteLine("Hello, World!");



ProductRepository productRepository = new ProductRepository();

productRepository.GetAll().ForEach(x =>
{
    Console.WriteLine($"{x}");
});
