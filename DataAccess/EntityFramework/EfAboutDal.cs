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
    public class EfAboutDal:GenericRepository<About>,IAboutDal 
        //IAboutDal ekleme sebebimiz eğer IAboutDal içine imza eklenirse metot EfAboutDal içinde doldurulur
    {
        public EfAboutDal(SignalRContext context):base(context)
        {

        }

    }
}
