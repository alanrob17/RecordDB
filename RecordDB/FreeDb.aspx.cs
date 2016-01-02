// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FreeDb.aspx.cs" company="Software Inc.">
//   Alan Robson.
// </copyright>
// <summary>
//   The free db data entry page.
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

    /// <summary>
    /// The free db.
    /// </summary>
    public partial class FreeDb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var dtnow = DateTime.Now;

            dateLabel.Text = dtnow.ToLongDateString();

            lblPageHeader.Text = "Update FreedDb Id";

        }
    }
}