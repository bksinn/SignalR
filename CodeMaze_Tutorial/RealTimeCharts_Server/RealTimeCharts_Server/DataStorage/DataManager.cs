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

        public static List<AffiliateSubmissionsModel> GetAffiliateSales()
        {
            var submittedSeries = new List<SeriesModel>();
            var declinedSeries = new List<SeriesModel>();
            var filteredSeries = new List<SeriesModel>();
            var throttledSeries = new List<SeriesModel>();

            // Generate random values
            var r = new Random();
            for (int i = 0; i < 25; i++)
            {
                submittedSeries.Add(new SeriesModel { Name = i + " Hours", Value = r.Next(3, 6) });
            }

            for (int i = 0; i < 25; i++)
            {
                declinedSeries.Add(new SeriesModel { Name = i + " Hours", Value = r.Next(1, 4) });
            }

            for (int i = 0; i < 25; i++)
            {
                filteredSeries.Add(new SeriesModel { Name = i + " Hours", Value = r.Next(1, 4) });
            }

            for (int i = 0; i < 25; i++)
            {
                throttledSeries.Add(new SeriesModel { Name = i + " Hours", Value = r.Next(1, 3) });
            }

            return new List<AffiliateSubmissionsModel>()
            {
                new AffiliateSubmissionsModel
                {
                    Name = "Throttled",
                    Series = throttledSeries
                },
                new AffiliateSubmissionsModel
                {
                    Name = "Filtered",
                    Series = filteredSeries
                },
                new AffiliateSubmissionsModel
                {
                    Name = "Declined",
                    Series = declinedSeries
                },
                new AffiliateSubmissionsModel
                {
                    Name = "Submitted",
                    Series = submittedSeries
                }
            };
        }
    }
}
