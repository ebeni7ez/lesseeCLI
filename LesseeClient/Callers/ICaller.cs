using System.Collections.Generic;
using LesseeClient.Models;

static class Constants
{
    public const string baseUrl = "http://localhost:5000/";
}

namespace LesseeClient.Caller.Callers
{
    public interface ICaller
    {
        List<Hardware> GetHardwares(string platform);
        void Create(Hardware hardware);

        List<Platform> GetPlatforms();
        List<Lease> GetLeases(string active);
    }
}