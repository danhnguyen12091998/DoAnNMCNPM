﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVang.DAO
{
    public class AcountDAO
    {
        private static AcountDAO instance;

        public static AcountDAO Instance
        {
            get { if (instance == null) instance = new AcountDAO(); return instance; }
            private set { instance = value; }
        }
        private AcountDAO()
        {

        }
        public bool Login(string username, string password)
        {

            return false;
        }
    }

}
