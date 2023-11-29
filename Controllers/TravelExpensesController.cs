using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PracticalLib.Data;
using PracticalLib.Logic;
using PracticalLib.Models;

/*
 * Student Name: Jadepat Chernsonthi
 * Student Number: 041074866
 * Student Email: cher0151@algonquinlive.com
 * Course & Section #: 23F_CST8333_370
 */
namespace PracticalProject2.Controllers
{
    [Route("api/[controller]/[action]")]
    public class TravelExpensesController : ControllerBase
    {
        private readonly ILogger<TravelExpensesController> _logger;
        private TravelExpensesLogic logic = new TravelExpensesLogic();

        /// <summary>
        /// Initializes a new instance of the <see cref="TravelExpensesController"/> class.
        /// </summary>
        /// <param name="logger">The logger for the controller.</param>
        public TravelExpensesController(ILogger<TravelExpensesController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Retrieves all travel expenses using HttpGet.
        /// </summary>
        /// <returns>Http status code according to scenario and list of travel expenses when successful</returns>
        [HttpGet]
        public IActionResult GetTravelExpenses(int numOfInstances, int numOfSkip)
        {
            try
            {
                var travelExpenses = logic.Get(numOfInstances, numOfSkip);
                return StatusCode(200, travelExpenses);
            }
            catch (NullReferenceException ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(404, ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Retrieves travel expense by ID using HttpGet.
        /// </summary>
        /// <param name="id">ID of the travel expense</param>
        /// <returns>Http status code according to scenario and a travel expense object</returns>
        [HttpGet]
        public IActionResult GetTravelExpenseByID(string id)
        {
            try
            {
                var travelExpense = logic.GetByID(id);
                return StatusCode(200, travelExpense);
            }
            catch (NullReferenceException ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(404, ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(500, ex.Message);
            }
            
        }

        /// <summary>
        /// Retrieves travel expenses by reference number using HttpGet.
        /// </summary>
        /// <param name="refNumber">reference number of travel expenses</param>
        /// <returns>Http status code according to scenario and list of travel expenses when successful</returns>
        [HttpGet]
        public IActionResult GetTravelExpensesByRefNumber(string refNumber) 
        {
            try
            {
                var travelExpenses = logic.GetByRefNumber(refNumber);
                return StatusCode(200, travelExpenses);
            }
            catch (NullReferenceException ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(404, ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(500, ex.Message);
            }
            
        }

        /// <summary>
        /// Retrieves number of travel expenses instances using HttpGet.
        /// </summary>
        /// <returns>Http status code according to scenario and number of instances when successful</returns>
        [HttpGet]
        public IActionResult GetTravelExpensesCount()
        {
            try
            {
                var count = logic.GetCount();
                return StatusCode(200, count);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Retrieves list of travel expenses by any string query using HttpGet.
        /// </summary>
        /// <param name="query">The string to search for.</param>
        /// <returns>Http status code according to scenario and list of travel expenses when successful</returns>
        [HttpGet]
        public IActionResult GetTravelExpensesSearch(string query) 
        {
            try
            {
                var result = logic.Search(query);
                return StatusCode(200, result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Deletes travel expenses by id using HttpDelete.
        /// </summary>
        /// <param name="id">ID of the travel expense</param>
        /// <returns>Http status code according to scenario</returns>
        [HttpDelete]
        public IActionResult DeleteTravelExpense(string id)
        {
            try
            {
                logic.Delete(id);
                return StatusCode(200, "Remove Successful");
            }
            catch(NullReferenceException ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(404, ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(500, ex.Message);
            }
        }

        /// <summary>
        /// Insert travel expense entity to dataset using HttpPost
        /// </summary>
        /// <param name="travelExpense">The entity object from body</param>
        /// <returns>Http status code according to scenario</returns>
        [HttpPost]
        public IActionResult PostTravelExpense([FromBody] TravelExpensesEntity travelExpense) 
        {
            try
            {
                logic.Insert(travelExpense);
                return StatusCode(201, "Insert Successful");
            }
            catch (NullReferenceException ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(500, ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(400, ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(500, ex.Message);
            }
            
        }

        /// <summary>
        /// Updates travel expense entity using HttpPut
        /// </summary>
        /// <param name="travelExpense">The entity object from body</param>
        /// <returns>Http status code according to scenario</returns>
        [HttpPut]
        public IActionResult PutTravelExpense([FromBody] TravelExpensesEntity travelExpense)
        {
            try
            {
                logic.Update(travelExpense);
                return StatusCode(201, "Update Successful");
            }
            catch (NullReferenceException ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(404, ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(500, ex.Message);
            }
            
        }
    }
}
