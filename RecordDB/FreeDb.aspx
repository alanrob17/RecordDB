<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FreeDb.aspx.cs" Inherits="RecordDB.FreeDb" MaintainScrollPositionOnPostback="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Update FreedDb Id</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="" />
    <meta name="author" content="" />

    <!-- Le styles -->
    <link href="assets/css/bootstrap.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        body {
          padding-top: 60px;
          padding-bottom: 40px;
        }
      .grid
        {
        margin:0px auto;
        border: navy;
        background-color:white;
          color: navy;
        }
        .grid td,.grid th {    
            padding-top: 2px;
            padding-bottom: 2px;
            padding-left: 5px;
            border-color: navy;
        }
      .header
        {
        text-align:left;
        color:white;
        background-color:blue;
        }
        .editRow
        {
            background-color:lightblue;
        }
    </style>
    <link href="assets/css/bootstrap-responsive.css" rel="stylesheet" />
    <link href="styles.css" rel="stylesheet" type="text/css" />

    <!-- Le HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
      <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->
    <script type="text/javascript">
        function ShowTime() {
            var dt = new Date();
            var hours = dt.getHours();
            var part = "am";
            if (hours > 12) {
                hours -= 12;
                part = "pm";
            }
            var newtime = +hours + ":" + dt.getMinutes() + part;
            if (dt.getMinutes() < 10) {
                newtime = newtime.replace(":", ":0");
            }
            document.getElementById('<%= textClock.ClientID %>').value = newtime;
            window.setTimeout("ShowTime()", 500);
        }
        function runCode() {
            window.setTimeout("ShowTime()", 1000);
        }

    </script>
    <!-- Le fav and touch icons -->
    <link rel="shortcut icon" href="assets/ico/favicon.ico" />
    <link rel="apple-touch-icon-precomposed" sizes="144x144" href="assets/ico/apple-touch-icon-144-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" sizes="114x114" href="assets/ico/apple-touch-icon-114-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" sizes="72x72" href="assets/ico/apple-touch-icon-72-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" href="assets/ico/apple-touch-icon-57-precomposed.png" />
</head>
<body onload="javascript:runCode();">
    <form id="frmNoRecordReviews" method="post" runat="server">
      <div class="navbar navbar-fixed-top">
      <div class="navbar-inner">
        <div class="container">
          <a class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse">
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
          </a>
          <a class="brand" href="/default">Record DB</a>
          <div class="nav-collapse">
            <ul class="nav">
              <li><a href="/default">Home</a></li>
              <li><a href="/search">Search</a></li>
              <li><a href="/statistics">Statistics</a></li>
            </ul>
          </div><!--/.nav-collapse -->
        </div>
      </div>
    </div>
        
    <div class="container">

      <!-- Main hero unit for a primary marketing message or call to action -->
      <div class="hero-unit">
        <h2>RecordDB Management System</h2>
        <h3><asp:label ID="dateLabel" runat="server"></asp:label></h3>
        <h3><asp:TextBox ID="textClock" Width="70px" ForeColor="#000099" Font="Bold" runat="server"></asp:TextBox></h3>
        <h3><asp:Label ID="lblPageHeader" runat="server"></asp:Label></h3>
      </div>
        
        <div class="span12">
            <br/>

        <asp:GridView
            ID="freeDbGridview"
            DataSourceID="freeDbDataSource"
            DataKeyNames="DiscId"
            runat="server" 
            CssClass="grid"
            CellPadding="2"
            HeaderStyle="white-space: nowrap;overflow: hidden;"
            HeaderStyle-CssClass="header"
            EditRowStyle-CssClass="editRow"
            AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField
                    DataField="RecordId"
                    ReadOnly="True"
                    Visible="False" />
                <asp:BoundField
                    DataField="DiscId"
                    ReadOnly="True"
                    Visible="False" />
                <asp:BoundField
                    DataField="ArtistName"
                    HeaderText="Artist"
                    HeaderStyle-HorizontalAlign="Left" 
                    ReadOnly="True" 
                    HeaderStyle-Width="250px"                     
                    ItemStyle-Width="250px" />
                <asp:BoundField
                    DataField="Name"
                    HeaderText="Title"
                    HeaderStyle-HorizontalAlign="Left"
                    ReadOnly="True" 
                    HeaderStyle-Width="350px"                     
                    ItemStyle-Width="350px" />
                <asp:BoundField
                    DataField="DiscNo"
                    HeaderText="Title"
                    ReadOnly="True" />
                <asp:BoundField
                    DataField="FreeDbId"
                    HeaderText="FreeDbId"
                    ReadOnly="True"
                    HeaderStyle-HorizontalAlign="Left"
                    HeaderStyle-Width="170px"                     
                    ItemStyle-Width="170px" />
               <asp:BoundField
                    DataField="FreeDbDiscId"
                    HeaderText="FreeDbDiscId"
                    HeaderStyle-HorizontalAlign="Left"
                    HeaderStyle-Width="170px"                     
                    ItemStyle-Width="170px" />
                <asp:CommandField ShowEditButton="True"  
                    HeaderStyle-Width="120px"
                    HeaderStyle-HorizontalAlign="Left"
                    HeaderText="&nbsp;&nbsp;&nbsp;&nbsp;Edit FreeDbId"/>
            </Columns> 
        </asp:GridView>

        <asp:ObjectDataSource
            ID="freeDbDataSource"
            TypeName="RecordDB.DAL.RecordDisc"
            SelectMethod="Select"
            UpdateMethod="Update"
            runat="server">
            <UpdateParameters>
                <asp:Parameter Name="DiscId"/>
                <asp:Parameter Name="FreeDbDiscId"/>
            </UpdateParameters>
            
        </asp:ObjectDataSource>
   </div>
            </div>
        <hr/>

      <footer>
        <div class="span2">&nbsp;</div>
        <div class="span11">
        <p>Return to the <a href="/default">Main Menu</a></p>
        </div>
      </footer>

	</form>

    <!-- Le javascript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="../assets/js/jquery.js" type="text/javascript"></script>
    <script src="../assets/js/bootstrap-transition.js" type="text/javascript"></script>
    <script src="../assets/js/bootstrap-alert.js" type="text/javascript"></script>
    <script src="../assets/js/bootstrap-modal.js" type="text/javascript"></script>
    <script src="../assets/js/bootstrap-dropdown.js" type="text/javascript"></script>
    <script src="../assets/js/bootstrap-scrollspy.js" type="text/javascript"></script>
    <script src="../assets/js/bootstrap-tab.js" type="text/javascript"></script>
    <script src="../assets/js/bootstrap-tooltip.js" type="text/javascript"></script>
    <script src="../assets/js/bootstrap-popover.js" type="text/javascript"></script>
    <script src="../assets/js/bootstrap-button.js" type="text/javascript"></script>
    <script src="../assets/js/bootstrap-collapse.js" type="text/javascript"></script>
    <script src="../assets/js/bootstrap-carousel.js" type="text/javascript"></script>
    <script src="../assets/js/bootstrap-typeahead.js" type="text/javascript"></script>
</body>
</html>
