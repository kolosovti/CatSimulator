using CatSim.Core.Mood;
using UnityEngine;

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

        public CatModel()
        {
            _mood = MoodState.Good;
        }

        public void SetMoodState(MoodState mood)
        {
            Debug.Log($"New cat mood: {mood}, prev cat mood: {_mood}");
            _mood = mood;
        }
    }
}