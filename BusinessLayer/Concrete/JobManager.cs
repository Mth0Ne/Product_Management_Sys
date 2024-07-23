using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class JobManager : IJobService
    {
        IJobDal _jobdal;

        public JobManager(IJobDal jobdal)
        {
            _jobdal = jobdal;
        }

        public void TDelete(Job t)
        {
            _jobdal.Delete(t);
        }

        public Job TGetById(int id)
        {
            return _jobdal.GetById(id);
        }

        public List<Job> TGetList()
        {
            return _jobdal.GetList();
        }

        public void TInsert(Job t)
        {
            _jobdal.Insert(t);
        }

        public void TUpdate(Job t)
        {
            _jobdal.Update(t);
        }
    }
}
