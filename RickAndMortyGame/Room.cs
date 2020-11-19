using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RickAndMortyGame.ProgramUI;

namespace RickAndMortyGame
{
    public class Room
    {
        public string Splash { get; }
        public List<string> Exits { get; }
        public List<Item> Items { get; }
        public void RemoveItem(Item item)
        {
            if (Items.Contains(item))
            {
                Items.Remove(item);
            }
        }

        public Room(string splash, List<string> exits, List<Item> items)
        {
            Splash = splash;
            Exits = exits;
            Items = items;
        }
    }
}
