using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace breastcancer.Service
{
    internal class JsonReader
    {




        //static void Main(string[] args)
        //{
        //    List<Data> data = new List<Data>();

        //    using (StreamReader r = new StreamReader("data.json"))
        //    {
        //        string json = r.ReadToEnd();
        //        data = JsonSerializer.Deserialize<List<Data>>(json);
        //    }

        //    //List<DataReadyPerson> destination = source.Select(d => new DataReadyPerson
        //    //{
        //    //    CityOfResidence = d.City,
        //    //    fname = d.Firstname,
        //    //    lname = d.Lastname,
        //    //    DataReadPersonId = d.Id
        //    //}).ToList();


        //    string jsonString = JsonSerializer.Serialize(destination, new JsonSerializerOptions() { WriteIndented = true });
        //    using (StreamWriter outputFile = new StreamWriter("dataReady.json"))
        //    {
        //        outputFile.WriteLine(jsonString);
        //    }
        //}
    }
}
