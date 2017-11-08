using Founders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudCoinCE.Mobile
{
    public class CoinOps
    {
        #region Echo
        public static bool echoRaida()
        {
            RAIDA_Status.resetEcho();
            RAIDA raida1 = new RAIDA();
            Response[] results = raida1.echoAll(15000);
            int totalReady = 0;
            Console.Out.WriteLine("");
            //For every RAIDA check its results
            int longestCountryName = 15;

            Console.Out.WriteLine();
            for (int i = 0; i < 25; i++)
            {
                int padding = longestCountryName - RAIDA.countries[i].Length;
                string strPad = "";
                for (int j = 0; j < padding; j++)
                {
                    strPad += " ";
                }//end for padding
                 // Console.Out.Write(RAIDA_Status.failsEcho[i]);
                if (RAIDA_Status.failsEcho[i])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Out.Write(strPad + RAIDA.countries[i]);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Out.Write(strPad + RAIDA.countries[i]);
                    totalReady++;
                }
                if (i == 4 || i == 9 || i == 14 || i == 19) { Console.WriteLine(); }
            }//end for
            Console.ForegroundColor = ConsoleColor.White;
            Console.Out.WriteLine("");
            Console.Out.WriteLine("");
            Console.Out.Write("  RAIDA Health: " + totalReady + " / 25: ");//"RAIDA Health: " + totalReady );

            //Check if enough are good 
            if (totalReady < 16)//
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Out.WriteLine("  Not enough RAIDA servers can be contacted to import new coins.");// );
                Console.Out.WriteLine("  Is your device connected to the Internet?");// );
                Console.Out.WriteLine("  Is a router blocking your connection?");// );
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Out.WriteLine("The RAIDA is ready for counterfeit detection.");// );
                Console.ForegroundColor = ConsoleColor.White;
                return true;
            }//end if enough RAIDA
        }//End echo
        #endregion

    }
}
