
using System;
using System.Collections.Generic;
using System.Linq;

namespace MonsterExtermination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> armorMonster = new Queue<int>(Console.ReadLine()
                .Split(",")
                .Select(int.Parse));
            Stack<int> soldierStrike = new Stack<int>(Console.ReadLine()
                .Split(",")
                .Select(int.Parse));
            int monstersKilled = 0;

            while (armorMonster.Any() && soldierStrike.Any())
            {
                int armor = armorMonster.Peek();
                int strike = soldierStrike.Peek();
                if (strike >= armor)//Ако поразяващото въздействие на войника е по-голямо или равно на бронята на чудовището
                {
                    monstersKilled++;//чудовището се убива
                    strike -= armor;//ударното въздействие на войника се намалява със стойността на бронята


                    if (strike == 0)
                    {
                        soldierStrike.Pop();//бронята му се премахва от последователността
                        armorMonster.Dequeue();//След това  на чудовището
                    }
                    else//Нулевите стойности не трябва да се връщат обратно към последователността.
                    {
                        armorMonster.Dequeue();
                        if (soldierStrike.Count == 1)
                        {
                            soldierStrike.Pop();
                            soldierStrike.Push(strike);
                            continue;

                        }
                        else
                        {//Оставащата стойност на ударния удар се добавя към следващия ударен елемент в последователността (ако има такъв) или се счита за последен и единствен елемент
                            soldierStrike.Pop();
                            soldierStrike.Push(soldierStrike.Pop() + strike);
                        }
                    }
                }
                else//• Ако поразяващото въздействие на войника е по-малко от бронята на чудовището,ударът се изпълнява, но
                {
                    armor -= strike;//чудовището оцелява с намалена броня и стойността на бронята на чудовището се намалява с първоначалната стойност на удара.
                    soldierStrike.Pop();//Стойността на ударния удар на войника се премахва от последователността
                    armorMonster.Dequeue();
                    armorMonster.Enqueue(armor);//След това чудовището се премества в задната част на последователността.
                                                
                }
            }

            if (!armorMonster.Any())// ако няма чудовища
            {
                Console.WriteLine("All monsters have been killed!");
            }

            if (!soldierStrike.Any())//ако няма войници
            {
                Console.WriteLine("The soldier has been defeated.");
            }
            Console.WriteLine($"Total monsters killed: {monstersKilled}");
        }
    }
}
