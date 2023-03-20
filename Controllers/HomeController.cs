using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "João da Silva", "123.456.789-00", "joao.silva@hotmail.com", "Scooby");
        Cliente cliente2 = new Cliente(02, "Maria Freire", "323.256.789-03", "mariafreire12@gmail.com", "Leitinho");
        Cliente cliente3 = new Cliente(03, "Luiz Henrique", "572.290.114-97", "luis.hen@hotmail.com", "Garfield");
        Cliente cliente4 = new Cliente(04, "José Souza", "382.553.998-12", "jose.souza@hotmail.com", "Biscoito");
        Cliente cliente5 = new Cliente(05, "Ana Oliveira", "111.222.333-44", "ana.oliveira25@gmail.com", "Mimi");

        List<Cliente> listaClientes = new List<Cliente>();

        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(01, "SK Med", "18.255.298/0001-79", "Skmed@med.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Bat Tech", "23.245.198/0003-76", "battech@tech.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Dog Brinc", "14.315.238/0002-71", "dogbrinc@dog.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Cat Prod", "54.835.838/0005-12", "catprod@prod.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Pet Bom", "89.538.238/0008-32", "petbom@tec.com");

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();

        listaFornecedores = new List<Fornecedor>();

        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
