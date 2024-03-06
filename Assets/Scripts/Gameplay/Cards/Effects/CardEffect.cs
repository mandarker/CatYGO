using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

namespace SYGO.Gameplay.Cards.Effects
{
    [System.Serializable]
    public sealed class CardEffect
    {
        // needs a prerequisite
        [SerializeField] private List<CardEffectPrerequisite> prerequisites;

        public bool CheckPrerequisites()
        {
            for (int i = 0; i < prerequisites.Count; i++)
            {
                //if ()
            }

            return true;
        }
    }
}
