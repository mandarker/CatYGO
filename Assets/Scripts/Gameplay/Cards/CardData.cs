using Mono.Cecil;
using SYGO.Gameplay.Cards.Effects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SYGO.Gameplay.Cards
{
    [CreateAssetMenu(menuName = "SYGO/Card Data")]
    public sealed class CardData : ScriptableObject
    {
        public enum CardType { NORMAL, EFFECT, MAGIC, TRAP }

        [SerializeField] private int _cardID;
        [SerializeField] private string _cardName;
        [SerializeField] private Texture2D _cardTexture;
        [SerializeField] private CardType _cardType;
        [SerializeField] private string _cardDescription;

        // conditional fields
        [SerializeField] private int _attack;
        [SerializeField] private int _defense;

        [SerializeField] private CardEffect[] _effects;

        public int CardID { get { return _cardID; } }
        public string CardName { get { return _cardName; } }
        public Texture2D CardTexture {  get { return _cardTexture; } }
        public CardType Type { get { return _cardType; } }
        public string CardDescription { get { return _cardDescription; } }

        public int Attack { get { return _attack; } }
        public int Defense { get { return _defense; } }
    }
}
