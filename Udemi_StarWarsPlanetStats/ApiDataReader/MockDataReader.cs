using Udemi_StarWarsPlanetStats.JustInCaseDB;

public class MockDataReader : IApiDataReader
{
    public async Task<string> Read(string baseAddress, string requestUri)
    {
        if (requestUri == "planets")
            return JustInCasePlanets.Data;
        else
        {
            var justInCaseResident = new JustInCaseResident();
            return justInCaseResident.GetData();
        }
    }
}
