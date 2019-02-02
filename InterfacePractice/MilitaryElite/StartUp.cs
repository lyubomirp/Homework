using MilitaryElite.Classes;
using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    class StartUp
    {
        static List<ISoldier> soldiers;
        static void Main(string[] args)
        {
            string[] types = { "Airforces", "Marines" };
            soldiers = new List<ISoldier>();
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (input[0] != "End")
            {
                if((input[0] == "Engineer" || input[0] == "Commando") && !types.Contains(input[5]) || input.Length<5)
                {
                input = Console.ReadLine().Split();
                    continue;
                }

                FillList(soldiers, input);

                input = Console.ReadLine().Split();

            }

            foreach (var solly in soldiers)
            {
                Console.Write(solly.ToString());
            }
        }





        private static void FillList(List<ISoldier> soldiers, string[] input)
        {
            switch (input[0])
            {
                case "Private":
                    Private newPrivate = new Private(double.Parse(input[4]), int.Parse(input[1]), input[2], input[3]);
                    soldiers.Add(newPrivate);
                    break;
                case "Spy":
                    Spy spy = new Spy(int.Parse(input[4]), int.Parse(input[1]), input[2], input[3]);
                    soldiers.Add(spy);
                    break;
                case "LieutenantGeneral":
                    LuitenantGeneral luitenantGeneral = new LuitenantGeneral(new List<Private>(), double.Parse(input[4]),
                        int.Parse(input[1]), input[2], input[3]);
                    if (input.Length >= 5)
                    {
                        for (int i = 5; i < input.Length; i++)
                        {
                            luitenantGeneral.Privates.Add(soldiers.Find(x => x.Id == int.Parse(input[i])) as Private);
                        }
                    }
                    soldiers.Add(luitenantGeneral);
                    break;
                case "Engineer":
                    Engineer engineer = new Engineer(new List<Repairs>(), input[5], double.Parse(input[4]),
                        int.Parse(input[1]), input[2], input[3]);
                    if (input.Length >= 6)
                    {
                        for (int i = 6; i < input.Length - 1; i += 2)
                        {
                            Repairs repair = new Repairs();
                            repair.HoursWorked = int.Parse(input[i + 1]);
                            repair.PartName = input[i];
                            engineer.Repairs.Add(repair);
                        }
                    }
                    soldiers.Add(engineer);
                    break;
                case "Commando":
                    Commando commando = new Commando(new List<Mission>(), input[5], double.Parse(input[4]), int.Parse(input[1])
                        , input[2], input[3]);
                    if (input.Length >= 6)
                    {
                        for (int i = 6; i < input.Length - 1; i += 2)
                        {
                            Mission mission = new Mission();
                            mission.CodeName = input[i];
                            if (input[i + 1] == "Finished")
                            {
                                mission.State = true;
                                commando.Missions.Add(mission);
                            }
                            if (input[i + 1] == "inProgress")
                            {
                                mission.State = false;
                                commando.Missions.Add(mission);
                            }
                        }
                    }
                    soldiers.Add(commando);
                    break;
            }
        }
    }
}
