using mangas.Domain.Entities;

namespace mangas.Domain.Entities;

public class MangaService
{
    private readonly List <Manga> _mangas = new();
    public IEnumerable<Manga> GetALL()
    {
        return _mangas;
    }
    public Manga GetById(int id)
    {
        return _mangas.FirstOrDefault(manga => manga.Id == id);
    }
    public void Add(Manga manga)
    {
        _mangas.Add(manga);
    }
    public void Update(Manga mangaToUpdate)
    {
        var manga = GetById(mangaToUpdate.Id);
        if (manga !=null)
        {
            _mangas.Remove(manga);
            _mangas.Add(mangaToUpdate);
        }
    }
    public void Delete(int id)
    {
        var manga = GetById(id);
        if (manga != null)
            _mangas.Remove(manga);
    }
}