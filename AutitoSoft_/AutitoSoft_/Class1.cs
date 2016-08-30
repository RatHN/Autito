using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Net.Sockets;

namespace AutitoSoft_
{


    public static class XivelyApi
    {
        //public static String GetDataDatastreams(String id)
        //{
        //    var url = "https://api.xively.com/v2/feeds/1380340989";

        //    var synClient = new WebClient();
        //    synClient.Credentials = new System.Net.NetworkCredential("neryortez", "Ajtama");
        //    var content = synClient.DownloadString(url);

        //    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(XivelyFeedFormat));
        //    using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
        //    {
        //        var weatherData = (XivelyFeedFormat)serializer.ReadObject(ms);
        //        foreach (var item in weatherData.datastreams)
        //        {
        //            if (item.id == id) return item.current_value;
        //        }
        //        return "======";
        //    }            
        //}



        public static String GetData(String id)
        {
            //var url = "https://api.xively.com/v2/feeds/1380340989/datastreams/";
            //url += id;

            //var synClient = new WebClient();
            //synClient.Credentials = new System.Net.NetworkCredential("neryortez", "Ajtama");
            //var content = synClient.DownloadString(url);
            Socket socketenvio=new Socket(;


            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Datastream));
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                var data = (Datastream)serializer.ReadObject(ms);
                //foreach (var item in weatherData.datastreams)
                //{
                //    if (item.id == id) return item.current_value;
                //}
                //return "======";
                return data.current_value;
            }
        }


        public static List<Datastream> GetDatastreams(String id1, String id2, String id3)
        {
            var url = "https://api.xively.com/v2/feeds/1380340989";

            var synClient = new WebClient();
            synClient.Credentials = new System.Net.NetworkCredential("neryortez", "Ajtama");
            var content = synClient.DownloadString(url);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(XivelyFeedFormat));
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                var weatherData = (XivelyFeedFormat)serializer.ReadObject(ms);
                List<Datastream> lista = new List<Datastream>();
                byte oo = 0;
                foreach (Datastream item in weatherData.datastreams)
                {
                    if (item.id == id1 || item.id == id2 || item.id == id3)
                        lista.Add(item);
                }
                return lista;
            }
        }

        public static List<String> GetDatastreams()
        {
            var url = "https://api.xively.com/v2/feeds/1380340989";

            var synClient = new WebClient();
            synClient.Credentials = new System.Net.NetworkCredential("neryortez", "Ajtama");
            var content = synClient.DownloadString(url);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(XivelyFeedFormat));
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                var weatherData = (XivelyFeedFormat)serializer.ReadObject(ms);
                List<String> lista = new List<string>();
                foreach (var item in weatherData.datastreams)
                {
                    lista.Add(item.id);
                }
                return lista;
            }
        }


        public static String SetData(String datastream, String value)
        {
            var url = "https://api.xively.com/v2/feeds/1380340989/datastreams/";
            url += datastream;

            String data = "{  \"current_value\": \"" + value + "\"}";

            var synClient = new WebClient();
            synClient.Credentials = new System.Net.NetworkCredential("neryortez", "Ajtama");
            var response = synClient.UploadString(url, "PUT", data);
            return response;
        }
    }


    public static class XivelyApi
    {
        //public static String GetDataDatastreams(String id)
        //{
        //    var url = "https://api.xively.com/v2/feeds/1380340989";

        //    var synClient = new WebClient();
        //    synClient.Credentials = new System.Net.NetworkCredential("neryortez", "Ajtama");
        //    var content = synClient.DownloadString(url);

        //    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(XivelyFeedFormat));
        //    using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
        //    {
        //        var weatherData = (XivelyFeedFormat)serializer.ReadObject(ms);
        //        foreach (var item in weatherData.datastreams)
        //        {
        //            if (item.id == id) return item.current_value;
        //        }
        //        return "======";
        //    }            
        //}



        public static String GetData(String id)
        {
            //var url = "https://api.xively.com/v2/feeds/1380340989/datastreams/";
            //url += id;

            //var synClient = new WebClient();
            //synClient.Credentials = new System.Net.NetworkCredential("neryortez", "Ajtama");
            //var content = synClient.DownloadString(url);


            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Datastream));
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                var data = (Datastream)serializer.ReadObject(ms);
                //foreach (var item in weatherData.datastreams)
                //{
                //    if (item.id == id) return item.current_value;
                //}
                //return "======";
                return data.current_value;
            }
        }


        public static List<Datastream> GetDatastreams(String id1, String id2, String id3)
        {
            var url = "https://api.xively.com/v2/feeds/1380340989";

            var synClient = new WebClient();
            synClient.Credentials = new System.Net.NetworkCredential("neryortez", "Ajtama");
            var content = synClient.DownloadString(url);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(XivelyFeedFormat));
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                var weatherData = (XivelyFeedFormat)serializer.ReadObject(ms);
                List<Datastream> lista = new List<Datastream>();
                byte oo = 0;
                foreach (Datastream item in weatherData.datastreams)
                {
                    if (item.id == id1 || item.id == id2 || item.id == id3)
                        lista.Add(item);
                }
                return lista;
            }
        }

        public static List<String> GetDatastreams()
        {
            var url = "https://api.xively.com/v2/feeds/1380340989";

            var synClient = new WebClient();
            synClient.Credentials = new System.Net.NetworkCredential("neryortez", "Ajtama");
            var content = synClient.DownloadString(url);

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(XivelyFeedFormat));
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                var weatherData = (XivelyFeedFormat)serializer.ReadObject(ms);
                List<String> lista = new List<string>();
                foreach (var item in weatherData.datastreams)
                {
                    lista.Add(item.id);
                }
                return lista;
            }
        }


        public static String SetData(String datastream, String value)
        {
            var url = "https://api.xively.com/v2/feeds/1380340989/datastreams/";
            url += datastream;

            String data = "{  \"current_value\": \"" + value + "\"}";

            var synClient = new WebClient();
            synClient.Credentials = new System.Net.NetworkCredential("neryortez", "Ajtama");
            var response = synClient.UploadString(url, "PUT", data);
            return response;          
        }
    }
}
