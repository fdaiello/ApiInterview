using ApiInterview.Data;
using ApiInterview.Model;
using ApiInterview.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiInterview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly Operator _operator;
        private readonly CustomerApi _customerApi;
        private readonly AppDbContext _context;

        public ProcessController (ILogger<ProcessController> logger, Operator myOperator, CustomerApi customerApi, AppDbContext context)
        {
            _logger = logger;
            _operator = myOperator;
            _customerApi = customerApi;
            _context = context;

        }

        // GET: api/<ProcessController>
        [HttpGet]
        public async Task<Model.Task?> GetTask()
        {
            var task = await _customerApi.GetTaskAsync();
            return task;

        }

        // POST api/<ProcessController>
        [HttpPost]
        public async Task<string> PostTask(Model.Task task)
        {
            if (_context.Tasks == null)
            {
                return "Entity set 'AppDbContext.Tasks'  is null.";
            }

            _context.Tasks.Add(task);

            try
            {
                await _context.SaveChangesAsync();

                var result = new Result(task.Id, _operator.Calculate(task.Operation, task.Left, task.Right));

                _context.Results.Add(result);

                try
                {
                    await _context.SaveChangesAsync();

                    var msg = await _customerApi.PostResultAsync(result);

                    return msg;

                }
                catch (DbUpdateException)
                {
                    throw;
                }

            }

            catch (DbUpdateException)
            {
                throw;
            }

        }
    }
}
