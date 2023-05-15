namespace CatSim.Core.Mood.Factory
{
    public interface IStateFactory
    {
        MoodState ProducePetActionMood();
        MoodState ProduceFeedActionMood();
        MoodState ProducePlayActionMood();
        MoodState ProduceKickActionMood();
        MoodState ProduceGoCloseActionMood();
    }
}