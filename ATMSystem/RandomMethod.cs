using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSystem
{
    public class RandomMethod
    {
        public string RandomMeth()
        {
            // set  to save idAccount
            HashSet<string> idAccount = new HashSet<string>();
            Random Random = new Random();
            string perfix = "202305";
            string randomNum;

            //use  do while loop to make a random number , and check if exist
            do
            {
                randomNum = perfix + Random.Next(1000, 9999).ToString();

            } while (idAccount.Contains(randomNum)); // ture : continue loop,  false: stop loop

            //add the random number to idAccount
            idAccount.Add(randomNum);
            return randomNum;
        }
    }
}
