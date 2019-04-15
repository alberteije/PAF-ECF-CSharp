﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using PafEcf.Util;

namespace PafEcf.NHibernate
{
    public class NHibernateHelper
    {
        private static ISessionFactory SessionFactory;

        public static ISessionFactory GetSessionFactory()
        {
            try
            {
                if (SessionFactory == null)
                {
                    lock (typeof(NHibernateHelper))
                    {
                        Configuration Config = new Configuration();
                        Config.Configure();
                        Config.AddAssembly("PafEcf");
                        SessionFactory = Config.BuildSessionFactory();
                    }
                }
                return SessionFactory;
            }
            catch (Exception ex)
            {
                Log.write(ex.ToString());
                throw ex;
            }
        }
    }
}
