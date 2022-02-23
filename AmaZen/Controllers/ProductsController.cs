using System.Collections.Generic;
using AmaZen.Models;
using AmaZen.Services;
using Microsoft.AspNetCore.Mvc;

namespace AmaZen.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ProductsController : ControllerBase
  {
    private readonly ProductsService _ps;

    public ProductsController(ProductsService ps)
    {
      _ps = ps;
    }

    [HttpGet]
    public ActionResult<List<Product>> Get()
    {
      try
      {
        return Ok(_ps.Get());
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}