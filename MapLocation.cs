namespace TreehouseDefense
{

    class MapLocation : Point 
    {

        public MapLocation(int x, int y, Map map) : base(x,y)
        {
            if(!map.OnMap(this))
            {
                //debugging implementation
                throw new System.Exception(x+", "+y+"is outside of the boundries of the map");
            }
        }

        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }


    }



}