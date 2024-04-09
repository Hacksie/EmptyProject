namespace HackedDesign
{
    public class MainMenuState : IState
    {
        private UI.AbstractPresenter mainMenuPanel;
        public MainMenuState(UI.AbstractPresenter mainMenuPanel)
        {
            this.mainMenuPanel = mainMenuPanel;
        }

        public bool Playing => false;

        public void Begin()
        {
            this.mainMenuPanel.Show();
            this.mainMenuPanel.Repaint();
        }

        public void End()
        {
            this.mainMenuPanel.Hide();
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