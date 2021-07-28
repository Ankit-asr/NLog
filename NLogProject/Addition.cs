using System;
namespace NLogProject
{
    public class Addition
	{
        private readonly NLog nLog = new NLog();
        public int Sum(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0 || secondNumber == 0)
            {
                nLog.LogDebug("Debug successfull : sum()");
                nLog.LogError("Expecting null values");
                nLog.LogWarn("firstNumber or secondNumber should not be equal to 0");

                return 0;
            }
            int result = firstNumber + secondNumber;
            nLog.LogDebug("Debug successfull: sum()");
            nLog.LogInfo("Sum method passed, Result" + result);

            return result;

        }
    }
}