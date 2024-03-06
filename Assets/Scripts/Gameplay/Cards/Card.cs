using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SYGO.Gameplay.Cards
{
    public interface Card
    {
        public void Play();
        public void Destroy();
    }
}
