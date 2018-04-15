using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Office
    {
        List<Person> workers = new List<Person>();
        delegate void MessageHello(Person name, int hour);
        delegate void MessageBye(Person name);
        MessageHello greetByUs = null;
        MessageBye byeByUs = null;

        public void AddWorker(Person person, int hour)
        {
            workers.Add(person);
            person.Came += new EventHandler(Person_Came);
            person.OnCame();
            if (greetByUs != null)
            {
                greetByUs(person, hour);
            }
            MessageHello greetByPerson = new MessageHello(person.Greet);
            greetByUs += greetByPerson;
            MessageBye byeByPerson = new MessageBye(person.GoodBye);
            byeByUs += byeByPerson;
        }

        public void RemoveWorker(Person person)
        {
            MessageHello greetByPerson = new MessageHello(person.Greet);
            greetByUs -= greetByPerson;
            person.Came -= new EventHandler(Person_Came);
            workers.Remove(person);
            person.Gone += new EventHandler(Person_Gone);
            person.IsGone();
            MessageBye byeByPerson = new MessageBye(person.GoodBye);
            byeByUs -= byeByPerson;
            if (byeByUs != null)
            {
                byeByUs(person);
            }
            person.Gone -= new EventHandler(Person_Gone);
        }

        public void Person_Came(object sender, EventArgs e)
        {
            Person person = (Person)sender;
            Console.WriteLine($"{person.Name} пришел(а)!");
        }

        public void Person_Gone(object sender, EventArgs e)
        {
            Person person = (Person)sender;
            Console.WriteLine($"{person.Name} ушел(ла)!");
        }
    }
}