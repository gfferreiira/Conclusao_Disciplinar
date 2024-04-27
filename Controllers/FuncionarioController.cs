using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using ProjetoInterDisciplinar.Data;
using ProjetoInterDisciplinar.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoInterDisciplinar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        private readonly DataContext _context;

        public FuncionarioController(DataContext context)
        {
            _context = context;
        }

       [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Funcionario> lista = await _context.TB_FUNCIONARIOS.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }

         [HttpGet("{id}")] //Buscar pelo ID
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {

                Funcionario fn = await _context.TB_FUNCIONARIOS
                        .FirstOrDefaultAsync(fnBusca => fnBusca.Id == id);

                return Ok(fn);

            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }

        [HttpPut] // Atualizar Funcionário
        public async Task<IActionResult> Update(Funcionario novoFuncionario)
        {
            try
            {

                _context.TB_FUNCIONARIOS.Update(novoFuncionario);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

         [HttpDelete("{id}")]

       public async Task<IActionResult> Delete(int id)
       {
        try
        {
            Funcionario fRemover = await _context.TB_FUNCIONARIOS.FirstOrDefaultAsync(f => f.Id == id);

            _context.TB_FUNCIONARIOS.Remove(fRemover);
            int linhasAfetadas = await _context.SaveChangesAsync();
            return Ok(linhasAfetadas);

        }

        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
       }

    }
}