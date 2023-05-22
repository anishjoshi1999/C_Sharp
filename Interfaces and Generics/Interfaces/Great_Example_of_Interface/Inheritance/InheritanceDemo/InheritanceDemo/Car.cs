using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Car:Vehicle,IDestroyable
    {
        public string DestructionSound { get; set; }
        public List<IDestroyable> DestroyablesNearBy;

        public Car(float speed,string color)
        {
            this.Speed = speed;
            this.Color = color;
            DestructionSound = "CarExplosionSound.mp3";
            DestroyablesNearBy = new List<IDestroyable>();
        }

        public void Destroy()
        {
            Console.WriteLine("Playing Destruction sound {0}",DestructionSound);
            Console.WriteLine("Create Fire");
            foreach (IDestroyable destroyable in DestroyablesNearBy)
            {
                destroyable.Destroy();
            }
        }
    }
}
