using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using FeatureLayer;

namespace BusinessLayer
{
    public class CN_Users
    {
        private CD_Users objDataLayer = new CD_Users();

        public List<User> ToList() 
        { 
            return objDataLayer.ToList();   
        }
    }
}
