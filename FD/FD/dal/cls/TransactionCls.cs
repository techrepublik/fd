using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FD.dal.data;

namespace FD.dal.cls
{
    class TransactionCls : Guest
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Qnty { get; set; }
        public float Price { get; set; }
        public float Amount { get; set; }
        public bool Active { get; set; }
        public string Types { get; set; }
    }
}
