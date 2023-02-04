namespace Instructions_Set
{
    internal class Instructions_Set
    {
        static void Main()
        {

            string opCode = Console.ReadLine();
            long result = 0;
            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');

                
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            result = ++operandOne;
                            break;
                        }
                    case "DEC":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            result = --operandOne;
                            break;
                        }
                    case "ADD":
                        {
                            int operandOne = int.Parse(codeArgs[1]);
                            int operandTwo = int.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            break;
                        }
                    case "MLA":
                        {
                            long operandOne = int.Parse(codeArgs[1]);
                            long operandTwo = int.Parse(codeArgs[2]);
                            result = operandOne * operandTwo;
                            break;
                        }
                        
                }

                opCode = Console.ReadLine();
                
            }

            Console.WriteLine(result);
        }
    }
}