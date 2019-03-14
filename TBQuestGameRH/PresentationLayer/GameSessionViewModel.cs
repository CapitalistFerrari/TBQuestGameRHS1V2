using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGameRH.Models;
using TBQuestGameRH.DataLayer;
using TBQuestGameRH.BusinessLayer;

namespace TBQuestGameRH.PresentationLayer
{
    public partial class GameSessionViewModel 
    {
        #region FIELDS 

        private DateTime _gameStartTime;
        private Player _player;
        private List<string> _messages;
        /*private DateTime _datetime;*/
        #endregion

        #region PROPERTIES

        public Player Player
        {
            get { return _player;  }
            set { _player = value; }
        }

        public string MessageDisplay
        {
            get { return FormatMessagesForViewer(); }
        }
        

        

        #endregion

        #region CONSTRUCTORS

        public GameSessionViewModel()
        {

        }

        public GameSessionViewModel(Player player, List<string> initialMessages)
        {
            _player = player;
            _messages = initialMessages;
            
        }

        #endregion

        #region METHODS
        private string FormatMessagesForViewer()
        {
            List<string> lifoMessages = new List<string>();

            for (int index = 0; index < _messages.Count; index++)
            {
                lifoMessages.Add(_messages[index]);
            }

            lifoMessages.Reverse();

            return string.Join("\n\n", lifoMessages);
        }

        public TimeSpan GameTime()
        {
            return DateTime.Now - _gameStartTime;
        }

        #endregion
    }
}
