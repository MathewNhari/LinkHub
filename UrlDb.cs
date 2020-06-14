using ShareLinkFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareLinkFinal.Data.DAL
{
    public class UrlDb
    {
        readonly ShareLinkDbContext ShareDbContext;
        public UrlDb(ShareLinkDbContext _ShareDbContext)
        {
            ShareDbContext = _ShareDbContext;
        }
        public IEnumerable<Url> GetAll()
        {
            IEnumerable<Url> urls = ShareDbContext.Urls.ToList();
            return urls;
        }
        public Url GetById(int Id)
        {
            Url url = ShareDbContext.Urls.Find(Id);
            return url;
        }
        public void Create(Url url)
        {
            ShareDbContext.Urls.Add(url);
        }
        public void Update(Url url)
        {
            ShareDbContext.Urls.Update(url);
        }
        public void Delete(Url url)
        {

            ShareDbContext.Urls.Remove(url);
        }
        public void Save()
        {
            ShareDbContext.SaveChanges();
        }

    }
}
