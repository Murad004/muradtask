using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHomeTask
{
    class Helper
    {

        public static bool checkPinCorIncor(User[]users,string pin)
        {
            foreach (var item in users)
            {
                if (pin == item.creditCard.Pin)
                {
                    return true;
                }
            }
            throw new Exception("You PIN incorrect!");
        }
        public static bool CheckPan(string pan)
        {
            if (pan.Length == 16)
            {
                return true;
            }
            throw new Exception("PAN character count must be 16");
        }
        public static bool CheckPin(string pin)
        {
            if (pin.Length == 4)
            {
                return true;
            }
            throw new Exception("PIN character count must be 4");
        }

        public static bool CheckChooseBalance(User[]users,int balance)
        {
            if (balance >= 10)
            {
                foreach (var item in users)
                {
                    if (balance <= item.creditCard.Balance)
                    {
                        return true;
                    }
                }
                throw new Exception("Your choose more than balance!");
            }
            throw new Exception("Must be greater than 10 of your choice");
            
        }
        
    }
}
