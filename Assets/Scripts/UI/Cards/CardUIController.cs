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
        [SerializeField] private TMP_Text _cardAttackHeader;
        [SerializeField] private TMP_Text _cardDefenseHeader;

        [SerializeField] private SpriteRenderer _spriteRenderer;

        private MaterialPropertyBlock _materialPropertyBlock;

        private const string CARD_TEX_PROPERTY_ID = "_CardTex";
        private const string BG_OFFSET_PROPERTY_ID = "_ColorOffset";

        public void InitCard(CardData cardData)
        {
            _cardName.text = cardData.CardName;
            _cardDescription.text = cardData.CardDescription;

            if (cardData.Type != CardData.CardType.MAGIC &&
                cardData.Type != CardData.CardType.TRAP)
            {
                _cardAttack.text = "" + cardData.Attack;
                _cardDefense.text = "" + cardData.Defense;
                _cardAttackHeader.text = "ATK/";
                _cardDefenseHeader.text = "DEF/";
            }
            else
            {
                _cardAttack.text = "";
                _cardDefense.text = "";
                _cardAttackHeader.text = "";
                _cardDefenseHeader.text = "";
            }

            if (_materialPropertyBlock == null)
                _materialPropertyBlock = new MaterialPropertyBlock();
            _materialPropertyBlock.SetTexture(CARD_TEX_PROPERTY_ID, cardData.CardTexture);
            _materialPropertyBlock.SetInt(BG_OFFSET_PROPERTY_ID, (int)cardData.Type);

            _spriteRenderer.SetPropertyBlock(_materialPropertyBlock);
            
        }
    }
}
