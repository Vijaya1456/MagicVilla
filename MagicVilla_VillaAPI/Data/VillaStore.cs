using MagicVilla_VillaAPI.Models.Dto;
namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTo> villalist = new List<VillaDTo>
            {
                new VillaDTo{Id=1,Name="Pool View",Occupancy=100,Sqft=5},
                new VillaDTo{Id=2,Name="Beach VIew",Occupancy=1000,Sqft=9}
            };
    }
} 
