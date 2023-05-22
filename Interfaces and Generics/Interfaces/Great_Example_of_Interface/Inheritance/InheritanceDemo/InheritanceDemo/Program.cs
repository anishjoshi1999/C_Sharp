using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args) {
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair= new Chair("Red", "Wood");


            Car damagedCar = new Car(80f, "Blue");

            damagedCar.DestroyablesNearBy.Add(officeChair);
            damagedCar.DestroyablesNearBy.Add(gamingChair);


            damagedCar.Destroy();

        }
    }
}
