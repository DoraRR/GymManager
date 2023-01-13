using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagerApp.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AltName { get; set; }
        public string Description { get; set; }
        public int Day { get; set; }
    }
}
