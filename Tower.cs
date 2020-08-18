namespace TreehouseDefense
{
    class Tower 
    {

        private const int _range = 1;
        private const int _power = 1;

        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            //add validatino to not put it on the path
            _location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
           
           foreach(Invader invader in invaders)
           {
               if(invader.IsActive && _location.InRangeOf(invader.Location,_range))
               {
                   invader.Hit(_power);
                   break;
               }
           }
        }



    }
}







