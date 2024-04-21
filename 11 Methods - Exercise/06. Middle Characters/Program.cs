namespace MiddleCharacters
          {
              class Program
                    {
                            public static void Main(string[] args)
                                {
                                        string input = Console.ReadLine();
            string output = Output(input);
            string[] arrOutput = output.Split(' ')
                .ToArray();
            foreach (string s in arrOutput)
            {
                Console.Write(s);
            }
                                        
                                        
                                 }
              private static string Output(string input)
                   {
                       string output = string.Empty;
                       bool isEven = false, isOdd = false;
                       if (input.Length%2==0)
                              {
                                  isEven = true;
                                }
                        else if(input.Length%2==1)
                               {
                                  isOdd = true;
                                }
                         for (int i = 0; i < input.Length; i++)
                             {

                                           char letter = input[i];
                if (isOdd)
                {
                    if (i == input.Length / 2 )
                    {
                        output += letter + " ";
                    }
                }
                else if (isEven)
                {
                    if (i == input.Length / 2 - 1)
                    {
                        output += letter + " ";
                    }
                    if (i == input.Length / 2 )
                    {
                        output += letter + " ";
                    }
                }
            }
                                     return output;
                                 }
                      }
            }