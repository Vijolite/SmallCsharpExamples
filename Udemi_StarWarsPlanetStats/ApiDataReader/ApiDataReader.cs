using Udemi_StarWarsPlanetStats.JustInCaseDB;

public class ApiDataReader : IApiDataReader
{
    public async Task<string> Read(string baseAddress, string requestUri)
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(baseAddress);
        var response = await client.GetAsync(requestUri);

        response.EnsureSuccessStatusCode(); //through exception if getting data from api is not possible
        return await response.Content.ReadAsStringAsync();
        /*
        try
        {
            using var client = new HttpClient();
            client.BaseAddress = new Uri(baseAddress);
            var response = await client.GetAsync(requestUri);
        
            response.EnsureSuccessStatusCode(); //through exception if getting data from api is not possible
            return await response.Content.ReadAsStringAsync();
        }
        catch
        {   //returning prerecorded data if getting data from api is not possible
            Console.WriteLine("It was not possible to get data from API, here is example data");
            if (requestUri == "planets")
                return JustInCasePlanets.Data;
            else
            {
                var justInCaseResident = new JustInCaseResident();
                return justInCaseResident.GetData();
            }
        }
        */

    }
}
