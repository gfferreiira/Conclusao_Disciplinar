
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoInterDisciplinar.Data;
using ProjetoInterDisciplinar.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;


namespace ProjetoInterDisciplinar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        private readonly DataContext _context;  // context é usado para visualizar uma variável global

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

         [HttpDelete("{id}")] // Deletar Funcionário

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

       [HttpPost("{Cadastrar}")] // Cadastrar Funcionário

       public async Task<IActionResult> Add(Funcionario novoFuncionario)
       {
        try
        {
            Funcionario f = await _context.TB_FUNCIONARIOS
                .FirstOrDefaultAsync(f => f.Id == novoFuncionario.Id);

                await _context.TB_FUNCIONARIOS.AddAsync(novoFuncionario);
                await _context.SaveChangesAsync();
                return Ok(novoFuncionario.Nome);
                
        }
        catch (System.Exception ex) 
        {
                return BadRequest(ex.Message);
            }
       }

    }
}