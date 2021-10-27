using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class CarImage : IEntity
    {
        private DateTime date;
        public int Id { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date
        {
            get { return date; }
            set { value = DateTime.Now; }
        }
    }
}
