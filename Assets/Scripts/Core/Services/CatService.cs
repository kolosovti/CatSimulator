using CatSim.Core.Mood;

namespace CatSim
{
    public class CatService
    {
        private CatModel _catModel;

        public CatService(CatModel catModel)
        {
            _catModel = catModel;
        }

        public void SetMood(MoodState mood)
        {
            _catModel.SetMoodState(mood);
        }
    }
}