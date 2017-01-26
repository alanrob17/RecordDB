﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Browse.aspx.cs" company="Software Inc.">
//   The Browse Class
// </copyright>
// <summary>
//   Defines the Browse type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RecordDB
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class Browse : System.Web.UI.Page
    {
        /// <summary>
        /// The page load.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The event arguments.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            var aid = 0;           
            recordGridView.HeaderRow.TableSection = TableRowSection.TableHeader;

            if (!Page.IsPostBack)
            {
                var show = string.Empty;

                // Check for a specific artist id to display
                if (Page.RouteData.Values["show"] != null)
                {
                    show = Page.RouteData.Values["show"].ToString();
                }

                this.GetCount(show);
            }
        }

        /// <summary>
        /// Get the number of discs for the current query.
        /// </summary>
        /// <param name="show">The query string value.</param>
        private void GetCount(string show)
        {
            if (show.Contains("aid"))
            {
                var artistId = 0;
                show = show.Replace("aid", string.Empty);
                int.TryParse(show, out artistId);
                // discsLabel.Text = RecordData.GetArtistNumberOfRecords(artistId) + " discs";
                pageHeaderLabel.Text = "Artist List";
            }
            else if (show != "records" && show.Substring(0, 1) == "r")
            {
                var year = 0;
                show = show.Replace("r", string.Empty);
                int.TryParse(show, out year);
                // discsLabel.Text = RecordData.GetRecordedYearNumber(year) + " discs";
                pageHeaderLabel.Text = "Recorded List " + show;
            }
            else
            {
                // discsLabel.Text = RecordData.CountDiscs(show) + " discs";

                switch (show)
                {
                    case "all":
                        pageHeaderLabel.Text = "All Records and CD's";
                        break;
                    case "cd":
                        pageHeaderLabel.Text = "All CD's";
                        break;
                    case "records":
                        pageHeaderLabel.Text = "All Records";
                        break;
                    case "dvds":
                        pageHeaderLabel.Text = "All DVD's";
                        break;
                    case "blurays":
                        pageHeaderLabel.Text = "All Blu-rays";
                        break;
                    case "2017":
                        pageHeaderLabel.Text = "All Records bought in 2017";
                        break;
                    case "2016":
                        pageHeaderLabel.Text = "All Records bought in 2016";
                        break;
                    case "2015":
                        pageHeaderLabel.Text = "All Records bought in 2015";
                        break;
                    case "2014":
                        pageHeaderLabel.Text = "All Records bought in 2014";
                        break;
                    case "2013":
                        pageHeaderLabel.Text = "All Records bought in 2013";
                        break;
                    case "2012":
                        pageHeaderLabel.Text = "All Records bought in 2012";
                        break;
                    case "1111":
                        pageHeaderLabel.Text = "Indispensible records";
                        break;
                    case "Rock":
                        pageHeaderLabel.Text = "Rock albums";
                        break;
                    case "Blues":
                        pageHeaderLabel.Text = "Blues albums";
                        break;
                    case "Jazz":
                        pageHeaderLabel.Text = "Jazz albums";
                        break;
                    case "Classical":
                        pageHeaderLabel.Text = "Classical albums";
                        break;
                    case "Soundtrack":
                        pageHeaderLabel.Text = "Soundtrack albums";
                        break;
                    case "Country":
                        pageHeaderLabel.Text = "Country albums";
                        break;
                    case "Rockdesc":
                        pageHeaderLabel.Text = "Rock albums by date";
                        break;
                    case "Bluesdesc":
                        pageHeaderLabel.Text = "Blues albums by date";
                        break;
                    case "Jazzdesc":
                        pageHeaderLabel.Text = "Jazz albums by date";
                        break;
                    case "Classicaldesc":
                        pageHeaderLabel.Text = "Classical albums by date";
                        break;
                    case "Soundtrackdesc":
                        pageHeaderLabel.Text = "Soundtrack albums by date";
                        break;
                    case "Countrydesc":
                        pageHeaderLabel.Text = "Country albums by date";
                        break;
                    default:
                        break;
                }
            }
        }
    }
}