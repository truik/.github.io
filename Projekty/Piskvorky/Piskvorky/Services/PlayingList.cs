using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Piskvorky.Data;

namespace Piskvorky.Services
{
    public class PlayingList
    {
        public string _Win { get; set; }
        public Pole Plocha;
        public int _Clicks { get; set; }
        public int _UP_DOWN { get; set; }
        public int _LEFT_RIGHT { get; set; }
        public int _LEFTUP_RIGHTDOWN { get; set; }
        public int _RIGHTUP_LEFTDOWN { get; set; }

        public PlayingList()
        {
            Plocha = new Pole();
            _Win = "";
            _Clicks = 0;
            _UP_DOWN = 0;
            _LEFT_RIGHT = 0;
            _LEFTUP_RIGHTDOWN = 0;
            _RIGHTUP_LEFTDOWN = 0;
        }
        public void UP_DOWN() { _UP_DOWN++; }
        public void LEFT_RIGHT() { _LEFT_RIGHT++; }
        public void LEFTUP_RIGHTDOWN() { _LEFTUP_RIGHTDOWN++; }
        public void RIGHTUP_LEFTDOWN() { _RIGHTUP_LEFTDOWN++; }
        public void Kliky()
        {
            _Clicks++;
        }
    }
}
