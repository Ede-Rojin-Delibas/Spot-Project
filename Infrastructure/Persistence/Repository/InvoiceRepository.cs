using Application.Abstract;
using Application.ViewModals;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Persistence.Repository
{
    public class InvoiceRepository : IInvoiceRepository

    {
        public Invoice CreateInvoices(int kurum_id, int ay, int yil)
        {
            using (var Context = new AppDbContext())
            {
                var totalData = Context.Spot.Where(x => x.ay == ay && x.yil == yil && x.kurum_id == kurum_id).Sum(x => x.kapasite); //toplam kapasite

                var data1 = Context.Flow.Where(x => x.kurum_id==kurum_id && x.olcumzamani.Month== ay && x.olcumzamani.Year == yil).FirstOrDefault(); 

                Invoice invoice = new Invoice();
                
                invoice.totalCapacity = totalData;
                invoice.totalFlow =  (data1.basinc * data1.sıcaklik) / data1.enerji;
                invoice.capacityPrice = (invoice.totalCapacity + invoice.totalFlow) / 100;

                return invoice;
            
             
            }
           
            
        }
    }
}
