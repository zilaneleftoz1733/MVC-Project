using DataAccseesLayer.Abstract;
using DataAccseesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccseesLayer.EntityFramework
{
    public class EfCategoryDal:GenericRepository<Category>,ICategoryDal
    {   
    }
}
