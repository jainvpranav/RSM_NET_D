using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pilot.Models;
using Microsoft.EntityFrameworkCore;

namespace Pilot.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Dashboard()
    {
        var toOrder = _context.Database.SqlQuery<string>($"SELECT P.ProductName AS ItemType FROM Products P WHERE ProductId IN (SELECT MIN(ProductId) FROM Sales);").ToList();
        var mostSelling = _context.Database.SqlQuery<string>($"SELECT P.ProductName AS ItemType FROM Products P WHERE ProductId IN (SELECT MAX(ProductId) FROM Sales);").ToList();
        var totalSales = _context.Database.SqlQuery<double>($"SELECT SUM(S.Profit+P.CostPrice) AS total_sales FROM Sales S, Products P WHERE S.ProductId = P.ProductId;").ToList();
        //string MaxItemType = _context.DashSP.FromSqlRaw("Most_Sold").ToList()[0].MaxItemType;
        float sumProfit = _context.Sales.Sum(s=>s.Profit);
        float sumInvestment = _context.Products.Sum(s => s.CostPrice);
        Dashboard dashboard = new Dashboard
        {
            sumProfit = sumProfit,
            sumInvestment = sumInvestment,
            toOrder = toOrder,
            mostSelling = mostSelling,
            totalsales= totalSales
        };
        return View(dashboard);
    }

    public IActionResult Customer()
    {
        var customers = _context.Customers.ToList();
        return View(customers);
    }

    public IActionResult Sales()
    {
        var sales = _context.Sales.ToList();
        return View(sales);
    }

    public IActionResult Dealers()
    {
        var dealers = _context.Dealers.ToList();
        return View(dealers);
    }

    public IActionResult Inventory()
    {
        var products = _context.Products.ToList();
        return View(products);
    }

    //[HttpPost]
    //public ActionResult Customeradd([Bind("CustomerName, Phnum")]Customers c)
    //{
    //    //var message = viewModel.Message(c);
    //    Console.WriteLine(c.CustomerName, c.Phnum);
    //}

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
