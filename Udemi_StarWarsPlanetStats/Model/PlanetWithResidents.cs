﻿using System.Text.Json;
using Udemi_StarWarsPlanetStats.Dto;

namespace Udemi_StarWarsPlanetStats.Model
{
    public class PlanetWithResidents
    {
        private const string baseAddress = "swapi.dev/api/";

        private static IApiDataReader _apiDataReader;
        public string Name { get; set; }
        public string Diameter { get; set; }
        public string SurfaceWater { get; set; }
        public string Population { get; set; }
        public List<Resident> Residents { get; set; }

        public PlanetWithResidents(Result result, IApiDataReader apiDataReader)
        {
            Name = result.name;
            Diameter = result.diameter;
            SurfaceWater = result.surface_water;
            Population = result.population;
            _apiDataReader = apiDataReader;
            Residents = Extract(result.residents).GetAwaiter().GetResult();
        }

        public static async Task<List <Resident>> Extract (List<string> residentsUrls)
        {
            
            var residents = new List<Resident>();
            foreach (var url in residentsUrls)
            {
                var ind = url.IndexOf(baseAddress);
                var requestUri = url.Substring(ind + baseAddress.Length);
                var json = await _apiDataReader.Read("https://"+baseAddress, requestUri);
                var root = JsonSerializer.Deserialize<ResultResident>(json);
                var resident = new Resident(root);
                residents.Add(resident);
            }
            return residents;   
        }
    }
}
