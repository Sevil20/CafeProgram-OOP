using System;
using System.Collections;
using System.Collections.Generic;

namespace CafeProgramOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Yemekler ( yemekler, ickiler), menu
            // Istifadeci proqram acilanda menu ile qarsilasacaq ve istifadeciden secim edilmesi istenecek. Istifadeci secimlerini etdikden sonra ona odeyeceyi meblegi gosteririk.

            Menu menu = new Menu();
            menu.MealList.Add(new Meal("Yemek1", 5.5, false));
            menu.MealList.Add(new Meal("Yemek2", 2.3, true));
            menu.DrinkList.Add(new Drink("Icki1", 2.1, 1));
            menu.DrinkList.Add(new Drink("Icki2", 1.6, 2));
            menu.StartService();
        }
    }
}