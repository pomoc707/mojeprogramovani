﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratelstvi2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("napis spoje mezi lidmi: ");
            string vsechny_spoje_neupravene = Console.ReadLine();

            string[] vsechnyspojeupravene = vsechny_spoje_neupravene.Split();
            int pocet = vsechnyspojeupravene.Length;
            int[,] seznam_spoju = new int[pocet, 2];
        }
    }
}