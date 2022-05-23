using FakePayment.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedLibrary.ControllerBases;
using SharedLibrary.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakePayment.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FakePaymentsController : CustomBaseController
    {
        [HttpPost]
        public IActionResult ReceivePayment(PaymentDto paymentDto)
        {
            return CreateActionResultInstance(Response<NoContent>.Success(200));
        }
    }
}
