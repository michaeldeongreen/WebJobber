using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebJobber.Domain;

namespace WebJobber.Services
{
    public class SomeJobService
    {
        public void Save(SomeJob job)
        {
            using (ISession session = NHibernateSession.OpenSession())
            {
                session.SaveOrUpdate(job);
            }
        }
    }
}
