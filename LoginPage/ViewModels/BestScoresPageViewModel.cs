using LoginPage.Models;
using LoginPage.Service;
using MonkeysMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LoginPage.ViewModels
{
    public class BestScoresPageViewModel:ViewModel
    {
        
        
        public ObservableCollection<Player> players { get; set; }
        public ICommand LoadPlayersCommand { get; private set; }
        public BestScoresPageViewModel()
        {
            
            players = new ObservableCollection<Player>();

            LoadPlayersCommand = new Command(async () => await
             LoadPlayers());

        }
        private async Task LoadPlayers()
        {
            UserService userService = new UserService();
            players.Clear();
            foreach (var Player in userService.playersList)
                players.Add(Player);



        }
    }
}
