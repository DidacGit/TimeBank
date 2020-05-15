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
    public enum loginOptions { EMAIL_ERROR, PASSWORD_ERROR, CORRECT };
    // Class to manage the access to the data base
    class ManageDB
    {
        public static Person myPerson;
        static TimeBankEntities1 entities = new TimeBankEntities1();
        public static void addPerson(Person person)
        {
            entities.People.Add(person);
            entities.SaveChanges();
        }
        public static bool checkIfMailExist(String mail)
        {
            Person person = entities.People
            .Where(p => p.email == mail).FirstOrDefault();
            if (person != null)
                return true;
            else
                return false;

        }
        //This can't be done if the user it's foreign key of any activity
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
        public static void addConsumerToActivity(Activity activity, Person consumer)
        {
            Activity activityToChange = findActivity(activity.activityId);
            activityToChange.userConsumer = consumer.userId;
            entities.SaveChanges();

        }
        public static Activity findActivity(int key)
        {
            return entities.Activities.Find(key);
        }
        public static List<Activity> getMyDoneActivities()
        {
            List<Activity> activities = new List<Activity>();

            activities = entities.Activities
            .Where(a => a.userConsumer != myPerson.userId && a.userProducer == myPerson.userId)
            .ToList();

            return activities;
        }
        public static List<Activity> getMyConsumedActivities()
        {
            List<Activity> activities = new List<Activity>();

            activities = entities.Activities
            .Where(a => a.userConsumer == myPerson.userId && a.userProducer != myPerson.userId)
            .ToList();

            return activities;
        }
        public static List<Activity> getMyPublishedActivities()
        {
            List<Activity> activities = new List<Activity>();

            activities = entities.Activities
            .Where(a => a.userConsumer == myPerson.userId && a.userProducer == myPerson.userId)
            .ToList();

            return activities;
        }
        public static List<Activity> getPublishedActivities()
        {
            List<Activity> activities = new List<Activity>();

            activities = entities.Activities
            .Where(a => a.userConsumer != myPerson.userId && a.userProducer == a.userConsumer)
            .ToList();

            return activities;
        }
        public static void removeActivity(Activity activity)
        {
            entities.Activities.Remove(activity);
            entities.SaveChanges();
        }
        // Make transaction and return true or return false
        public static bool transferHours(Activity activity)
        {
            activity.userConsumer = myPerson.userId;

            int consumerHours = myPerson.hours;
            if (consumerHours < activity.hours)
            {
                return false;
            } else
            {
                findPerson(activity.userProducer).hours += activity.hours;
                myPerson.hours -= activity.hours;
                entities.SaveChanges();
                return true;
            }
        }

        public static loginOptions checkLogin(string mail, string password)
        {
            myPerson = entities.People
                    .Where(p => p.email == mail)
                    .FirstOrDefault();
            if (myPerson != null)
            {

                    if (myPerson.password.Equals(password))
                        return loginOptions.CORRECT;
                    else
                        return loginOptions.PASSWORD_ERROR;
            }
            else
                return loginOptions.EMAIL_ERROR;
        }


        ////Check
        //public static Person login()
        //{

        //}

    }
}

