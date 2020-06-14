using ShareLinkFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareLinkFinal.Data.DAL
{
    public class ApplicationUserDb
    {
        readonly ShareLinkDbContext ShareDbContext;
        public ApplicationUserDb(ShareLinkDbContext _ShareDbContext)
        {
            ShareDbContext = _ShareDbContext;
        }
        public IEnumerable<ApplicationUser> GetAll()
        {
            IEnumerable<ApplicationUser> applicationUsers = ShareDbContext.ApplicationUsers.ToList();
            return applicationUsers;
        }
        public ApplicationUser GetById(int Id)
        {
            ApplicationUser applicationUser = ShareDbContext.ApplicationUsers.Find(Id);
            return applicationUser;
        }
        public void Create(ApplicationUser applicationUser)
        {
            ShareDbContext.ApplicationUsers.Add(applicationUser);
        }
        public void Update(ApplicationUser applicationUser)
        {
            ShareDbContext.ApplicationUsers.Update(applicationUser);
        }
        public void Delete(ApplicationUser applicationUser)
        {

            ShareDbContext.ApplicationUsers.Remove(applicationUser);
        }
        public void Save()
        {
            ShareDbContext.SaveChanges();
        }
    }
}
