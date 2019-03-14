using TBQuestGameRH.Models;
using TBQuestGameRH.DataLayer;
using TBQuestGameRH.PresentationLayer;

namespace TBQuestGameRH.BusinessLayer
{
    public class GameBusiness
    {
        GameSessionViewModel _gameSessionViewModel;
        bool _newPlayer = false; 
        Player _player = new Player();
        

        public GameBusiness()
        {
            SetupPlayer();
            InstantiateAndShowView();
        }

        /// <summary>
        /// setup new or existing player
        /// </summary>
        private void SetupPlayer()
        {
            if (_newPlayer)
            {
                

                //
                // setup up game based player properties
                //
                _player.CurrentLevel = 0;
                _player.HP = 100;
                _player.CurrentStatus = 0;
            }
            else
            {
                _player = GameData.PlayerData();
            }
        }

        /// <summary>
        /// create view model with data set
        /// </summary>
        private void InstantiateAndShowView()
        {
            //
            // instantiate the view model and initialize the data set
            //
            _gameSessionViewModel = new GameSessionViewModel(
            
                _player,
                GameData.InitialMessages()
                
                );
        
            GameSessionView gameSessionView = new GameSessionView(_gameSessionViewModel);

            gameSessionView.DataContext = _gameSessionViewModel;

            gameSessionView.Show();

            //
            // dialog window is initially hidden to mitigate issue with
            // main window closing after dialog window closes
            //
            // commented out because the player setup window is disabled
            //
            /*layerSetupWindow.Close();*/
        }
    }
}
