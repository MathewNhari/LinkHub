using ShareLinkFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareLinkFinal.Data.DAL
{
    public class CategoryDb
    {
        readonly ShareLinkDbContext ShareDbContext;
        public CategoryDb(ShareLinkDbContext _ShareDbContext)
        {
            ShareDbContext = _ShareDbContext;
        }

        public IEnumerable<Category> GetAll()
        {
            IEnumerable<Category> categories = ShareDbContext.Categories.ToList();
            return categories;
        }
        public Category GetById(int Id)
        {
            Category category = ShareDbContext.Categories.Find(Id);
            return category;
        }
        public void Create(Category category)
        {
            ShareDbContext.Categories.Add(category);
        }
        public void Update(Category category)
        {
            ShareDbContext.Categories.Update(category);
        }
        public void Delete(Category category)
        {

            ShareDbContext.Categories.Remove(category);
        }
        public void Save()
        {
            ShareDbContext.SaveChanges();
        }
    }
}

