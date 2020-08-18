using System;
namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8,5);
            //debugging tools 
            try 
            {
                MapLocation mapLocation = new MapLocation(20,20, map);

            } 
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(TreehouseDefenseException)
            {
                //used for future proofing
                Console.WriteLine("Unhandled TreehouseDefenseException");
            }
            catch(Exception)
            {
                //used for future proofing
                Console.WriteLine("Unhandled Exception");
            }



        }

    }
}


