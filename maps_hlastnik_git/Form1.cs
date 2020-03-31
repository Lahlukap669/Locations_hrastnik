using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;

namespace maps_hlastnik
{
    public partial class Map_form : Form
    {
        

        public Map_form()
        {
            InitializeComponent();

            try
            {
                System.Net.IPHostEntry e =
                     System.Net.Dns.GetHostEntry("www.google.com");
            }
            catch
            {
                gMapControl1.Manager.Mode = AccessMode.CacheOnly;
                MessageBox.Show("No internet connection avaible, going to CacheOnly mode.",
                      "GMap.NET - Demo.WindowsForms", MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
            }

            gMapControl1.MapProvider = GMapProviders.OpenStreetMap;
            gMapControl1.Position = new PointLatLng(46.357, 15.129);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
        }

        public void cMarker(double lat, double lon, string mesto, double tmp, double wind)
        {
            PointLatLng point = new PointLatLng(lat, lon);
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_small);
            marker.ToolTipText = mesto + ": " + "Temp: " + tmp.ToString() + "  Wind: " + wind.ToString();

            GMapOverlay markers = new GMapOverlay("markers");
            markers.Markers.Add(marker);
            gMapControl1.Overlays.Add(markers);
        }

        

        private void Load_Location_Click(object sender, EventArgs e)
        {


            HttpClient request = new HttpClient();

            request.BaseAddress = new Uri($"https://best-way.herokuapp.com/api/between/"+ StartLocation.Text + "/"+EndLocation.Text);

            request.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = request.GetAsync("").Result;
            if (response.IsSuccessStatusCode)
            { 
                string json = response.Content.ReadAsStringAsync().Result;

                dynamic json_o = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

                gMapControl1.Overlays.Clear();
                Display.Items.Clear();
                try
                {
                    for (int x = 0; x < 5; x++)
                {
                    
                        double lon = json_o.result[x].location.longitude;
                        double lat = json_o.result[x].location.latitude;
                        string mesto = json_o.result[x].weather.city;
                        double tmp = json_o.result[x].weather.temp;
                        double wind = json_o.result[x].weather.wind;
                        Display.Items.Add("Mesto: " + mesto + ", temp: " + tmp + ", veter: " + wind);
                        cMarker(lat, lon, mesto, tmp, wind);
                        Console.WriteLine(lon + " " + lat);
                    
                    }
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Couldn't find points between locations "+ StartLocation.Text + " and " + EndLocation.Text);
                    Console.WriteLine(e1.Message.ToString());
                }



            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }


            request.Dispose();
        }
    }
}
