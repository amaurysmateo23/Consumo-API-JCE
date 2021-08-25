using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Tarea5.Data;
public class ServicioSecretos
{
    
    private ApplicationDbContext _dbContext;
    

    public ServicioSecretos(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;  
    }
 
    public async Task<List<Secretos>> ObtenerSecretosAsync()=>    
         await _dbContext.secretos.ToListAsync();
    
    public async Task<Usuarios> ObtenerInfo(string BuscadorCed)=>await _dbContext.usuarios.FirstOrDefaultAsync(Usuario=>Usuario.Email == BuscadorCed);
    

    public async Task<Secretos> AgregarSecretoAsync(Secretos secreto)
    {
        try
        {
            _dbContext.secretos.Add(secreto);
            await _dbContext.SaveChangesAsync();
            
        }
        catch (Exception)
        {
            throw;
        }
        return secreto;
    }
}