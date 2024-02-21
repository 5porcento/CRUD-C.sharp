﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController: ControllerBase
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult ObterDatahora()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongTimeString(),
                Hora = DateTime.Now.ToShortDateString(),
            };
            return Ok(obj);
        }
        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Ola {nome}, Seja Bem-Vindo(a)!";
            return Ok(new { mensagem });
        }
    }
}
