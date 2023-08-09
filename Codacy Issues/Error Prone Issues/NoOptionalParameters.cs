﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codacy_Issues.Error_Prone_Issues
{
    internal class NoOptionalParameters
    {
        public void Eat(string meal, int amount = 1, bool isHungry = false)
        {
            try
            {

                if(!isHungry)
                {
                    Console.WriteLine("Not hungry at the moment..");
                }

                else if (amount == 1)
                {
                    Console.WriteLine($"I ate {amount} {meal}s on my own");
                }
                else
                {
                    Console.WriteLine($"I ate {amount} {meal} with friends");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public int Add(int a, int b = 0)
        {
            return a + b;
        }

        void Notify(string company, string office = "QJZ") // Noncompliant
        {
        }
    }
}