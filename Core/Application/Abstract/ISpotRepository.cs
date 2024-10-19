using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;


namespace Application.Abstract
{
    public interface ISpotRepository
    {
        List<Spot> GetAllSpots();

        List<Spot> GetByPeriod(int ay, int yil);

        int GetByMonth(int ay, int yil);


    }
}
