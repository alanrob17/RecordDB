// --------------------------------------------------------------------------------------------------------------------- 
// <copyright file="GetData.cs" company="Software Inc">
//   Alan Robson
// </copyright>
// <summary>
//   Defines the Get Data type.
// </summary>
// ---------------------------------------------------------------------------------------------------------------------
namespace RecordTest
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading.Tasks;
    using RecordDAL;
    using RecordDAL.Components;

    /// <summary>
    /// The get data class.
    /// </summary>
    public class GetData
    {
        public static void Main(string[] args)
        {
            ShowArtists();
            // GetArtistList();
            // Select();
            // GetSingleArtist(114);
            // GetArtistNames();
            // SelectArtistWithNoBio();
            // Insert();
            // Insert2();
            // UpdateArtist();
            // UpdateArtist2();
            // GetArtistId();
            // GetArtistId2();
            // Update();
            // Update2();
            // DeleteArtist();
            // ShowArtist();
            // GetBiography();
            
            // GetRecord();
            // InsertRecord();
            // InsertRecord2();
            // CountDiscs();
            // GetArtistRecordNumber();
            // UpdateRecord();  
            // UpdateRecord2();
            // GetFormattedRecord();
            // SelectRecords();
            // SelectRecordsShow();
            // SelectRecordsByArtistId();
            // SelectRecordReviews();
            // GetRecordedYearNumber();
            // NoRecordReviews();
            // ToShortDate();
            // DeleteRecord();  
        }

        /// <summary>
        /// Change a string into a short date.
        /// </summary>
        private static void ToShortDate()
        {
            var recordData = new RecordData();
            var myDate = RecordData.ToShortDate("28-12-2015");

            Console.WriteLine(myDate);
        }

        /// <summary>
        /// Get a list of records without reviews.
        /// </summary>
        private static void NoRecordReviews()
        {
            var recordData = new RecordData();

            var records = recordData.NoRecordReviews();

            foreach (var record in records)
            {
                Console.WriteLine("{0}: {1} - {2}\n", record.RecordId, record.ArtistName, record.Name);
            }             
        }

        /// <summary>
        /// Get the number of discs for a particular year.
        /// </summary>
        private static void GetRecordedYearNumber()
        {
            var recordData = new RecordData();
            var count = recordData.GetRecordedYearNumber(1974);

            Console.WriteLine("Count: {0}", count);            
        }

        private static void SelectRecordReviews()
        {
            var recordData = new RecordData();

            var records = recordData.SelectRecordReviews();

            foreach (var record in records)
            {
                Console.WriteLine("{0} -- {1}\n{2}\n", record.ArtistName, record.Name, record.Review);
            } 
        }

        /// <summary>
        /// Select a record list by artist id.
        /// </summary>
        private static void SelectRecordsByArtistId()
        {
            var artistId = 114;

            var recordData = new RecordData();

            var records = recordData.SelectArtistRecords(artistId);

            foreach (var record in records)
            {
                Console.WriteLine("{0} -- {1}", record.RecordId, record.Name);
            }
        }

        /// <summary>
        /// Select records based on show parameter.
        /// </summary>
        private static void SelectRecordsShow()
        {
            var show = "r1974";

            var recordData = new RecordData();

            var records = recordData.Select(show);

            foreach (var record in records)
            {
                Console.WriteLine("{0} -- {1} {2} - {3} : {4:d}\n", record.ArtistName, record.Name, record.Recorded, record.Media, record.Bought);
            }
        }

        /// <summary>
        /// Select all artist records.
        /// </summary>
        private static void SelectRecords()
        {
            var recordData = new RecordData();
            var records = recordData.Select();

            foreach (var record in records)
            {
                Console.WriteLine("{0} -- {1} {2} - {3}\n", record.ArtistName, record.Name, record.Recorded, record.Media);
            }
        }

        /// <summary>
        /// Get record details from ToString method.
        /// </summary>
        private static void GetFormattedRecord()
        {
            var recordData = new RecordData();
            var record = recordData.Select(212);
            var recordDetails = RecordData.ToString(record);

            Console.WriteLine(recordDetails);
        }

        /// <summary>
        /// Get number of records for an artist.
        /// </summary>
        private static void GetArtistRecordNumber()
        {
            var recordData = new RecordData();
            var count = recordData.GetArtistNumberOfRecords(114);

            Console.WriteLine("Count: {0}", count);
        }

        /// <summary>
        /// Count the number of discs.
        /// </summary>
        private static void CountDiscs()
        {
            var recordData = new RecordData();
            var count = recordData.CountDiscs("dvds");

            Console.WriteLine("Count: {0}", count);

            count = recordData.CountDiscs("cd");

            Console.WriteLine("Count: {0}", count);
        }

        /// <summary>
        /// Update a record using an object.
        /// </summary>
        private static void UpdateRecord2()
        {
            var date = "21-06-2015";

            IFormatProvider culture = System.Threading.Thread.CurrentThread.CurrentCulture;

            var record = new Record
                             {
                                 RecordId = 2187,
                                 ArtistId = 801,
                                 Name = "Laughing In Paradise",
                                 Recorded = 1991,
                                 Label = "Whoppo DoDah",
                                 Pressing = "Eng",
                                 Field = "Soundtrack",
                                 Rating = "****",
                                 Discs = 3,
                                 Media = "CD",
                                 Bought = DateTime.Parse(date, culture, System.Globalization.DateTimeStyles.AssumeLocal),
                                 Cost = 15.99m,
                                 CoverName = string.Empty,
                                 Review = "This is Alan's third album. His last before he turned to religion."
                             };

            var recordData = new RecordData();
            var recId = recordData.Update(record);

            Console.WriteLine(recId);
        }

        /// <summary>
        /// Update a record using variables.
        /// </summary>
        private static void UpdateRecord()
        {
            IFormatProvider culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            
            var recordId = 2187;
            var artistId = 801;
            var name = "Laughter In Paradise";
            var recorded = 1990;
            var label = "Whoppo";
            var pressing = "Eng";
            var field = "Jazz";
            var rating = "***";
            var discs = 2;
            var media = "CD";
            var date = "21-06-2015";
            var bought = DateTime.Parse(date, culture, System.Globalization.DateTimeStyles.AssumeLocal);
            var cost = 12.99m;
            var coverName = string.Empty;
            var review = "This is Alan's third album. His last before he went mad.";

            var recordData = new RecordData();
            var recId = recordData.Update(recordId, artistId, name, field, recorded, label, pressing, rating, discs, media, bought, cost, coverName, review);

            Console.WriteLine(recId);
        }

        /// <summary>
        /// Insert a new record.
        /// </summary>
        private static void InsertRecord2()
        {
            var artistId = 801;
            var name = "Laughs In Paradise";
            var recorded = 1989;
            var label = "Whoppo";
            var pressing = "Au";
            var field = "Rock";
            var rating = "****";
            var discs = 1;
            var media = "CD";
            var bought = new DateTime(2015, 06, 06);
            var cost = 13.99m;
            var coverName = string.Empty;
            var review = "This is Alan's third album.";

            var recordData = new RecordData();
            var recordId = recordData.Insert(artistId, name, field, recorded, label, pressing, rating, discs, media, bought, cost, coverName, review);

            Console.WriteLine(recordId);
        }

        /// <summary>
        /// Insert a new record.
        /// </summary>
        private static void InsertRecord()
        {
            var record = new Record
                             {
                                 ArtistId = 801,
                                 Name = "Fun In Paradise",
                                 Recorded = 1986,
                                 Label = "Whoppo",
                                 Pressing = "Au",
                                 Field = "Rock",
                                 Rating = "****",
                                 Discs = 1,
                                 Media = "CD",
                                 Bought = new DateTime(2015, 05, 06),
                                 Cost = 10.99m,
                                 CoverName = string.Empty,
                                 Review = "This is Alan's second album."
                             };

            var recordData = new RecordData();
            var recordId = recordData.Insert(record);

            Console.WriteLine(recordId);
        }

        /// <summary>
        /// Get record details including the artist biography.
        /// </summary>
        private static void GetRecord()
        {
            var recordId = 1135;

            var recordData = new RecordData();
            var record = recordData.Select(recordId);

            var artistData = new ArtistData();
            var artist = artistData.GetArtistByRecordId(recordId);
            var biography = artistData.GetBiography(recordId);

            Console.WriteLine("\nArtistId: {0} - Artist {1}:\n", record.ArtistId, artist.Name);
            
            Console.WriteLine("\nRecordId: {0}\nName: {1}\nField: {2}\nRecorded: {3}\nLabel: {4}\nPressing: {5}\nDiscs: {6}\nMedia: {7}\nBought: {8}\nCost: {9}\nReview:\n{10}\n\nBiography:\n{11}", record.RecordId, record.Name, record.Field, record.Recorded, record.Label, record.Pressing, record.Discs, record.Media, record.Bought.ToShortDateString(), record.Cost, record.Review, biography);
        }

        /// <summary>
        /// Delete record.
        /// </summary>
        private static void DeleteRecord()
        {
            var recordData = new RecordData();

            recordData.Delete(2185);
            
            Console.WriteLine("Record deleted");           
        }

        /// <summary>
        /// Get biography from the current record Id.
        /// </summary>
        private static void GetBiography()
        {
            var artistData = new ArtistData();
            var biography = artistData.GetBiography(283);

            Console.WriteLine(biography);
        }

        /// <summary>
        /// Show an artist as Html.
        /// </summary>
        private static void ShowArtist()
        {
            var artistData = new ArtistData();
            var artist = artistData.Select(114);
            var artistDetails = ArtistData.ToString(artist);

            Console.WriteLine(artistDetails);
        }

        /// <summary>
        /// Delete an artist.
        /// </summary>
        private static void DeleteArtist()
        {
            var artistData = new ArtistData();
            artistData.Delete(803);

            Console.WriteLine("Artist deleted");
        }

        /// <summary>
        /// Get artist id by firstName, lastName.
        /// </summary>
        private static void GetArtistId2()
        {
            var artistData = new ArtistData();
            var artistId = artistData.GetArtistId(289);

            Console.WriteLine(artistId);
        }

        /// <summary>
        /// Get artist id by firstName, lastName.
        /// </summary>
        private static void GetArtistId()
        {
            // first name, last name
            var artistData = new ArtistData();
            var artistId = artistData.GetArtistId("Bob", "Dylan");

            Console.WriteLine(artistId);
        }

        /// <summary>
        /// Update an artist.
        /// </summary>
        private static void UpdateArtist()
        {
            var artist = new Artist
            {
                ArtistId = 803,
                FirstName = "Alan",
                LastName = "Robsano",
                Name = "Alan Robsano",
                Biography = "Alan hates country and western. He hates both kinds of music."
            };

            var artistData = new ArtistData();
            var artistId = artistData.UpdateArtist(artist);

            Console.WriteLine(artistId);
        }

        /// <summary>
        /// Update an artist.
        /// </summary>
        public static void UpdateArtist2()
        {
            var artistId = 803;
            var firstName = "Alano";
            var lastName = "Robsono"; 
            var name = "Alan Robsono";
            var biography = "Alan loves country and western. He swings to both kinds of music.";
            
            var artistData = new ArtistData();
           
            artistId = artistData.Update(artistId, firstName, lastName, name, biography);

            Console.WriteLine(artistId);
        }

        /// <summary>
        /// Update an artist.
        /// </summary>
        private static void Update()
        {
            // int aid, string fName, string lName, string name, string biography
            var artist = new Artist
            {
                ArtistId = 803,
                FirstName = "Alan",
                LastName = "Robsano",
                Name = "Alan Robsano",
                Biography = "Alan hates country and western. He hates both kinds of music."
            };

            var artistData = new ArtistData();
            var artistId = artistData.UpdateArtist(artist);

            Console.WriteLine(artistId);
        }
        
        /// <summary>
        /// Update an artist.
        /// </summary>
        private static void Update2()
        {
            var artistId = 803;
            var firstName = "Alano";
            var lastName = "Robsono";
            var name = "Alano Robsono";
            var biography = "Alan loves country and western. He swings to both kinds of music.";

            var artistData = new ArtistData();

            artistId = artistData.Update(artistId, firstName, lastName, name, biography);

            Console.WriteLine(artistId);
        }

        /// <summary>
        /// Insert a new artist entity.
        /// </summary>
        public static void Insert()
        {
            var artist = new Artist
                             {
                                 FirstName = "Alan",
                                 LastName = "Robsono",
                                 Biography = "Alan is a country and western singer. He like both kinds of music."
                             };

            var artistData = new ArtistData();
            var artistId = artistData.Insert(artist);

            Console.WriteLine(artistId);
        }

        /// <summary>
        /// Insert a new artist entity.
        /// </summary>
        public static void Insert2()
        {
            var firstName = "James";
            var lastName = "Robson";
            var biography = "James likes Pocopunk.";

            var artistData = new ArtistData();
            var artistId = artistData.Insert(firstName, lastName, biography);

            Console.WriteLine(artistId);
        }

        /// <summary>
        /// Select all artists with no biography.
        /// </summary>
        public static void SelectArtistWithNoBio()
        {
            var artistData = new ArtistData();
            var artists = artistData.SelectArtistWithNoBio();

            foreach (var artist in artists)
            {
                Console.WriteLine("{0}: {1} -- {2}, {3}", artist.ArtistId, artist.Name, artist.LastName, artist.FirstName);    
            }       
        }

        /// <summary>
        /// Get an artists details.
        /// </summary>
        /// <param name="artistId">The artist Id.</param>
        public static void GetSingleArtist(int artistId)
        {
            var artistData = new ArtistData();
            var artist = artistData.Select(artistId);

            Console.WriteLine("{0}: {1} -- {2}, {3}\n{4}\n", artist.ArtistId, artist.Name, artist.LastName, artist.FirstName, artist.Biography);
        }

        /// <summary>
        /// Show a list of artist Names.
        /// </summary>
        private static void ShowArtists()
        {
            var artist = new ArtistData();
            var artists = artist.GetArtists();

            foreach (var record in artists)
            {
                Console.WriteLine(record.Name);
            }
        }

        /// <summary>
        /// Select all artist records.
        /// </summary>
        private static void Select()
        {
            var artist = new ArtistData();
            var artists = artist.GetArtists();

            foreach (var record in artists)
            {
                Console.WriteLine("{0} -- {1}\n{2}\n", record.ArtistId, record.Name, record.Biography);
            }
        }

        /// <summary>
        /// Select all artists name and Id.
        /// </summary>
        private static void GetArtistList()
        {
            var artist = new ArtistData();
            var artists = artist.GetArtistList();

            foreach (var record in artists)
            {
                Console.WriteLine("{0} -- {1}", record.ArtistId, record.Name);
            }
        }

        /// <summary>
        /// Show a list of artist Names.
        /// </summary>
        private static void GetArtistNames()
        {
            var artistData = new ArtistData();
            var artists = artistData.GetArtists();

            foreach (var artist in artists)
            {
                Console.WriteLine(artist.Name);
            }
        }

    }
}
