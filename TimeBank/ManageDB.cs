using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeBank
{
    // Class to manage the access to the data base
    class ManageDB
    {
        static TimeBankEntities entities = new TimeBankEntities();
        public static void addPerson(Person person)
        {
            entities.People.Add(person);
            entities.SaveChanges();
        }
        public static void removePerson(Person person)
        {
            entities.People.Remove(person);
            entities.SaveChanges();
        }
        public static Person findPerson(int key)
        {
            return entities.People.Find(key);
        }
        public static void addActivity(Activity activity)
        {
            entities.Activities.Add(activity);
            entities.SaveChanges();

        }
        public static void removeActivity(Activity activity)
        {
            entities.Activities.Remove(activity);
            entities.SaveChanges();
        }
        // Make transaction and return true or return false
        public static bool transferHours(Person producer, Person consumer, int hours)
        {
            int consumerHours = consumer.hours;
            if (consumerHours < hours)
            {
                return false;
            } else
            {
                producer.hours += hours;
                consumer.hours -= hours;
                entities.SaveChanges();
                return true;
            }
        }
    }
}
