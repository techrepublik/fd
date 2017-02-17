using System.Collections.Generic;
using System.Linq;
using FD.dal.data;

namespace FD.dal.man
{
    class TransactionManager
    {
        public static DataRepository<Transaction> _d;

        public static int Save(Transaction transaction)
        {
            var a = new Transaction
            {
                TransactionId = transaction.TransactionId,
                TransactionDate = transaction.TransactionDate,
                TransactionAmount = transaction.TransactionAmount,
                TransactionPrice = transaction.TransactionPrice,
                TransactionQnty = transaction.TransactionQnty,
                TransactionIsActive = transaction.TransactionIsActive,
                UserId = transaction.UserId,
                TransactionTypeId = transaction.TransactionTypeId,
                GuestId = transaction.GuestId
            };

            using (_d = new DataRepository<Transaction>())
            {
                if (transaction.TransactionId > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.TransactionId;
        }

        public static bool Delete(Transaction transaction)
        {
            using (_d = new DataRepository<Transaction>())
            {
                _d.Delete(transaction);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Transaction>())
            {
                _d.Delete(d => d.UserId == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Transaction> GetAll()
        {
            using (_d = new DataRepository<Transaction>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }
    }
}
