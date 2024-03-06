using SYGO.Gameplay.Cards;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SYGO.Gameplay.Game
{
    public sealed class CardDatabase
    {
        private HashSet<CardData> _cardHashset;

        private const string RESOURCE_PATH = "";

        public CardDatabase()
        {
            // load in the cards here
            _cardHashset = new HashSet<CardData>();

            CardData[] cardDatas = Resources.LoadAll<CardData>(RESOURCE_PATH);

            foreach (CardData cardData in cardDatas)
            {
                _cardHashset.Add(cardData);
            }
        }

        public CardData GetCardDataByID(int id)
        {

        }
    }
}
