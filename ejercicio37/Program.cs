using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ISound> sounds = new List<ISound>();
            sounds.Add(new Dog());
            sounds.Add(new Cat());
            foreach (ISound sound in sounds)
            {
                sound.MakeSound();

                if (sound is Animal animal)
                {
                    animal.DisplayType();
                }
                System.Console.WriteLine("--------------------------");

            }

        }
    }
}