using SYGO.Gameplay.Cards;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace SYGO.UI
{
    public class CardUIController : MonoBehaviour
    {
        [SerializeField] private TMP_Text _cardName;
        [SerializeField] private TMP_Text _cardDescription;

        [SerializeField] private TMP_Text _cardAttack;
        [SerializeField] private TMP_Text _cardDefense;

        public void InitCard(CardData cardData)
        {
            _cardName.text = cardData.CardName;
            _cardDescription.text = cardData.CardDescription;

            if (cardData.Type == CardData.CardType.MONSTER)
            {
                _cardAttack.text = "" + cardData.Attack;
                _cardDefense.text = "" + cardData.Defense;
            }
        }
    }
}
