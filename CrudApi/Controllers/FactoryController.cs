﻿using Crud_UI.Models;
using CrudApi.DAL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactoryController : ControllerBase
    {
        IFactoryDal _factoryDal;
        public FactoryController(IFactoryDal factoryDal)
        {
            _factoryDal = factoryDal;
        }

        [HttpPost("add-factory")]
        public async Task<IActionResult> AddFactory(Factory factory)
        {
            bool returnData = _factoryDal.AddFactories(factory);
            return Ok(returnData);
        }

        [HttpGet("get-factory")]
        public async Task<IActionResult> GetFactory(int factoryId)
        {
            Factory returnData = _factoryDal.GetFactories(factoryId);
            return Ok(returnData);
        }

        [HttpGet("get-all-factory")]
        public async Task<IActionResult> GetAllFactory()
        {
            List<Factory> returnData = _factoryDal.GetAllFactories();
            return Ok(returnData);

        }
    }
}
