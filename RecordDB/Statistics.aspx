<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Statistics.aspx.cs" Inherits="RecordDB.Statistics" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
    <div class="col-xs-12 col-md-6 center-block">
        <h2 class="headerLabel">RecordDB Management System</h2>
          <h3 class="dateLabel"><asp:label ID="dateLabel" runat="server"></asp:label></h3>
          <h4 class="clockFace"><asp:TextBox ID="textClock" Width="120px" BorderStyle="None" ForeColor="#000099" Font="Bold" runat="server"></asp:TextBox></h4>
      
      <p> <span id="date"></span></p> 
        </div>
        </div>
    <div class="row">
    <div class="col-xs-12 col-md-4 center-block">

<div class="table-responsive">
<table class="table table-hover table-bordered">
<thead>        
<tr>
<th>Statistics</th>
<th>Total</th>
</tr>
<tr>
<th>&nbsp;</th>
<th>&nbsp;</th>
</tr>
</thead>
<tr>
<td><strong>Number of Discs bought in 2015</strong></td>
<td><asp:Label runat="server" ID="disks2015Label"></asp:Label></td>
</tr>
<tr>
<td><strong>Total Amount spent on Discs in 2015</strong></td>
<td><asp:Label runat="server" ID="cost2015Label"></asp:Label></td>
</tr>
<tr>
<td><strong>Average cost of a Disc in 2015</strong></td>
<td><asp:Label runat="server" ID="av2015Label"></asp:Label></td>
</tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td><strong>Number of Discs bought in 2014</strong></td>
<td><asp:Label runat="server" ID="disks2014Label"></asp:Label></td>
</tr>
<tr>
<td><strong>Total Amount spent on Discs in 2014</strong></td>
<td><asp:Label runat="server" ID="cost2014Label"></asp:Label></td>
</tr>
<tr>
<td><strong>Average cost of a Disc in 2014</strong></td>
<td><asp:Label runat="server" ID="av2014Label"></asp:Label></td>
</tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td><strong>Number of Discs bought in 2013</strong></td>
<td><asp:Label runat="server" ID="disks2013Label"></asp:Label></td>
</tr>
<tr>
<td><strong>Total Amount spent on Discs in 2013</strong></td>
<td><asp:Label runat="server" ID="cost2013Label"></asp:Label></td>
</tr>
<tr>
<td><strong>Average cost of a Disc in 2013</strong></td>
<td><asp:Label runat="server" ID="av2013Label"></asp:Label></td>
</tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td><strong>Number of Discs bought in 2012</strong></td>
<td><asp:Label runat="server" ID="disks2012Label"></asp:Label></td>
</tr>
<tr>
<td><strong>Total Amount spent on Discs in 2012</strong></td>
<td><asp:Label runat="server" ID="cost2012Label"></asp:Label></td>
</tr>
<tr>
<td><strong>Average cost of a Disc in 2012</strong></td>
<td><asp:Label runat="server" ID="av2012Label"></asp:Label></td>
</tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>                      
<tr>
<td><strong>Number of Discs bought in 2011</strong></td>
<td><asp:Label runat="server" ID="disks2011Label"></asp:Label></td>
</tr>
<tr>
<td><strong>Total Amount spent on Discs in 2011</strong></td>
<td><asp:Label runat="server" ID="cost2011Label"></asp:Label></td>
</tr>
<tr>
<td><strong>Average cost of a Disc in 2011</strong></td>
<td><asp:Label runat="server" ID="av2011Label"></asp:Label></td>
</tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>                      
<tr>
<td><strong>Total Number of CD's</strong></td>
<td><asp:Label runat="server" ID="totalCDsLabel"></asp:Label></td>
</tr>
<tr>
<td><strong>Total Amount spent on CD's</strong></td>
<td><asp:Label runat="server" ID="cDCostLabel"></asp:Label></td>
</tr>
<tr>
<td><strong>Average spent on a CD</strong></td>
<td><asp:Label runat="server" ID="avCDCostLabel"></asp:Label></td>
</tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td><strong>Total Number of Records</strong></td>
<td><asp:Label runat="server" ID="totalRecordsLabel"></asp:Label></td>
</tr>
<tr>
<td><strong>Amount spent on Records</strong></td>
<td><asp:Label runat="server" ID="recordCostLabel"></asp:Label></td>
</tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td><strong>Total amount spent</strong></td>
<td><asp:Label runat="server" ID="totalCostLabel"></asp:Label></td>
</tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td><strong>Number of Rock albums</strong></td>
<td><asp:Label runat="server" ID="rockDisksLabel"></asp:Label></td>
</tr>
<tr>
<td><strong>Number of Folk albums</strong></td>
<td><asp:Label runat="server" ID="folkDisksLabel"></asp:Label></td>
</tr>
<tr>
<td><strong>Number of Acoustic albums</strong></td>
<td><asp:Label runat="server" ID="acousticDisksLabel"></asp:Label></td>
</tr>
<tr>
<td><strong>Number of Jazz/Fusion albums</strong></td>
<td><asp:Label runat="server" ID="jazzDisksLabel"></asp:Label></td>
</tr>
<tr>
<td><strong>Number of Blues albums</strong></td>
<td><asp:Label runat="server" ID="bluesDisksLabel"></asp:Label></td>
</tr>
<tr>
<td><strong>Number of Country albums</strong></td>
<td><asp:Label runat="server" ID="countryDisksLabel"></asp:Label></td>
</tr>
<tr>
<td><strong>Number of Classical albums</strong></td>
<td><asp:Label runat="server" ID="classicalDisksLabel"></asp:Label></td>
</tr>
<tr>
<td><strong>Number of Soundtrack albums</strong></td>
<td><asp:Label runat="server" ID="soundtrackDisksLabel"></asp:Label></td>
</tr>
<tr>
<td>&nbsp;</td>
<td>&nbsp;</td>
</tr>
<tr>
<td><strong>Number of Indispensable albums</strong></td>
<td><asp:Label runat="server" ID="fourStarDisksLabel"></asp:Label></td>
</tr>
<tr>
<td><strong>Number of Slightly flawed albums</strong></td>
<td><asp:Label runat="server" ID="threeStarDisksLabel"></asp:Label></td>
</tr>
<tr>
<td><strong>Number of Average albums</strong></td>
<td><asp:Label runat="server" ID="twoStarDisksLabel"></asp:Label></td>
</tr>
<tr>
<td><strong>Number of Mediocre albums</strong></td>
<td><asp:Label runat="server" ID="oneStarDisksLabel"></asp:Label></td>
</tr>
</table>
    <asp:Label ID="yearLabel" runat="server"></asp:Label><br/><br/>
</div>
</div>
</div> 
  <div class="row">
      <footer>
          <hr />
        <p>Return to the <a href="/default">Main Menu</a></p>
      </footer>
  </div>                
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="EndOfPageContent" runat="server">
      <script type="text/javascript">

          var yr = new Date();
          var year = yr.getFullYear();

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

          $('div.row').hide().fadeIn(1000);
          $('#<%=yearLabel.ClientID %>').html('&copy; Alan Robson ' + year);
          $('h2.headerLabel').css('text-align', 'center');
          $('h3.dateLabel').css('text-align', 'center');
          $('h4.clockFace').css('text-align', 'center');
          $('#<%=textClock.ClientID %>').css('text-align', 'center');

          runCode();
        </script>    
</asp:Content>
