using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Application.Abstract;
using Domain;
using Domain.Entities;
using Persistence.Context;



namespace Persistence.Repository
{
    public class SpotRepository : ISpotRepository
    {
        public List<Spot> GetAllSpots()
        {    
            using (var context = new AppDbContext())
            {
                var data = context.Spot.OrderByDescending(x=> x.kapasite).ToList();

                return data;

            }
            
        }

        public List<Spot> GetByPeriod(int ay, int yil)
        {
            using (var context = new AppDbContext())
            {
                var data2 = context.Spot.Where(x=> x.ay==ay && x.yil==yil).ToList();
                return data2;
            }
            
        }
        public int GetByMonth(int ay, int yil) // dönüş tipini değiştirdik Spot tipinde değil int tipinde 
        {
            using (var context = new AppDbContext())
            {
                var capacity = context.Spot.Where(x => x.ay == ay && x.yil == yil).Sum(x => x.kapasite);
                return capacity;
            }
            
        }
    
    }
}
