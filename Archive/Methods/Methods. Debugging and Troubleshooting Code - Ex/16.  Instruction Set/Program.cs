using System;
using System.Numerics;
namespace _16.__Instruction_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opCode = Console.ReadLine();
            BigInteger result = 0;
            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');              
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = operandOne+1;
                            break;
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            result = operandOne-1;
                            break;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = (operandOne + operandTwo);
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne * operandTwo;
                            break;
                        }
                }
                opCode = Console.ReadLine();
                Console.WriteLine(result);
            }
            
        }
    }
}
