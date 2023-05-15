using System.Collections;
using System.Collections.Generic;
using CatSim.Core.Mood;
using UnityEngine;

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
