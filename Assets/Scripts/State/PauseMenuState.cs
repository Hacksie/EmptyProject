namespace HackedDesign
{
    public class PauseMenuState : IState
    {
        private UI.AbstractPresenter pauseMenuPanel;
        public PauseMenuState(UI.AbstractPresenter pauseMenuPanel)
        {
            this.pauseMenuPanel = pauseMenuPanel;
        }

        public bool Playing => false;

        public void Begin()
        {
            this.pauseMenuPanel.Show();
            this.pauseMenuPanel.Repaint();
        }

        public void End()
        {
            this.pauseMenuPanel.Hide();
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