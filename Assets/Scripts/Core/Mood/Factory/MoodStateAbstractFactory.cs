using System;
using CatSim.Configs.Actions;
using CatSim.Core.Mood;
using CatSim.Core.Mood.Factory;

namespace CatSim
{
    public class MoodStateAbstractFactory : IMoodStateFactory
    {
        private ICatModel _catModel;

        public MoodStateAbstractFactory(ICatModel catModel)
        {
            _catModel = catModel;
        }

        public MoodState ProduceMoodState(ActionConfig config)
        {
            switch (_catModel.Mood)
            {
                case MoodState.Bad:
                    return new BadMoodStateFactory().ProduceMoodState(config);
                case MoodState.Good:
                    return new GoodMoodStateFactory().ProduceMoodState(config);
                case MoodState.Excellent:
                    return new ExcellentMoodStateFactory().ProduceMoodState(config);
                default:
                    throw new Exception($"Factory for mood '{_catModel.Mood}' not defined");
            }
        }
    }
}