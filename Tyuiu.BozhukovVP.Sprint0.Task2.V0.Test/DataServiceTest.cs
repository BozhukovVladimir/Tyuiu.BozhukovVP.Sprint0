using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BozhukovVP.Sprint0.Task2.V0.Lib;
namespace Tyuiu.BozhukovVP.Sprint0.Task2.V0.Test
{
    
    public class DataServiceTest
    {
        
        public void CheckGetMessageValid()
        {
            var name = "Владимир";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Владимир", res);
        }
    }
}
