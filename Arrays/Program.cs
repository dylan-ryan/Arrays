using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
            //multiple weapons w/arrays
            //0 pistol
            //1 shotgun
            //2 spreader
            //3 rocket launcher
            static int[] ammo; //declaration
                        // "int[]" = new type of int = "array of ints"
            
            static int currentWeapon;
        static void Main(string[] args)
        {

            Console.WriteLine("Arrays");
            Console.WriteLine("-------");
            Console.WriteLine();

            //single weapon
            //weapon ammo amount
            //int ammo;
            //ammo = 0;
            //Fire()
            //Reload()
            //range check (0...50)


            //multiple weapons
            //weapon ammo(for all weapons)
            //-pistol
            //-shotgun
            //-spreader
            //-rocket launcher
            //int pistolAmmo;
            //int shotgunAmmo;
            //int spreaderAmmo;
            //int rocketLauncherAmmo;
            //string currentWeapon;
            //if currentWeapon is an int do: 0=pistol, 1=shotgun,2=spreader.....
            //Fire()
            //if (currentWeapon == "pistol)...
            // {
            //   //range check
            //   pistolAmmo = pistolAmmo - 1;
            // }
            //else if (currentWeapon == "shotgun")....
            //else if (currentWeapon == "...")...


            ammo = new int[4]; //..//instatiation(NEW)--make sure theres memory, could fail
            //..// initialization
            ammo[0] = 50; //pistol
            ammo[1] = 20; //spreader
            ammo[2] = 100; //spreader
            ammo[3] = 6; //rocketLauncher
            //ammo[4] = 0; <-- will not work, outside bounds of array
            currentWeapon = 0; //pistol
            //Fire(int currentWeapon)
            //PickUp(int weaponType)


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }

        static void Fire(int currentWeapon)
        {
            if (ammo[currentWeapon] > 0)
            {
                ammo[currentWeapon] = ammo[currentWeapon] - 1;
            }
        }

        static void Reload(int currentWeapon)
        {
            
        }
    }
}
