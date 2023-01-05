using System;
using System.Numerics;

namespace _11.SmowBall
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            BigInteger value = 0;
            int snowBallSnowCnt = 0;
            int snowBallTimeCnt = 0;
            BigInteger snowBallQualityMax = 0;
            BigInteger maxValu = 0;

            for (int i = 0; i < num; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());

                

                value = BigInteger.Pow((BigInteger)(snowballSnow / snowballTime), snowBallQuality);

                if (maxValu < value)
                {
                    maxValu = value;
                    snowBallQualityMax = snowBallQuality;
                    snowBallSnowCnt = snowballSnow;
                    snowBallTimeCnt = snowballTime;
                  
                }
            }
            Console.WriteLine($"{snowBallSnowCnt} : {snowBallTimeCnt} = {maxValu} ({snowBallQualityMax})");
        }
    }
}
