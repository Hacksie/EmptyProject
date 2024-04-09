namespace HackedDesign
{
    public class LoadingState : IState
    {
        public LoadingState()
        {

        }

        public bool Playing => false;

        public void Begin()
        {
            Game.Instance.SetPlaying();
        }

        public void End()
        {
            
        }

        public void Update()
        {
            
        }        

        public void FixedUpdate()
        {
            
        }

        public void Menu()
        {
            
        }

        public void Select()
        {
            
        }


    }

}