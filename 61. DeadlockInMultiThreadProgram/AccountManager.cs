using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadlockInMultiThreadProgram
{
    public class AccountManager
    {
        Account _fromAccount;
        Account _toAccount;
        double _amountTransfer;

        public AccountManager(Account fromAccount, Account toAccount, double amountTransfer)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _amountTransfer = amountTransfer;
        }

        public void Transfer()
        {
            Console.WriteLine(Thread.CurrentThread.Name + "trying to acquire lock on" + _fromAccount.Id.ToString());

            lock (_fromAccount)
            {
                Console.WriteLine(Thread.CurrentThread.Name + "acquire lock on " + _fromAccount.Id.ToString());
                Thread.Sleep(1000);
                lock (_toAccount)
                {
                    Console.WriteLine("This code will be executed");
                    _fromAccount.Withdraw(_amountTransfer);
                    _toAccount.Deposit(_amountTransfer);
                }
            }
        }
    }
}
