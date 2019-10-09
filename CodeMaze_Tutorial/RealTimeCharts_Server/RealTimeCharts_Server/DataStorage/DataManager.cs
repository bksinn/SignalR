using RealTimeCharts_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealTimeCharts_Server.DataStorage
{
    public class DataManager
    {
        public static List<DataModel> GetData()
        {
            var r = new Random();
            return new List<DataModel>()
            {
                new DataModel { Frequency = r.Next(1, 40), Letter = "A"},
                new DataModel { Frequency = r.Next(1, 40), Letter = "B"},
                new DataModel { Frequency = r.Next(1, 40), Letter = "C"},
                new DataModel { Frequency = r.Next(1, 40), Letter = "D"},
                new DataModel { Frequency = r.Next(1, 40), Letter = "E"},
                new DataModel { Frequency = r.Next(1, 40), Letter = "F"},
                new DataModel { Frequency = r.Next(1, 40), Letter = "G"},
                new DataModel { Frequency = r.Next(1, 40), Letter = "H"},
                new DataModel { Frequency = r.Next(1, 40), Letter = "I"},
                new DataModel { Frequency = r.Next(1, 40), Letter = "J"},
                new DataModel { Frequency = r.Next(1, 40), Letter = "K"}
            };
        }
    }
}
