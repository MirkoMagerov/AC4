namespace AC3.DAO
{
    public interface IComarcaDAO
    {
        Region GetRegionById(int id);
        public List<Region> GetAllRegions();
        void AddRegion(Region region);
        void UpdateRegion(Region region);
        void DeleteRegion(int id);
    }
}
