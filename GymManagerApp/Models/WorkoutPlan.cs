using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagerApp.Models
{
    public class WorkoutPlan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TrainerId { get; set; }
        public Trainer Trainer { get; set; }
        public ICollection<Workout> Workouts { get; set; } = new HashSet<Workout>();
    }
}
