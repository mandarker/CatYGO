using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SYGO.Gameplay.Stats
{
    public interface IStatModifier
    {
        public string GetStatModifierID();
        public int ModifyStat(int statValue);
    }
}