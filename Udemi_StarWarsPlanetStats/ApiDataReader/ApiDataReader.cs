using Udemi_StarWarsPlanetStats.JustInCaseDB;

public class ApiDataReader : IApiDataReader
{
    public async Task<string> Read(string baseAddress, string requestUri)
    {
        using var client = new HttpClient();
        client.BaseAddress = new Uri(baseAddress);
        var response = await client.GetAsync(requestUri);
        
        try
        {
            response.EnsureSuccessStatusCode(); //through exception if getting data from api is not possible
            return await response.Content.ReadAsStringAsync();
        }
        catch
        {   //returning prerecorded data if getting data from api is not possible
            if (requestUri == "planets")
                return JustInCasePlanets.Data;
            else
            {
                var justInCaseResident = new JustInCaseResident();
                return justInCaseResident.GetData();
            }
        }

    }
}
