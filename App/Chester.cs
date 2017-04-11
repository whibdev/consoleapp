using System;

namespace App
{
    public class Chester
    {
        public Chester()
        {
            this.Dob = DateTime.Now;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
    }
}
