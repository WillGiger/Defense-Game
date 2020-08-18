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
                Path path= new Path(
                new [] {
                    new MapLocation(0,2, map),
                    new MapLocation(1,2, map),
                    new MapLocation(2,2, map),
                    new MapLocation(3,2, map),
                    new MapLocation(4,2, map),
                    new MapLocation(5,2, map),
                    new MapLocation(6,2, map),
                    new MapLocation(7,2, map)
                });



                



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


