using System.Collections.Generic;
using System.Linq;
using FD.dal.data;

namespace FD.dal.man
{
    class GuestManager
    {
        public static DataRepository<Guest> _d;

        public static int Save(Guest guest)
        {
            var a = new Guest
            {
                GuestId = guest.GuestId,
                GuestName = guest.GuestName,
                GuestAddress = guest.GuestAddress,
                GuestEmail = guest.GuestEmail,
                GuestContact = guest.GuestContact
            };

            using (_d = new DataRepository<Guest>())
            {
                if (guest.GuestId > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.GuestId;
        }

        public static bool Delete(Guest guest)
        {
            using (_d = new DataRepository<Guest>())
            {
                _d.Delete(guest);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<Guest>())
            {
                _d.Delete(d => d.GuestId == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<Guest> GetAll()
        {
            using (_d = new DataRepository<Guest>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }
    }
}
