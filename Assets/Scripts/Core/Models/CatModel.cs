using CatSim.Core.Mood;

namespace CatSim
{
    public interface ICatModel
    {
        public MoodState Mood { get; }
    }

    public class CatModel : ICatModel
    {
        private MoodState _mood;

        MoodState ICatModel.Mood => _mood;

        public void SetMoodState(MoodState mood)
        {
            _mood = mood;
        }
    }
}