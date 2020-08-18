namespace TreehouseDefense
{
    class Path
    {
        private MapLocation[] _path;
        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetLocationAt(int pathStep)
        {
            //return null if out of index
            return (pathStep < _path.Length) ? _path[pathStep] :  null;
        }



    }
}