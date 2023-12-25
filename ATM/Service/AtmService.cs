using ATM.Helper;

namespace ATM.Service;

public class AtmService
{
    private readonly AtmDbContext _db;

    public AtmService(AtmDbContext db)
    {
        _db = db;
    }
}