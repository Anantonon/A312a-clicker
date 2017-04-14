using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A312a_clicker
{
    public class Event
    {
        public delegate void RandomEvent();
        public List<RandomEvent> Events = new List<RandomEvent>();
        Person[] AllPeople;
        public bool Change = false;
        

        public Event(ref Person[] AllPeople)
        {
            this.AllPeople = AllPeople;
            Events.Add(MadsIsLate);
            Events.Add(Kernkraft400);
            Events.Add(Statusseminar);
            Events.Add(Vejledermøde);
            Events.Add(Citronmåne);
        }

        public void Reset()
        {
            AllPeople[0].Words_second = 2;
            AllPeople[1].Words_second = 100;
            AllPeople[2].Words_second = 5000;
            AllPeople[3].Words_second = 800000;
            AllPeople[4].Words_second = 1000000;
            AllPeople[5].Words_second = 999999999;
        }

        public void MadsIsLate()
        {
            AllPeople[3].Words_second /= 2;
        }

        public void Kernkraft400()
        {
            for(int i = 0; i <= 5; i++)
            {
                AllPeople[i].Words_second *= 2;
            }
        }

        public void Statusseminar()
        {
            
        }

        public void Vejledermøde()
        {

        }

        public void Citronmåne()
        {

        }
    }
}
