using System.Collections.Generic;
using System.Linq;
using FD.dal.data;

namespace FD.dal.man
{
    class UserManager
    {
        public static DataRepository<User> _d;

        public static int Save(User user)
        {
            var a = new User
            {
                UserId = user.UserId,
                UserFullName = user.UserFullName,
                UserName = user.UserName,
                UserPassword = user.UserPassword,
                UserLevel = user.UserLevel,
                UserIsActive = user.UserIsActive
            };

            using (_d = new DataRepository<User>())
            {
                if (user.UserId > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.UserId;
        }

        public static bool Delete(User unit)
        {
            using (_d = new DataRepository<User>())
            {
                _d.Delete(unit);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<User>())
            {
                _d.Delete(d => d.UserId == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<User> GetAll()
        {
            using (_d = new DataRepository<User>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }
    }
}
