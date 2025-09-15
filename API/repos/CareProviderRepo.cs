using Backend_intro;

namespace API.repos;

public class CareProviderRepo
{
    private readonly List<CareProvider> _providers = new();
    
    public CareProvider GetProvider(int id)
    {
        return _providers.Find(c => c.Id == id);
    }
    
    public void PostProvider(CareProvider provider)
    {
        _providers.Add(provider);
    }
    
}