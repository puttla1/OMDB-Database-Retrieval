
namespace Sample2
{
	using System;
	using System.Web;
	using System.Web.UI;
	using System.Net;
	using System.IO;
	using Newtonsoft.Json.Linq;
	using Newtonsoft.Json.Serialization;
	using Newtonsoft.Json.Converters;

	
	public partial class Default : System.Web.UI.Page
	{
		public void picture1Clicked (object sender, EventArgs e)
		{
			Firstitem.Visible = true;
			Image.Visible = false;
		}
		
		public void button1Clicked (object sender, EventArgs e)
		{
			object val = ViewState["ButtonClickCount"];
			//int i = (val == null)? 1 : (int)val + 1;
			//outputlabel.Text = string.Format ("You clicked me {0} {1}", i, i==1?"time":"times");

			string r = tb1.Value;

			string s = "";

			string[] ssize = r.Split(null);

			foreach (string l in ssize) {
				s += (l + "+");
			}
				
			string url1 = "http://www.omdbapi.com/?s=" + s;
	
			WebRequest wrGETURL1 = WebRequest.Create(url1);
			Stream objStream1 = wrGETURL1.GetResponse().GetResponseStream();

			StreamReader objReader1 = new StreamReader(objStream1);

			string sLine1 = objReader1.ReadLine();
		
			JObject Movie1 = JObject.Parse(sLine1);

			JToken ojut = Movie1;

			int x;

			if (Movie1.TryGetValue("Response", out ojut)) {
				ErrorString.Text = "No movie was found with that search term";
				x = 0;
				Image.Src = "Public/nores.png";
				Image2.Src = "Public/nores.png";
				Image3.Src = "Public/nores.png";
				Image4.Src = "Public/nores.png";
				Image5.Src = "Public/nores.png";
				Image6.Src = "Public/nores.png";
				Image7.Src = "Public/nores.png";
				Image8.Src = "Public/nores.png";
			}

			else
			{
			JArray items = (JArray)Movie1 ["Search"];

			x = items.Count;
			}


			if (x > 0) {

				Item1.Style.Add ("display", "block");

				string i = (string) Movie1 ["Search"] [0] ["imdbID"];

				string url = "http://www.omdbapi.com/?plot=full&i=" + i;

				WebRequest wrGETURL = WebRequest.Create (url);
				Stream objStream = wrGETURL.GetResponse ().GetResponseStream ();

				StreamReader objReader = new StreamReader (objStream);

				string sLine = objReader.ReadLine ();

				JObject Movie = JObject.Parse (sLine);

				string localFilename = "Public/1.jpg";

				if (Movie ["Poster"].ToString() != "N/A") {
					using (WebClient client = new WebClient ()) {
						client.DownloadFile ((string)Movie ["Poster"], localFilename);
					}
					Image.Src = localFilename;

				} 

				else {
					Image.Src = "Public/error.jpg";
				}

				Name.Text = "<b>Movie Title:</b>" + (string)Movie ["Title"];
				Date_Released.Text = "<b>Date Released:</b> " + (string)Movie ["Released"];
				Rating.Text = "<b>Rating:</b> " + (string)Movie ["Rated"];
				Runtime.Text = "<b>Runtime:</b> " + (string)Movie ["Runtime"];
				Genre.Text = "<b>Genre:</b> " + (string)Movie ["Genre"];
				Summary.Text = "<b>Summary:</b> " + (string)Movie ["Plot"];
				CRating.Text = "<b>Rating:</b> ";

				Meter.Attributes.Add ("value", (string)Movie ["imdbRating"]);

				Meter.Attributes.CssStyle.Add ("display", "inline");
			}

			if (x > 1) {

				Item2.Style.Add ("display", "block");


				string i = (string) Movie1 ["Search"] [1] ["imdbID"];

				string url = "http://www.omdbapi.com/?plot=full&i=" + i;

				WebRequest wrGETURL = WebRequest.Create (url);
				Stream objStream = wrGETURL.GetResponse ().GetResponseStream ();

				StreamReader objReader = new StreamReader (objStream);

				string sLine = objReader.ReadLine ();

				JObject Movie = JObject.Parse (sLine);

				string localFilename = "Public/2.jpg";
				if (Movie ["Poster"].ToString() != "N/A") {
					using (WebClient client = new WebClient ()) {
						client.DownloadFile ((string)Movie ["Poster"], localFilename);
					}
					Image2.Src = localFilename;
				} 

				else {
					Image2.Src = "Public/error.jpg";
				}
				Name2.Text = "<b>Movie Title:</b> " + (string)Movie ["Title"];
				Date_Released2.Text = "<b>Date Released:</b> " + (string)Movie ["Released"];
				Rating2.Text = "<b>Rating:</b> " + (string)Movie ["Rated"];
				Runtime2.Text = "<b>Runtime:</b> " + (string)Movie ["Runtime"];
				Genre2.Text = "<b>Genre:</b> " + (string)Movie ["Genre"];
				Summary2.Text = "<b>Summary:</b> " + (string)Movie ["Plot"];
				CRating2.Text = "<b>Rating:</b> ";

				Meter2.Attributes.Add ("value", (string)Movie ["imdbRating"]);

				Meter2.Attributes.CssStyle.Add ("display", "inline");
			}

			if (x > 2) {

				Item3.Style.Add ("display", "block");


				string i = (string) Movie1 ["Search"] [2] ["imdbID"];

				string url = "http://www.omdbapi.com/?plot=full&i=" + i;

				WebRequest wrGETURL = WebRequest.Create (url);
				Stream objStream = wrGETURL.GetResponse ().GetResponseStream ();

				StreamReader objReader = new StreamReader (objStream);

				string sLine = objReader.ReadLine ();

				JObject Movie = JObject.Parse (sLine);

				string localFilename = "Public/3.jpg";

				if (Movie ["Poster"].ToString() != "N/A") {
					using (WebClient client = new WebClient ()) {
						client.DownloadFile ((string)Movie ["Poster"], localFilename);
					}
					Image3.Src = localFilename;
				} 

				else {
					Image3.Src = "Public/error.jpg";
				}
				Name3.Text = "<b>Movie Title:</b> " + (string)Movie ["Title"];
				Date_Released3.Text = "<b>Date Released:</b> " + (string)Movie ["Released"];
				Rating3.Text = "<b>Rating:</b> " + (string)Movie ["Rated"];
				Runtime3.Text = "<b>Runtime:</b> " + (string)Movie ["Runtime"];
				Genre3.Text = "<b>Genre:</b> " + (string)Movie ["Genre"];
				Summary3.Text = "<b>Summary:</b> " + (string)Movie ["Plot"];
				CRating3.Text = "<b>Rating:</b> ";

				Meter3.Attributes.Add ("value", (string)Movie ["imdbRating"]);

				Meter3.Attributes.CssStyle.Add ("display", "inline");
			}
			if (x > 3) {

				Item4.Style.Add ("display", "block");


				string i = (string) Movie1 ["Search"] [3] ["imdbID"];

				string url = "http://www.omdbapi.com/?plot=full&i=" + i;

				WebRequest wrGETURL = WebRequest.Create (url);
				Stream objStream = wrGETURL.GetResponse ().GetResponseStream ();

				StreamReader objReader = new StreamReader (objStream);

				string sLine = objReader.ReadLine ();

				JObject Movie = JObject.Parse (sLine);

				string localFilename = "Public/4.jpg";
				if (Movie ["Poster"].ToString() != "N/A") {
					using (WebClient client = new WebClient ()) {
						client.DownloadFile ((string)Movie ["Poster"], localFilename);
					}
					Image4.Src = localFilename;
				} 

				else {
					Image4.Src = "Public/error.jpg";
				}
				Name4.Text = "<b>Movie Title:</b> " + (string)Movie ["Title"];
				Date_Released4.Text = "<b>Date Released:</b> " + (string)Movie ["Released"];
				Rating4.Text = "<b>Rating:</b> " + (string)Movie ["Rated"];
				Runtime4.Text = "<b>Runtime:</b> " + (string)Movie ["Runtime"];
				Genre4.Text = "<b>Genre:</b> " + (string)Movie ["Genre"];
				Summary4.Text = "<b>Summary:</b> " + (string)Movie ["Plot"];
				CRating4.Text = "<b>Rating:</b> ";

				Meter4.Attributes.Add ("value", (string)Movie ["imdbRating"]);

				Meter4.Attributes.CssStyle.Add ("display", "inline");
			}
			if (x > 4) {

				Item5.Style.Add ("display", "block");


				string i = (string) Movie1 ["Search"] [4] ["imdbID"];

				string url = "http://www.omdbapi.com/?plot=full&i=" + i;

				WebRequest wrGETURL = WebRequest.Create (url);
				Stream objStream = wrGETURL.GetResponse ().GetResponseStream ();

				StreamReader objReader = new StreamReader (objStream);

				string sLine = objReader.ReadLine ();

				JObject Movie = JObject.Parse (sLine);

				string localFilename = "Public/5.jpg";
				if (Movie ["Poster"].ToString() != "N/A") {
					using (WebClient client = new WebClient ()) {
						client.DownloadFile ((string)Movie ["Poster"], localFilename);
					}
					Image5.Src = localFilename;
				} 

				else {
					Image5.Src = "Public/error.jpg";
				}
				Name5.Text = "<b>Movie Title:</b> " + (string)Movie ["Title"];
				Date_Released5.Text = "<b>Date Released:</b> " + (string)Movie ["Released"];
				Rating5.Text = "<b>Rating:</b> " + (string)Movie ["Rated"];
				Runtime5.Text = "<b>Runtime:</b> " + (string)Movie ["Runtime"];
				Genre5.Text = "<b>Genre:</b> " + (string)Movie ["Genre"];
				Summary5.Text = "<b>Summary:</b> " + (string)Movie ["Plot"];
				CRating5.Text = "<b>Rating:</b> ";

				Meter5.Attributes.Add ("value", (string)Movie ["imdbRating"]);

				Meter5.Attributes.CssStyle.Add ("display", "inline");
			}

			if (x > 5) {

				Item6.Style.Add ("display", "block");


				string i = (string) Movie1 ["Search"] [5] ["imdbID"];

				string url = "http://www.omdbapi.com/?plot=full&i=" + i;

				WebRequest wrGETURL = WebRequest.Create (url);
				Stream objStream = wrGETURL.GetResponse ().GetResponseStream ();

				StreamReader objReader = new StreamReader (objStream);

				string sLine = objReader.ReadLine ();

				JObject Movie = JObject.Parse (sLine);

				string localFilename = "Public/6.jpg";
				if (Movie ["Poster"].ToString() != "N/A") {
					using (WebClient client = new WebClient ()) {
						client.DownloadFile ((string)Movie ["Poster"], localFilename);
					}
					Image6.Src = localFilename;
				} 

				else {
					Image6.Src = "Public/error.jpg";
				}
				Name6.Text = "<b>Movie Title:</b> " + (string)Movie ["Title"];
				Date_Released6.Text = "<b>Date Released:</b> " + (string)Movie ["Released"];
				Rating6.Text = "<b>Rating:</b> " + (string)Movie ["Rated"];
				Runtime6.Text = "<b>Runtime:</b> " + (string)Movie ["Runtime"];
				Genre6.Text = "<b>Genre:</b> " + (string)Movie ["Genre"];
				Summary6.Text = "<b>Summary:</b> " + (string)Movie ["Plot"];
				CRating6.Text = "<b>Rating:</b> ";

				Meter6.Attributes.Add ("value", (string)Movie ["imdbRating"]);

				Meter6.Attributes.CssStyle.Add ("display", "inline");
			}

			if (x > 6) {

				Item7.Style.Add ("display", "block");


				string i = (string) Movie1 ["Search"] [6] ["imdbID"];

				string url = "http://www.omdbapi.com/?plot=full&i=" + i;

				WebRequest wrGETURL = WebRequest.Create (url);
				Stream objStream = wrGETURL.GetResponse ().GetResponseStream ();

				StreamReader objReader = new StreamReader (objStream);

				string sLine = objReader.ReadLine ();

				JObject Movie = JObject.Parse (sLine);

				string localFilename = "Public/7.jpg";
				if (Movie ["Poster"].ToString() != "N/A") {
					using (WebClient client = new WebClient ()) {
						client.DownloadFile ((string)Movie ["Poster"], localFilename);
					}
					Image7.Src = localFilename;
				} 

				else {
					Image7.Src = "Public/error.jpg";
				}
				Name7.Text = "<b>Movie Title:</b> " + (string)Movie ["Title"];
				Date_Released7.Text = "<b>Date Released:</b> " + (string)Movie ["Released"];
				Rating7.Text = "<b>Rating:</b> " + (string)Movie ["Rated"];
				Runtime7.Text = "<b>Runtime:</b> " + (string)Movie ["Runtime"];
				Genre7.Text = "<b>Genre:</b> " + (string)Movie ["Genre"];
				Summary7.Text = "<b>Summary:</b> " + (string)Movie ["Plot"];
				CRating7.Text = "<b>Rating:</b> ";

				Meter7.Attributes.Add ("value", (string)Movie ["imdbRating"]);

				Meter7.Attributes.CssStyle.Add ("display", "inline");
			}

			if (x > 7) {

				Item8.Style.Add ("display", "block");


				string i = (string) Movie1 ["Search"] [7] ["imdbID"];

				string url = "http://www.omdbapi.com/?plot=full&i=" + i;

				WebRequest wrGETURL = WebRequest.Create (url);
				Stream objStream = wrGETURL.GetResponse ().GetResponseStream ();

				StreamReader objReader = new StreamReader (objStream);

				string sLine = objReader.ReadLine ();

				JObject Movie = JObject.Parse (sLine);

				string localFilename = "Public/8.jpg";
				if (Movie ["Poster"].ToString() != "N/A") {
					using (WebClient client = new WebClient ()) {
						client.DownloadFile ((string)Movie ["Poster"], localFilename);
					}
					Image8.Src = localFilename;
				} 

				else {
					Image8.Src = "Public/error.jpg";
				}
				Name8.Text = "<b>Movie Title:</b> " + (string)Movie ["Title"];
				Date_Released8.Text = "<b>Date Released:</b> " + (string)Movie ["Released"];
				Rating8.Text = "<b>Rating:</b> " + (string)Movie ["Rated"];
				Runtime8.Text = "<b>Runtime:</b> " + (string)Movie ["Runtime"];
				Genre8.Text = "<b>Genre:</b> " + (string)Movie ["Genre"];
				Summary8.Text = "<b>Summary:</b> " + (string)Movie ["Plot"];
				CRating8.Text = "<b>Rating:</b> ";

				Meter8.Attributes.Add ("value", (string)Movie ["imdbRating"]);

				Meter8.Attributes.CssStyle.Add ("display", "inline");
			}


		}
	}
}

