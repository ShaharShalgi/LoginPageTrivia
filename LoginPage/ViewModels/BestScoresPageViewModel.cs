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
        private List<Player> fullPlayers;
        UserService userService;
        public ObservableCollection<Player> Players { get; set; }
        public ICommand LoadPlayersCommand { get; private set; }
        public BestScoresPageViewModel(UserService userService)
        {
            fullPlayers = new List<Player>();
            this.userService = userService;
            Players = new ObservableCollection<Player>();

            LoadPlayersCommand = new Command(async () => await LoadPlayers());

        }
        private async Task LoadPlayers()
        {
            fullPlayers = userService.ShowByDesc();
            Players.Clear();
            foreach (var Player in fullPlayers)
                Players.Add(Player);
        }


    }
}
