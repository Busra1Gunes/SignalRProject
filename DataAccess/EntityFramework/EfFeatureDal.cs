using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repositories;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(SignalRContext context) : base(context)
        {
        }
    }
}
