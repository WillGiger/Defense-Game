namespace TreehouseDefense
{
    class Invader 
    {
        private readonly Path _path;
        private int _pathStep = 0;

        public int Health {get; private set;} = 2;

        public bool IsNeutralized => Health <= 0;
        public bool IsActive => !(IsNeutralized || HasScored);

        //Trues if invader has reached end of the path
        public bool HasScored{
            get{
                return _pathStep >= _path.Length;
            }
        }



        //location property
        public MapLocation Location => _path.GetLocationAt(_pathStep);


        public Invader(Path path)
        {
            _path = path;
        }


        //Invader hit decrease health
        public void Hit(int factor) => Health -= factor;



        public void Move() => _pathStep += 1;
        
    }


}