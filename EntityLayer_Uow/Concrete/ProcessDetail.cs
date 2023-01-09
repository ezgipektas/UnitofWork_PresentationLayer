using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer_Uow.Concrete
{
    public class ProcessDetail
    {
        public int ProcessDetailID { get; set; }
        public string Sender { get; set; }
        public string ReceiverName { get; set; }
        public decimal Amount { get; set; }
        public DateTime ProcessDate { get; set; }
    }
}
