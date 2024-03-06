using SYGO.Gameplay.Cards;
using SYGO.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SYGO.Tests
{
    public sealed class TestCardUIController : MonoBehaviour
    {
        [SerializeField] private CardData _testCardData;
        [SerializeField] private CardUIController _cardUIController;

        private void Awake()
        {
            _cardUIController.InitCard(_testCardData);
        }
    }
}
