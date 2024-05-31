using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ResolveDeadlockInMultithreadedProgram
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
            object _lock1, _lock2;
            if(_fromAccount.Id< _toAccount.Id)
            {
                _lock1 = _fromAccount;
                _lock2 = _toAccount;
            }
            else
            {
                _lock1 = _toAccount;
                _lock2 = _fromAccount;
            }

           Console.WriteLine(Thread.CurrentThread.Name + "trying to acquire lock on " + ((Account)_lock1).Id.ToString());
            lock (_lock1)
            {
                Console.WriteLine(Thread.CurrentThread.Name + "acquired lock on" + ((Account)_lock1).Id.ToString());
                Console.WriteLine(Thread.CurrentThread.Name + "Suspended for 1 second");
                Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name+ " back in action and trying to acquire lock on"+ ((Account)_lock2).Id.ToString());
                lock (_lock2)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "acquired lock on" + ((Account)_lock1).Id.ToString());
                    _fromAccount.Withdraw(_amountTransfer);
                    _toAccount.Deposit(_amountTransfer);
                    Console.WriteLine(Thread.CurrentThread.Name + "Transfered" + _amountTransfer.ToString() + "from" + _fromAccount.Id.ToString() + "to" + _toAccount.Id.ToString());
                }
            }
        }
    }
}
