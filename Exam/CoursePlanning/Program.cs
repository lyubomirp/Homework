using System;
using System.Collections.Generic;
using System.Linq;

namespace CoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> program = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .Distinct()
                .ToList();

            string[] commands = Console.ReadLine()
                    .Split(new char[] { ':' },
                    StringSplitOptions.RemoveEmptyEntries);

            while (commands[0]!="course start")
            {

                commands = commands.Select(x => x.Trim()).ToArray();

                switch (commands[0])
                {
                    case "Add":
                        if (!program.Contains(commands[1]))
                        {
                            program.Add(commands[1]);
                        }
                        break;
                    case "Insert":
                        if(!program.Contains(commands[1]))
                        {
                            int index = int.Parse(commands[2]);
                            if(index<0 || index > program.Count())
                            {
                                break;
                            } else
                            {
                                program.Insert(index, commands[1]);

                            }

                        }
                        break;
                    case "Remove":
                        if (program.Contains(commands[1]))
                        {
                            program.RemoveAll(x => x.Contains(commands[1]));
                        }
                        break;
                    case "Swap":
                        if (program.Contains(commands[1]) && program.Contains(commands[2]))
                        {
                            int index1 = program.IndexOf(commands[1]);
                            int index2 = program.IndexOf(commands[2]);

                            List<string> temp = program.FindAll(x => x.Contains(commands[1]));
                            List<string> temp2 = program.FindAll(x => x.Contains(commands[2]));


                            

                            if (index1 > index2)
                            {
                                program.InsertRange(index2, temp);
                                program.RemoveRange(index2 + temp2.Count, temp2.Count);
                                program.InsertRange(index1, temp2);
                                program.RemoveRange(index1+temp2.Count, temp.Count);
                            } else
                            {
                                program.InsertRange(index2, temp);
                                program.InsertRange(index1, temp2);
                                program.RemoveRange(index1 + (Math.Max(temp2.Count, temp.Count)), temp.Count);
                                program.RemoveRange(index2 + (Math.Max(temp2.Count, temp.Count)), temp2.Count);
                            }
                        }
                        break;
                    case "Exercise":
                        if (program.Contains(commands[1]) && !program.Contains(commands[1]+"-Exercise"))
                        {
                            int index = program.IndexOf(commands[1]);
                            program.Insert(index+1, commands[1] + "-Exercise");

                        } else if (!program.Contains(commands[1] + "-Exercise"))
                        {
                            program.Add(commands[1]);
                            program.Add(commands[1] + "-Exercise");
                        }
                        break;
                }
                commands = Console.ReadLine()
                    .Split(new char[] { ':' },
                    StringSplitOptions.RemoveEmptyEntries);

                if(commands[0]=="course start")
                {
                    break;
                }
            }

            for (int i = 1; i <= program.Count; i++)
            {
                Console.WriteLine($"{i}.{program[i-1]}");
            }
        }
    }
}
