namespace TreehouseDefense
{
    class Level
    {
        private readonly Invader[] _invaders;
        public Tower[] towers {get; set;}

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }


        //return true if win and false for loss
        public bool Play()
        {
            //Run until all invaders are gone 
            int remainingInvaders = _invaders.Length;

            while(remainingInvaders>0)
            {
                //each tower fires on all the invaders
                foreach(Tower tower in towers)
                {
                    tower.FireOnInvaders(_invaders);
                }

                //count and move the invaders that are still active 
                remainingInvaders = 0;
                foreach(Invader invader in _invaders)
                {
                    //invader moves if it is active
                    if(invader.IsActive)
                    {
                        invader.Move();

                        if(invader.HasScored)
                        {
                            //game ends invader killed tower
                            return false;
                        }
                        remainingInvaders ++;
                    }
                }
            }
            //player wins all invaders eliminated
            return true;

        }


    }
}