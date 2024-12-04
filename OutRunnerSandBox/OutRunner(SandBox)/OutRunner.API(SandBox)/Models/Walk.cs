using System;
using System.Collections.Generic;


namespace OutRunner.API_SandBox_.Models
{
    public class Walk
    {
        public int WalkId {get; set;}
        public int UserId {get; set;}
        public DateTime StartTime {get; set;}
        public DateTime EndTime { get; set; } 
        public float Distance { get; set; }
        public TimeSpan Duration { get; set; }
        public float AverageSpeed { get; set; }
        public float CaloriesBurned { get; set; }
        public string Route { get; set; }

    }
}
