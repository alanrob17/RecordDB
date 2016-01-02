// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StatisticData.cs" company="Software Inc.">
//   A.Robson
// </copyright>
// <summary>
//   Defines the StatisticData type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RecordDAL
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using RecordDAL.Components;

    /// <summary>
    /// The statistic data.
    /// </summary>
    public class StatisticData
    {
        #region " Methods "

        /// <summary>
        /// Get statistics.
        /// </summary>
        /// <returns>
        /// The <see cref="Statistic"/>list of statistics for the record Db.
        /// </returns>
        public Statistic GetStatistics()
        {
            var statistics = new Statistic();            

            var numCds = 0;
            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for Total number of CD's               
                var getValue = new SqlCommand("select sum(discs) from record where media = 'CD'", cn);
                cn.Open();

                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    numCds = (int)getValue.ExecuteScalar();
                }

                cn.Close();
                statistics.TotalCDs = numCds;
            }

            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for number of Rock Records
                var rockDisks = 0;
                var getValue = new SqlCommand("select sum(discs) from record where field = 'Rock'", cn);
                cn.Open();

                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    rockDisks = int.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.RockDisks = rockDisks;
            }

            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for number of Folk Records
                var folkDisks = 0;
                var getValue = new SqlCommand("select sum(discs) from record where field = 'Folk'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    folkDisks = int.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.FolkDisks = folkDisks;                
            }

            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for number of Acoustic Records
                var acousticDisks = 0;
                var getValue = new SqlCommand("select sum(discs) from record where field = 'Acoustic'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    acousticDisks = int.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.AcousticDisks = acousticDisks;
            }

            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for number of Jazz and Fusion Records
                var jazzDisks = 0;
                var getValue = new SqlCommand("select sum(discs) from record where field = 'Jazz' or field = 'Fusion'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    jazzDisks = int.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.JazzDisks = jazzDisks;
            }

            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for number of Blues Records
                var bluesDisks = 0;
                var getValue = new SqlCommand("select sum(discs) from record where field = 'Blues'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    bluesDisks = int.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.BluesDisks = bluesDisks;
            }

            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for number of Country Records
                var countryDisks = 0;
                var getValue = new SqlCommand("select sum(discs) from record where field = 'Country'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    countryDisks = int.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.CountryDisks = countryDisks;
            }

            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for number of Classical Records
                var classicalDisks = 0;
                var getValue = new SqlCommand("select sum(discs) from record where field = 'Classical'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    classicalDisks = int.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.ClassicalDisks = classicalDisks;
            }

            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for number of Soundtrack Records
                var soundtrackDisks = 0;
                var getValue = new SqlCommand("select sum(discs) from record where field = 'Soundtrack'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    soundtrackDisks = int.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.SoundtrackDisks = soundtrackDisks; 
            }

            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for number of Four Star Records
                var fourStarDisks = 0;
                var getValue = new SqlCommand("select sum(discs) from record where Rating = '****'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    fourStarDisks = int.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.FourStarDisks = fourStarDisks;
            }

            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for number of Three Star Records
                var threeStarDisks = 0;
                var getValue = new SqlCommand("select sum(discs) from record where Rating = '***'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    threeStarDisks = int.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.ThreeStarDisks = threeStarDisks;
            }

            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for number of Two Star Records
                var twoStarDisks = 0;
                var getValue = new SqlCommand("select sum(discs) from record where Rating = '**'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    twoStarDisks = int.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.TwoStarDisks = twoStarDisks;
            }

            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for number of One Star Records
                var oneStarDisks = 0;
                var getValue = new SqlCommand("select sum(discs) from record where Rating = '*'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    oneStarDisks = int.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.OneStarDisks = oneStarDisks;
            }

            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for amount spent on records
                var recordCost = 0.0m;
                var getValue = new SqlCommand("select sum(cost) from record where media = 'R'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    recordCost = decimal.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.RecordCost = recordCost;               
            }

            var cdCost = 0.0m;
            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for amount spent on CD's               
                var getValue = new SqlCommand("select sum(cost) from record where media = 'CD'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    cdCost = decimal.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.CDCost = cdCost;
            }

            // calculate the average cost of all CDs
            decimal avCdCost = cdCost / numCds;
            statistics.AvCDCost = avCdCost;

            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for amount spent on records and CD's
                var totalCost = 0.0m;
                var getValue = new SqlCommand("select sum(cost) from record", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    totalCost = decimal.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.TotalCost = totalCost;
            }

            var disks2011 = 0;
            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for Number of CD's bought in 2011               
                var getValue = new SqlCommand("select sum(discs) from record where bought > '31-Dec-2010' and bought < '01-Jan-2012'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    disks2011 = int.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.Disks2011 = disks2011;
            }

            var cost2011 = 0.0m;
            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for amount spent on CD's in 2011               
                var getValue = new SqlCommand("select sum(cost) from record where bought > '31-Dec-2010' and bought < '01-Jan-2012'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    cost2011 = decimal.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();               
                statistics.Cost2011 = cost2011;
            }

            var av2011 = cost2011 / disks2011;
            statistics.Av2011 = av2011;

            var disks2012 = 0;
            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for Number of CD's bought in 2012              
                var getValue = new SqlCommand("select sum(discs) from record where bought > '31-Dec-2011' and bought < '01-Jan-2013'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    disks2012 = int.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.Disks2012 = disks2012;
            }

            var cost2012 = 0.0m;
            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for amount spent on CD's in 2012                
                var getValue = new SqlCommand("select sum(cost) from record where bought > '31-Dec-2011' and bought < '01-Jan-2013'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    cost2012 = decimal.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.Cost2012 = cost2012;
            }

            var av2012 = cost2012 / disks2012;
            statistics.Av2012 = av2012;

            var disks2013 = 0;
            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for Number of CD's bought in 2013              
                var getValue = new SqlCommand("select sum(discs) from record where bought > '31-Dec-2012' and bought < '01-Jan-2014'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    disks2013 = int.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close(); 
                statistics.Disks2013 = disks2013;
            }

            var cost2013 = 0.0m;
            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for amount spent on CD's in 2013              
                var getValue = new SqlCommand("select sum(cost) from record where bought > '31-Dec-2012' and bought < '01-Jan-2014'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    cost2013 = decimal.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.Cost2013 = cost2013;
            }

            var av2013 = cost2013 / disks2013;
            statistics.Av2013 = av2013;

            var disks2014 = 0;
            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for Number of CD's bought in 2014              
                var getValue = new SqlCommand("select sum(discs) from record where bought > '31-Dec-2013' and bought < '01-Jan-2015'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    disks2014 = int.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.Disks2014 = disks2014;
            }

            var cost2014 = 0.0m;
            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for amount spent on CD's in 2014               
                var getValue = new SqlCommand("select sum(cost) from record where bought > '31-Dec-2013' and bought < '01-Jan-2015'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    cost2014 = decimal.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.Cost2014 = cost2014;
            }

            var av2014 = cost2014 / disks2014;
            statistics.Av2014 = av2014;

            var disks2015 = 0;
            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for Number of CD's bought in 2015                
                var getValue = new SqlCommand("select sum(discs) from record where bought > '31-Dec-2014' and bought < '01-Jan-2016'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    disks2015 = int.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.Disks2015 = disks2015;
            }


            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for amount spent on CD's in 2015
                var cost2015 = 0.0m;
                var getValue = new SqlCommand("select sum(cost) from record where bought > '31-Dec-2014' and bought < '01-Jan-2016'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    cost2015 = decimal.Parse(getValue.ExecuteScalar().ToString());
                }

                // this is to stop a divide by zero error if nothing has been bought
                if (cost2015 > 1)
                {
                    statistics.Cost2015 = cost2015;
                    var av2015 = cost2015 / disks2015;
                    statistics.Av2015 = av2015;
                }
                else
                {
                    statistics.Cost2015 = 0.00m;
                    statistics.Av2015 = 0.00m;
                }

                cn.Close();
            }

            using (var cn = new SqlConnection(AppSettings.Instance.ConnectString))
            {
                // query for Number of records
                var totalRecords = 0;
                var getValue = new SqlCommand("select sum(discs) from record where media='R'", cn);

                cn.Open();
                if (getValue.ExecuteScalar() != DBNull.Value)
                {
                    totalRecords = int.Parse(getValue.ExecuteScalar().ToString());
                }

                cn.Close();
                statistics.TotalRecords = totalRecords;
            }
            
            return statistics;
        }
        
        #endregion    
    }
}
