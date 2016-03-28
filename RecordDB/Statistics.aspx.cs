// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Statistics.aspx.cs" company="Software Inc.">
//   A.Robson
// </copyright>
// <summary>
// Display the website statistics.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RecordDB
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    using RecordDAL;

    /// <summary>
    /// The statistics.
    /// </summary>
    public partial class Statistics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var dtnow = DateTime.Now;
            dateLabel.Text = dtnow.ToLongDateString();

            var statisticData = new StatisticData();
            var statistics = statisticData.GetStatistics();

                disks2016Label.Text = statistics.Disks2016.ToString(CultureInfo.InvariantCulture);
            cost2016Label.Text = statistics.Cost2016.ToString("C");
            av2016Label.Text = statistics.Av2016.ToString("C");
            disks2015Label.Text = statistics.Disks2015.ToString(CultureInfo.InvariantCulture);
            cost2015Label.Text = statistics.Cost2015.ToString("C");
            av2015Label.Text = statistics.Av2015.ToString("C");
            disks2014Label.Text = statistics.Disks2014.ToString(CultureInfo.InvariantCulture);
            cost2014Label.Text = statistics.Cost2014.ToString("C");
            av2014Label.Text = statistics.Av2014.ToString("C");
            disks2013Label.Text = statistics.Disks2013.ToString(CultureInfo.InvariantCulture);
            cost2013Label.Text = statistics.Cost2013.ToString("C");
            av2013Label.Text = statistics.Av2013.ToString("C");
            disks2012Label.Text = statistics.Disks2012.ToString(CultureInfo.InvariantCulture);
            cost2012Label.Text = statistics.Cost2012.ToString("C");
            av2012Label.Text = statistics.Av2012.ToString("C");
            disks2011Label.Text = statistics.Disks2011.ToString(CultureInfo.InvariantCulture);
            cost2011Label.Text = statistics.Cost2011.ToString("C");
            av2011Label.Text = statistics.Av2011.ToString("C");
            totalCDsLabel.Text = statistics.TotalCDs.ToString(CultureInfo.InvariantCulture);
            cDCostLabel.Text = statistics.CDCost.ToString("C");
            avCDCostLabel.Text = statistics.AvCDCost.ToString("C");
            totalRecordsLabel.Text = statistics.TotalRecords.ToString(CultureInfo.InvariantCulture);
            recordCostLabel.Text = statistics.RecordCost.ToString("C");
            totalCostLabel.Text = statistics.TotalCost.ToString("C");
            rockDisksLabel.Text = statistics.RockDisks.ToString(CultureInfo.InvariantCulture);
            folkDisksLabel.Text = statistics.FolkDisks.ToString(CultureInfo.InvariantCulture);
            acousticDisksLabel.Text = statistics.AcousticDisks.ToString(CultureInfo.InvariantCulture);
            jazzDisksLabel.Text = statistics.JazzDisks.ToString(CultureInfo.InvariantCulture);
            bluesDisksLabel.Text = statistics.BluesDisks.ToString(CultureInfo.InvariantCulture);
            countryDisksLabel.Text = statistics.CountryDisks.ToString(CultureInfo.InvariantCulture);
            classicalDisksLabel.Text = statistics.ClassicalDisks.ToString(CultureInfo.InvariantCulture);
            soundtrackDisksLabel.Text = statistics.SoundtrackDisks.ToString(CultureInfo.InvariantCulture);
            fourStarDisksLabel.Text = statistics.FourStarDisks.ToString(CultureInfo.InvariantCulture);
            threeStarDisksLabel.Text = statistics.ThreeStarDisks.ToString(CultureInfo.InvariantCulture);
            twoStarDisksLabel.Text = statistics.TwoStarDisks.ToString(CultureInfo.InvariantCulture);
            oneStarDisksLabel.Text = statistics.OneStarDisks.ToString(CultureInfo.InvariantCulture);
        }
    }
}