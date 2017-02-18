using FD.dal.data;
using System.Collections.Generic;
using System.Linq;


namespace FD.dal.man
{
    class UserLevelManager
    {
        public static DataRepository<UserLevel> _d;

        public static int Save(UserLevel userLevel)
        {
            var a = new UserLevel
            {
                UserLevelId = userLevel.UserLevelId,
                UserLevel1 = userLevel.UserLevel1,
                UserIsActive = userLevel.UserIsActive
            };

            using (_d = new DataRepository<UserLevel>())
            {
                if (userLevel.UserLevelId > 0)
                    _d.Update(a);
                else _d.Add(a);

                _d.SaveChanges();
            }

            return a.UserLevelId;
        }

        public static bool Delete(UserLevel userLevel)
        {
            using (_d = new DataRepository<UserLevel>())
            {
                _d.Delete(userLevel);
                _d.SaveChanges();
            }

            return true;
        }

        public static bool Delete(int iId)
        {
            using (_d = new DataRepository<UserLevel>())
            {
                _d.Delete(d => d.UserLevelId == iId);
                _d.SaveChanges();
            }

            return true;
        }

        public static List<UserLevel> GetAll()
        {
            using (_d = new DataRepository<UserLevel>())
            {
                _d.LazyLoadingEnabled = false;
                return _d.GetAll().ToList();
            }
        }
    }
}
