using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeBank
{
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
    }
}
