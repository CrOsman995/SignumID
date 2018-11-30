using System;
using System.Collections.Generic;
using System.Linq;

namespace SignumidTest
{
    class Actor
    {
        public string ActorName { get; set; }
        public string Action { get; set; }
    }
    class Program
    {

        static public List<string> CorrectOrder = new List<string>() { "LOAD", "FILL", "COMPLETE" };      
        
        private static bool CorrectlyOrdered(List<Actor> actionInput)
        {
            List<string> input = actionInput.Select(x => x.Action).Reverse().ToList<string>();
          
            List<string> order = CorrectOrder.AsEnumerable().Reverse().ToList();
            List<string> Check = new List<string>();
            int ElemCounter = 0;
            int IndexCounter = 0;
            foreach (string o in input)
            {
                if (!Check.Contains(o))
                {
                    Check.Add(o);
                    ElemCounter++;
                }
                else
                {
                    if (input[IndexCounter - 1] != o)
                    {
                        return false;
                    }
                }
                IndexCounter++;
            }
            if (Check.Count == 1) return true;
            for (int i = 0; i < Check.Count; i++)
            {
                if (Check[i] != order[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static void Main()
        {
            RunExampleDataset1();
            RunExampleDataset2();
            RunExampleDataset3();
            RunExampleDataset4();
            RunExampleDataset5();
            RunExampleDataset6();
            RunExampleDataset7();
            RunExampleDataset8();
            RunExampleDataset9();
            RunExampleDataset10();            
            Console.ReadLine();
        }

        private static void RunExampleDataset1()
        {
            var example = new List<Actor>
            {
                new Actor
                {
                    ActorName = "Test_1",
                    Action = "LOAD"
                },
                new Actor
                {
                    ActorName = "Test_2",
                    Action = "FILL"
                },
                new Actor
                {
                    ActorName = "Test_3",
                    Action = "COMPLETE"
                }
            };

            Console.WriteLine("Is example 1 correctly ordered (should be true): " + CorrectlyOrdered(example));
        }

        private static void RunExampleDataset2()
        {
            var example = new List<Actor>
            {
                new Actor
                {
                    ActorName = "Test_1",
                    Action = "FILL"
                },
                new Actor
                {
                    ActorName = "Test_2",
                    Action = "FILL"
                },
                new Actor
                {
                    ActorName = "Test_3",
                    Action = "COMPLETE"
                }
            };

            Console.WriteLine("Is example 2 correctly ordered (should be true): " + CorrectlyOrdered(example));
        }

        private static void RunExampleDataset3()
        {
            var example = new List<Actor>
            {
                new Actor
                {
                    ActorName = "Test_1",
                    Action = "COMPLETE"
                },
                new Actor
                {
                    ActorName = "Test_2",
                    Action = "LOAD"
                },
                new Actor
                {
                    ActorName = "Test_3",
                    Action = "COMPLETE"
                }
            };

            Console.WriteLine("Is example 3 correctly ordered (should be false): " + CorrectlyOrdered(example));
        }

        private static void RunExampleDataset4()
        {
            var example = new List<Actor>
            {
                new Actor
                {
                    ActorName = "Test_1",
                    Action = "LOAD"
                }
            };
            
            Console.WriteLine("Is example 4 correctly ordered (should be true): " + CorrectlyOrdered(example));
        }

        private static void RunExampleDataset5()
        {
            var example = new List<Actor>
            {
                new Actor
                {
                    ActorName = "Test_1",
                    Action = "FILL"
                }
            };

            Console.WriteLine("Is example 5 correctly ordered (should be true): " + CorrectlyOrdered(example));
        }

        private static void RunExampleDataset6()
        {
            var example = new List<Actor>
            {
                new Actor
                {
                    ActorName = "Test_1",
                    Action = "COMPLETE"
                }
            };

            Console.WriteLine("Is example 6 correctly ordered (should be true): " + CorrectlyOrdered(example));
        }
        
        private static void RunExampleDataset7()
        {
            var example = new List<Actor>
            {
                new Actor
                {
                    ActorName = "Test_1",
                    Action = "LOAD"
                },
                new Actor
                {
                    ActorName = "Test_2",
                    Action = "FILL"
                },
                new Actor
                {
                    ActorName = "Test_3",
                    Action = "FILL"
                },
                new Actor
                {
                    ActorName = "Test_4",
                    Action = "FILL"
                },
                new Actor
                {
                    ActorName = "Test_5",
                    Action = "COMPLETE"
                }
            };

            Console.WriteLine("Is example 7 correctly ordered (should be true): " + CorrectlyOrdered(example));
        }
        
        private static void RunExampleDataset8()
        {
            var example = new List<Actor>
            {
                new Actor
                {
                    ActorName = "Test_1",
                    Action = "FILL"
                },
                new Actor
                {
                    ActorName = "Test_2",
                    Action = "LOAD"
                },
                new Actor
                {
                    ActorName = "Test_3",
                    Action = "FILL"
                },
                new Actor
                {
                    ActorName = "Test_4",
                    Action = "LOAD"
                },
                new Actor
                {
                    ActorName = "Test_5",
                    Action = "LOAD"
                },
                new Actor
                {
                    ActorName = "Test_6",
                    Action = "COMPLETE"
                }
            };

            Console.WriteLine("Is example 8 correctly ordered (should be false): " + CorrectlyOrdered(example));
        }
        
        private static void RunExampleDataset9()
        {
            var example = new List<Actor>
            {
                new Actor
                {
                    ActorName = "Test_1",
                    Action = "LOAD"
                },
                new Actor
                {
                    ActorName = "Test_2",
                    Action = "LOAD"
                },
                new Actor
                {
                    ActorName = "Test_3",
                    Action = "FILL"
                },
                new Actor
                {
                    ActorName = "Test_4",
                    Action = "COMPLETE"
                },
                new Actor
                {
                    ActorName = "Test_5",
                    Action = "FILL"
                },
                new Actor
                {
                    ActorName = "Test_6",
                    Action = "COMPLETE"
                }
            };

            Console.WriteLine("Is example 9 correctly ordered (should be false): " + CorrectlyOrdered(example));
        }
        
        private static void RunExampleDataset10()
        {
            var example = new List<Actor>();
            Console.WriteLine("Is example 10 correctly ordered (should be true): " + CorrectlyOrdered(example));
        }
    }
}