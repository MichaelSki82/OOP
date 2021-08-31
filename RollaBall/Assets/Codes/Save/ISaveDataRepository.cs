namespace SkipinGame
{
    public interface ISaveDataRepository
    {
        void Save(PlayerBase player);
        void Load(PlayerBase player);
    }
}
