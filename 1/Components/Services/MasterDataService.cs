using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class MasterDataService
{
    private readonly MasterDbContext _context;

    public MasterDataService(MasterDbContext context)
    {
        _context = context;
    }

    public async Task<List<MasterData>> GetAllMasterDataAsync()
    {
        return await _context.MasterData.ToListAsync();
    }
}