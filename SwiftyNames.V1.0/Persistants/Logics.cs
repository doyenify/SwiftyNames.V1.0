﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SwiftyNames.V1._0.Persistants
{

    
    public class Logics:IRepository
    {
        SwiftyNamesEntities context = new SwiftyNamesEntities();

        public IList<NewsPapersPrice> GetNewsPaperTable()
        {
            return context.NewsPapersPrices.ToList();
        }

        public IList<Nationality> GetNational()
        {

            return context.Nationalities.Where(x=>x.Adjective!=null && x.Person!=null).ToList();
        }


       
    }
}