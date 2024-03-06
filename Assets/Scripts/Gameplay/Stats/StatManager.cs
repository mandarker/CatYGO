using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SYGO.Gameplay.Stats
{
    public sealed class StatManager
    {
        private Dictionary<string, Stat> _statDictionary;

        public StatManager()
        {
            _statDictionary = new Dictionary<string, Stat>();
        }

        public void AddStat(string statID, int value)
        {
            if (_statDictionary.ContainsKey(statID))
            {
                return;
            }

            Stat newStat = new Stat(statID, value);
            _statDictionary.Add(statID, newStat);
        }

        public void AddStat(Stat stat)
        {
            if (_statDictionary.ContainsKey(stat.StatID))
            {
                return;
            }

            _statDictionary.Add(stat.StatID, stat);
        }

        public void RemoveStat(string statID)
        {
            if (_statDictionary.ContainsKey(statID))
            {
                _statDictionary.Remove(statID);
            }
        }

        public void RemoveStat(Stat stat)
        {
            if (_statDictionary.ContainsKey(stat.StatID))
            {
                _statDictionary.Remove(stat.StatID);
            }
        }

        public bool GetStat(string statID, out int statValue)
        {
            if (_statDictionary.ContainsKey(statID))
            {
                statValue = _statDictionary[statID].CalculatedValue;

                return true;
            }
            else
            {
                statValue = -1;

                return false;
            }
        }

        public bool GetBaseStat(string statID, out int statValue)
        {
            if (_statDictionary.ContainsKey(statID))
            {
                statValue = _statDictionary[statID].CalculatedValue;

                return true;
            }
            else
            {
                statValue = -1;

                return false;
            }
        }

        public void ApplyStatModifier(IStatModifier modifier, string statID)
        {
            if (_statDictionary.ContainsKey(statID))
            {
                _statDictionary[statID].AddModifier(modifier);
            }
        }

        public void RemoveStatModifier(string statID)
        {
            if (_statDictionary.ContainsKey(statID))
            {
                _statDictionary.Remove(statID);
            }
        }
    }
}
