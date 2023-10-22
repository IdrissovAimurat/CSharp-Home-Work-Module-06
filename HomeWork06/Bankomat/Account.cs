using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork06.Bankomat
{
    public class Account
    {
        public int AccountNumber { get; }
        public Client Owner { get; }
        public decimal Balance { get; private set; }

       public Account(Client owner, int accountNumber, decimal initialDeposit)
       {
            Owner = owner;
            AccountNumber = accountNumber;
            Balance = initialDeposit; 
       }

        public void Deposit(decimal summa)
        {
            if (summa > 0)
            {
                Balance += summa;
            }
        }
        public bool Vyvod(decimal summa)
        {
            if(summa > 0 && Balance >= summa)
            {
                Balance -= summa;
                return true;
            }
            return false;
        }
    }   
}
