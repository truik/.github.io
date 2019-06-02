using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Piskvorky.Data;
using Piskvorky.Services;

namespace Piskvorky.Pages
{
    public class GameModel : PageModel
    {
        public Space Value { get; set; }
        public string _win { get; set; }
        public string Win { get; set; }
        public string Znak { get; set; }
        public PlayingList Service { get; set;}
        public Name _name { get; set; }
        public Pole Plocha;

        public GameModel(Name name, Pole pole, PlayingList playingList)
        {
            _name = name;
            Plocha = pole;
            Service = playingList;
        }
        
        public string Text { get; set; }

        public void OnGet()
        {
            Text = _name._Name;
        }
        public IActionResult OnGetPlay(int X, int Y)
        {
            if( Plocha._Pole[X,Y].Value == "O" || Plocha._Pole[X,Y].Value == "X") { }
            else
            {
            Service.Kliky();
                if (Service._Clicks % 2 == 0)
                {
                    Plocha._Pole[X, Y].Value = "X";
                    Znak = "X";
                }
                else if (Service._Clicks % 2 == 1)
                {
                    Plocha._Pole[X, Y].Value = "O";
                    Znak = "O";
                }
            }
            if(Service._LEFTUP_RIGHTDOWN == 5 || Service._LEFT_RIGHT == 5 ||Service._UP_DOWN == 5 || Service._RIGHTUP_LEFTDOWN == 5)
            {
                return Redirect("./Win");
            }

            try
            {
                for (int i = 1; i < 5; i++)
                {
                    if (Plocha._Pole[X + i, Y + i].Value == Znak) { Service.RIGHTUP_LEFTDOWN(); }
                }
            }
            catch{}
            try
            {
                for (int i = 1; i < 5; i++)
                {
                    if (Plocha._Pole[X - i, Y - i].Value == Znak) { Service.RIGHTUP_LEFTDOWN(); }
                }
            }
            catch{}
            try
            {
                for (int i = 1; i < 5; i++)
                {
                    if (Plocha._Pole[X + i, Y].Value == Znak) { Service.LEFT_RIGHT(); }
                }
            }
            catch { }

            try
            {
                for (int i = 1; i < 5; i++)
                {
                    if (Plocha._Pole[X - i, Y].Value == Znak) { Service.LEFT_RIGHT(); }
                }
            }
            catch { }

            try
            {
                for (int i = 1; i < 5; i++)
                {
                    if (Plocha._Pole[X, Y + i].Value == Znak) { Service.UP_DOWN(); }
                }
            }
            catch { }

            try
            {
                for (int i = 1; i < 5; i++)
                {
                    if (Plocha._Pole[X, Y - i].Value == Znak) { Service.UP_DOWN(); }
                }
            }
            catch { }

            try
            {
                for (int i = 1; i < 5; i++)
                {
                    if (Plocha._Pole[X - i, Y + i].Value == Znak) { Service.LEFTUP_RIGHTDOWN(); }
                }
            }
            catch { }

            try
            {
                for (int i = 1; i < 5; i++)
                {
                    if (Plocha._Pole[X + i, Y - i].Value == Znak) { Service.LEFTUP_RIGHTDOWN(); }
                }
            }
            catch { }
            
            return RedirectToPage("./Game");
        }
}
}