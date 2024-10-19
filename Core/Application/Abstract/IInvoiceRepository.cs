using Application.ViewModals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstract
{
    public interface IInvoiceRepository 
    {
        Invoice CreateInvoices(int kurum_id, int ay, int yil);
        
    }
}
