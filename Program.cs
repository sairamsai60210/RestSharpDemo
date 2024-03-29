﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;


namespace RestSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://reqres.in/");
            var request = new RestRequest("/api/users?page=2", Method.GET);
            request.AddHeader("Accept", "application/json");
            request.RequestFormat = DataFormat.Json;
            //Updated with new
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            Console.ReadKey();


            //added a comment locally
            //added new changes to master


        }
    }
}
