using DataAccessLayer.Entities.ArtWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Orders
{
    public class PaintStock
    { 
        public int Id { get; set; }
        public int Amount { get; set; }
        public int PaintId { get; set; }
        public Paint paint { get; set; }


    }
}
