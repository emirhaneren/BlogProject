﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//7. Step, Repos
namespace DataAccessLayer.EntityFramework
{
    public class EfAboutRepository: GenericRepository<About>, IAboutDal
    {
    }
}