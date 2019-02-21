using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_04
{
    public class BadgeRepository
    {
        Dictionary<int, List<string>> _badgeDoorAccess = new Dictionary<int, List<string>>()
        {
            { 12345, new List<string>{ "A7" } },
            { 22345, new List<string>{"A1", "A4", "B1", "B2" }  },
            { 32345, new List<string>{"A4", "A5" } }
        };

        public Dictionary<int, List<string>> GetBadgeDoorAccessList()
        {
            return _badgeDoorAccess;
        }

        public void AddDoorsToBadge(int badge, List<string> doors)
        {
            _badgeDoorAccess.Add(badge, doors);
        }

        public Dictionary<int, List<string>> GetBadgeDoorDictionary()
        {
            return _badgeDoorAccess;
        }

        public void AddBadge(int badgeInput, List<string>doors)
        {
            _badgeDoorAccess.Add(badgeInput, doors);
        }

        public void RemoveBadge(int badge)
        {
            _badgeDoorAccess.Remove(badge);
        }

        public void RemoveDoorFromBadge(int badgeInput, string doorToRemove)
        {
            foreach (KeyValuePair<int, List<string>> badge in _badgeDoorAccess)
            {
                if (badge.Key == badgeInput)
                {
                    foreach (string door in badge.Value)
                    {
                        if (door == doorToRemove)
                        {
                            badge.Value.Remove(door);
                        }
                    }
                }
            }
        }
        public void UpdateDoorsToBadge(int badgeInput, string doorToAdd)
        {
            foreach (KeyValuePair<int, List<string>> badge in _badgeDoorAccess)
            {
                if (badge.Key == badgeInput)
                {
                    foreach (string door in badge.Value)
                    {
                        if (door == doorToAdd)
                        {
                            badge.Value.Add(door);
                        }
                    }
                }
            }
        }
    }

}

