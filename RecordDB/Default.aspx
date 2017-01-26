<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" MasterPageFile="~/Site.Master" Inherits="RecordDB.Default" ValidateRequest="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
    <div class="col-xs-10 col-md-5 center-block">
        <h2 class="headerLabel">RecordDB Management System</h2>
          <h3 class="dateLabel"><asp:label ID="dateLabel" runat="server"></asp:label></h3>
          <h4 class="clockFace"><asp:TextBox ID="textClock" Width="120px" BorderStyle="None" ForeColor="#000099" Font="Bold" runat="server"></asp:TextBox></h4>    
      <p> <span id="date"></span></p> 
        </div>
        </div>
    <div class="row">
    <div class="col-xs-10 col-md-5 center-block">
          <div class="table-responsive">
            <table class="table table-hover table-bordered">
              <thead>
                <tr>
				<th>Options</th>
				<th>Description</th>
                </tr>
              </thead>
              <tbody>
			  <tr>
			    <td><a href="GetArtist/cd">View All CD Titles</a></td>
				<td>View a list of all CD Titles only. Organised by artist name and date recorded.</td>	
			    </tr>
				<tr>
				<td><a href="GetArtist/all">View All Titles</a></td>
				<td>View a list of all Titles (Record and CD). Organised by artist name and date recorded.</td>
				</tr>
				<tr>
				<td><a href="GetArtist/records">View All Records</a></td>
				<td>View a list of all Record Titles. Organised by artist name and date recorded.</td>
				</tr>
				<tr>
				<td><a href="GetArtist/dvds">View All DVD's</a></td>
				<td>View a list of all DVD Titles. Organised by date bought.</td>
                </tr>
				<tr>
				<td><a href="GetArtist/blurays">View All Blurays</a></td>
				<td>View a list of all Bluray Titles. Organised by date bought.</td>
				</tr>
				<tr>
				<td>&nbsp;</td>
				<td>&nbsp;</td>
				</tr>
				<tr>
				<td><a href="RecordList">Record List</a></td>
				<td>View a list of all Artists and Records.</td>
				</tr>
				<tr>
				<td><a href="RecordReviews">Record Reviews</a></td>
				<td>View a list of all record reviews.</td>
				</tr>
				<tr>
				<td><a href="ArtistList">List All Artists</a></td>
				<td>View a list of all Artists.</td>
				</tr>
				<tr>
				<td><a href="Search">Search for an Artist</a></td>
				<td>View a list of all of an Artists record titles.</td>
				</tr>
				<tr>
				<td>&nbsp;</td>
				<td>&nbsp;</td>
				</tr>
				<tr>
				<td><a href='GetArtist/2017'>View 2017 Titles</a></td>
				<td>View all albums bought in 2017.</td>
				</tr>
				<tr>
				<td><a href='GetArtist/2016'>View 2016 Titles</a></td>
				<td>View all albums bought in 2016.</td>
				</tr>
				<tr>
				<td><a href='GetArtist/2015'>View 2015 Titles</a></td>
				<td>View all albums bought in 2015.</td>
				</tr>
				<tr>
				<td><a href='GetArtist/2014'>View 2014 Titles</a></td>
				<td>View all albums bought in 2014.</td>
				</tr>
				<tr>
				<td><a href='GetArtist/2013'>View 2013 Titles</a></td>
				<td>View all albums bought in 2013.</td>
				</tr>
				<tr>
				<td><a href='GetArtist/2012'>View 2012 Titles</a> 
				</td>
				<td>View all albums bought in 2012.</td>
				</tr>
				<tr>
				<td>&nbsp;</td>
				<td>&nbsp;</td>
				</tr>
				<tr>
				<td><a href="Recorded">Year Recorded</a></td>
                <td>View all albums recorded in a particular Year.</td>
				</tr>
				<tr>
				<td><a href="GetArtist/1111">View Four Star</a></td>
				<td>View all Albums with a four star rating.
				</td>
				</tr>
				<tr>
				<td>&nbsp;</td>
				<td>&nbsp;</td>
				</tr>
				<tr>
				<td><a href="GetArtist/Rock">Rock</a></td>
				<td>View all Rock albums.</td>
				</tr>
				<tr>
				<td><a href="GetArtist/Blues">Blues</a></td>
				<td>View all Blues albums.</td>
				</tr>
				<tr>
				<td><a href="GetArtist/Jazz">Jazz</a></td>
				<td>View all Jazz albums.</td>
				</tr>
				<tr>
				<td><a href="GetArtist/Classical">Classical</a></td>
				<td>View all Classical albums.</td>
				</tr>
				<tr>
				<td><a href="GetArtist/Soundtrack">Soundtrack</a></td>
				<td>View all Soundtrack albums.</td>
				</tr>
				<tr>
				<td><a href="GetArtist/Country">Country</a></td>
				<td>View all Country albums.</td>
				</tr>
				<tr>
				<td>&nbsp;</td>
				<td>&nbsp;</td>
				</tr>
				<tr>
				<td><a href="GetArtist/Rockdesc">Rock by Date</a></td>
				<td>View all Rock albums by date.</td>
				</tr>
				<tr>
				<td><a href="GetArtist/Bluesdesc">Blues by Date</a></td>
				<td>View all Blues albums by date.</td>
				</tr>
				<tr>
				<td><a href="GetArtist/Jazzdesc">Jazz by Date</a>
				</td>
				<td>View all Jazz albums by date.</td>
				</tr>
				<tr>
				<td><a href="GetArtist/Classicaldesc">Classical by Date</a></td>
				<td>View all Classical albums by date.</td>
				</tr>
				<tr>
				<td><a href="GetArtist/Soundtrackdesc">Soundtrack by Date</a></td>
				<td>View all Soundtrack albums by date.</td>
				</tr>
				<tr>
				<td><a href="GetArtist/Countrydesc">Country by Date</a></td>
				<td>View all Country albums by date.</td>
				</tr>
				<tr>
				<td>&nbsp;</td>
				<td>&nbsp;</td>
				</tr>
				<tr>
				<td><a href="AddArtist">Add New Artist</a></td>
				<td>Add a new artist to the RecordDB.</td>
				</tr>
				<tr>
				<td><a href="EditArtist">Edit Artist</a></td>
				<td>Edit an artist in the RecordDB.</td>
			    </tr>
				<tr>
				<td><a href="DeleteArtist">Delete Artist</a></td>
				<td>Delete an artist in the RecordDB.</td>
				</tr>
				<tr>
				<td>&nbsp;</td>
				<td>&nbsp;</td>
				</tr>
				<tr>
				<td><a href="AddRecord">Add New Record</a></td>
				<td>Add a new Record to the RecordDB.</td>
				</tr>
				<tr>
				<td><a href="EditRecord">Edit Record</a></td>
				<td>Edit a Record in the RecordDB.</td>
				</tr>
				<tr>
				<td><a href="DeleteRecord">Delete Record</a></td>
				<td>Delete an artist's Record.</td>
				</tr>
				<tr>
				<td>&nbsp;</td>
				<td>&nbsp;</td>
				</tr>
				<tr>
				<td><a href="Statistics">Statistics</a></td>
				<td>Calculate statistics for the RecordDB.</td>
				</tr>
              </tbody>
            </table>
              <asp:Label ID="yearLabel" runat="server"></asp:Label><br/><br/>
          </div>
        </div>
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
