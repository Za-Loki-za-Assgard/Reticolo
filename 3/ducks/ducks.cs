using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    interface IKryakable
    {
        void krya();
    }
    class Duck : IKryakable
    {
        public Duck()
        {
        }

        public virtual void krya()
        {
            Console.WriteLine("Hi! I'm an ordinary duck.");
        }
    }
    class DarkwingDuck : Duck
    {
        public override void krya()
        {
            Console.WriteLine("ОТ ВИНТА!");
        }
    }
    class UncleScrooge : Duck
    {
        public override void krya()
        {
            Console.WriteLine("Hi! I'm a Huey.");
        }
    }

    class DonaldDuck : UncleScrooge
    {
        public override void krya()
        {
            Console.WriteLine("Hi! I'm a Huey.");
        }
    }

    class Huey : DonaldDuck
    {
        public override void krya()
        {
            Console.WriteLine("Hi! I'm a Huey.");
        }
    }

    class Dewey : DonaldDuck
    {
        public override void krya()
        {
            Console.WriteLine("Hi! I'm a Dewey.");
        }
    }
    class Louie : DonaldDuck
    {
        public override void krya()
        {
            Console.WriteLine("Hi! I'm a Louie .");
        }
    }
    class LovingDuck : Duck
    {
        private String favoriteTeamName, newFavoriteTeamName;
        Random rnd = new Random();

        public void favoriteTeamKrya(List<string> teamList)
        {
            int num = rnd.Next(0, teamList.Count);
            newFavoriteTeamName = teamList[num];

            if (newFavoriteTeamName == favoriteTeamName)
            {
                Console.WriteLine("My favorite team is " + favoriteTeamName + " now.");
            }
            else
            {
                Console.WriteLine("Sorry, but i have changed my mind. My favorite team is " + newFavoriteTeamName + " now.");
            }

            favoriteTeamName = newFavoriteTeamName;
        }

    }

    class GrayDuck : Duck
    {
        public override void krya()
        {
            Console.WriteLine("Hi! I'm a gray duck.");
        }
    }

    class RubberDuck : Duck
    {
        public override void krya()
        {
            Console.WriteLine("Hi! I'm a rubber duck.");
        }
    }
    class WildDuck : Duck
    {
        public override void krya()
        {
            Console.WriteLine("Hi! I'm a wild duck.");
        }
    }

    class Program
    {
        public static void randomDuckKryaking(Dictionary<int, Duck> ducks)
        {
            int localTime = DateTime.Now.Millisecond;
            ducks[(localTime / 100) + 1].krya();
        }

        static void Main(string[] args)
        {
            Dictionary<int, Duck> ducks = new Dictionary<int, Duck>(11);

            Duck duck = new Duck();
            ducks.Add(1, duck);
            DarkwingDuck darkwingDuck = new DarkwingDuck();
            ducks.Add(2, darkwingDuck);
            UncleScrooge uncleScrooge = new UncleScrooge();
            ducks.Add(3, uncleScrooge);
            DonaldDuck donaldDuck = new DonaldDuck();
            ducks.Add(4, donaldDuck);
            Huey huey = new Huey();
            ducks.Add(5, huey);
            Dewey dewey = new Dewey();
            ducks.Add(6, dewey);
            Louie louie = new Louie();
            ducks.Add(7, louie);
            LovingDuck lovingDuck = new LovingDuck();
            ducks.Add(8, lovingDuck);
            GrayDuck grayDuck = new GrayDuck();
            ducks.Add(9, grayDuck);
            RubberDuck rubberDuck = new RubberDuck();
            ducks.Add(10, rubberDuck);
            WildDuck wildDuck = new WildDuck();
            ducks.Add(11, wildDuck);

            List<string> teamList = new List<string>();
            teamList.Add("Ёжики");
            teamList.Add("Решёточки");
            teamList.Add("Ретиколо");
            teamList.Add("Шарпеи");
            teamList.Add("ЪЕЪ");
            teamList.Add("Акцио");

            while (true)
            {
                string x = Convert.ToString(Console.ReadLine());
                lovingDuck.favoriteTeamKrya(teamList);
                randomDuckKryaking(ducks);
            }

        }
    }
}
