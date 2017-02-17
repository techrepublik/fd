using System.Collections.Generic;
using System.Linq;
using FD.dal.data;


namespace FD.dal.man
{
    class TransactionTypeManager
    {
        public static DataRepository<TransactionType> _d;

        public static int Save(TransactionType transactionType)
        {
            var a = new TransactionType
            {
               TransactionTypeId = transactionType.TransactionTypeId,
               TransactionTypeName = transactionType.TransactionTypeName,
               TransactionTypeAmount = transactionType.TransactionTypeAmount
            };

            using (_d = new DataRepository<TransactionType>())
            {
                if (transactionType.TransactionTypeId > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.TransactionTypeId;
        }

        public static bool Delete(TransactionType transactionType)
        {
            using (_d = new DataRepository<TransactionType>())
            {
                _d.Delete(transactionType);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<TransactionType>())
            {
                _d.Delete(d => d.TransactionTypeId == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<TransactionType> GetAll()
        {
            using (_d = new DataRepository<TransactionType>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }
    }
}
