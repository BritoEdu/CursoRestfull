using Microsoft.AspNetCore.Mvc;

namespace CursoApiRestfull.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {

        private readonly ILogger<CalculadoraController> _logger;
        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        [HttpGet("soma/{firstNumber}/{secondNumber}")]
        public IActionResult Soma(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);

                return Ok(sum.ToString());
            }

            return BadRequest("Dados inválidos");

        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;

            if (decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }

            return 0;
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);
            return isNumber;
        }



        [HttpGet("subtracao/{firstNumber}/{secondNumber}")]
        public IActionResult Subtracao(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);

                return Ok(sum.ToString());
            }

            return BadRequest("Dados inválidos");

        }

        [HttpGet("multiplicacao/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplicacao(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);

                return Ok(sum.ToString());
            }

            return BadRequest("Dados inválidos");

        }

        [HttpGet("divisao/{firstNumber}/{secondNumber}")]
        public IActionResult Divisao(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);

                return Ok(sum.ToString());
            }

            return BadRequest("Dados inválidos");

        }

        [HttpGet("media/{firstNumber}/{secondNumber}")]
        public IActionResult Media(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)/2;

                return Ok(sum.ToString());
            }

            return BadRequest("Dados inválidos");

        }

        [HttpGet("raizQuadrada/{firstNumber}")]
        public IActionResult RaizQuadrada(string firstNumber)
        {
            if (IsNumeric(firstNumber))
            {
                var sum = Math.Sqrt((double)ConvertToDecimal(firstNumber));

                return Ok(sum.ToString());
            }

            return BadRequest("Dados inválidos");

        }


    }
}
