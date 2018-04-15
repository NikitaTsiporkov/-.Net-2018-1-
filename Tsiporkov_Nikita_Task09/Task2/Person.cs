using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Person
    {
        delegate void GetMessage();
        public event EventHandler Came;
        public event EventHandler Gone;

        public string Name { get; set; }

        public void OnCame()
        {
            Came(this, EventArgs.Empty);
        }

        public void IsGone()
        {
            Gone(this, EventArgs.Empty);
        }

        public void Greet(Person anotherPerson, int hour)
        {
            GetMessage del;
            if (hour < 12)
            {
                del = GoodMorning;
            }
            else if (hour < 17)
            {
                del = GoodAfternoon;
            }
            else
            {
                del = GoodEvening;
            }
            del.Invoke();
        Console.WriteLine(", {0}!', - сказал(а) {1}.", anotherPerson.Name, Name);
        }

        public void GoodBye(Person anotherPerson)
        {
            Console.WriteLine("До свидания, {0}!', - сказал(а) {1}.", anotherPerson.Name,Name);
        }

        private void GoodMorning()
        {
            Console.Write("'Доброе утро");
        }

        private void GoodEvening()
        {
            Console.Write("'Добрый вечер");
        }

        private void GoodAfternoon()
        {
            Console.Write("'Добрый день");
        }
    }
}
