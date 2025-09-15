using API.services;
using Microsoft.AspNetCore.Mvc;

namespace API.controllers;

[ApiController]
[Route("[controller]")]
public class FinanceController : ControllerBase
{
    private readonly IFinanceService _service;
    
    public FinanceController(IFinanceService service)
    {
        _service = service;
    }
    
    [HttpGet]
    public decimal Index()
    {
        // IFinanceService service = new FinanceService();
        decimal result = _service.CalculateInterest(1000, 5);
        return result;
    }
}