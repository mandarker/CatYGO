using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SYGO.Gameplay.Stats
{
    public sealed class Stat
    {
        private string _id;
        private int _baseValue;
        private int _calculatedValue;

        private List<IStatModifier> _statModifiers;

        public Stat(string statID, int value)
        {
            _id = statID;
            _baseValue = value;

            _statModifiers = new List<IStatModifier>();
        }

        public string StatID => _id;
        public int BaseValue => _baseValue;
        public int CalculatedValue => _calculatedValue;

        private void CalculateStatValue()
        {
            _calculatedValue = _baseValue;

            for (int i = 0; i < _statModifiers.Count; ++i)
            {
                _calculatedValue = _statModifiers[i].ModifyStat(_calculatedValue);
            }
        }

        public void AddModifier(IStatModifier modifier)
        {
            if (!_statModifiers.Contains(modifier))
            {
                _statModifiers.Add(modifier);

                CalculateStatValue();
            }
        }

        public void RemoveModifier(IStatModifier modifier)
        {
            if (_statModifiers.Contains(modifier))
            {
                _statModifiers.Remove(modifier);

                CalculateStatValue();
            }
        }

        public void RemoveModifier(string modifierID)
        {
            for (int i = 0; i < _statModifiers.Count; i++)
            {
                if (_statModifiers[i].GetStatModifierID().Equals(modifierID))
                {
                    _statModifiers.RemoveAt(i);
                    i--;
                }
            }

            CalculateStatValue();
        }
    }
}