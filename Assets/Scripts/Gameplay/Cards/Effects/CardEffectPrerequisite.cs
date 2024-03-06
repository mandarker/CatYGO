using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SYGO.Gameplay.Cards.Effects
{
    [System.Serializable]
    public class CardEffectPrerequisite
    {
        public enum CardEffectPrereqArea { BOARD }
        public enum CardEffectPrereqCheckType { MONSTER }
        public enum CardEffectComparer { LESS, EQUAL, GREATER }

        [SerializeField] private CardEffectPrereqArea _area;
        [SerializeField] private CardEffectPrereqCheckType _checkType;
        [SerializeField] private CardEffectComparer _comparer;

        [SerializeField] private int _altValue;
        [SerializeField] private int _compValue;

        public bool CheckPrerequisite()
        {
            return false;
        }
    }
}