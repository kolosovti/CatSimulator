using CatSim.Configs.Actions;

namespace CatSim.Core.Mood.Factory
{
    public interface IMoodStateFactory
    {
        MoodState ProduceMoodState(ActionConfig config);
    }
}