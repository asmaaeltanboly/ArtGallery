using DataAccessLayer.Entities.ArtWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Orders
{
    public class SculptureStock
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int SculptureId { get; set; }
        public Sculpture Sculpture { get; set; }

    }
}
