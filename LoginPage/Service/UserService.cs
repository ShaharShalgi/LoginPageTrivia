﻿using LoginPage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginPage.Service;


namespace LoginPage.Service
{
    
    public class UserService
    {
        
     
        public List<Player> playersList { get; set; }
        public UserService()
        {
            this.playersList = new List<Player>();
            FillList();
        }
        private void FillList()
        {
            RankService rankService = new RankService();
            playersList.Add(new Player() { PlayerName = "Gal", PlayerPass = "Gal123", Darga = rankService.Dargas[2], PlayerMail="galkluger@gmail.com", PlayerId=1, PLayerPoints=99999 }) ;
            playersList.Add(new Player() { PlayerName = "Tami", PlayerPass = "Tami123", Darga = rankService.Dargas[1], PlayerMail = "TamiFre@gmail.com", PlayerId = 2, PLayerPoints = 30 });
            playersList.Add(new Player() { PlayerName = "ShaharOz", PlayerPass = "ShaharOz123", Darga = rankService.Dargas[1], PlayerMail = "TheBigOz@gmail.com", PlayerId = 3,  PLayerPoints =50 });
            playersList.Add(new Player() { PlayerName = "ShaharS", PlayerPass = "ShaharS123", Darga = rankService.Dargas[0], PlayerMail = "SHMan@gmail.com", PlayerId = 4, PLayerPoints = 0 });
        }

        public Player LoginSuc(Player ps)
        {
            Player player = playersList.FirstOrDefault(x => ps.PlayerName == x.PlayerName && ps.PlayerPass==x.PlayerPass);
            if (player != null)
                return player;
            else return null;
        }

        public List<Player> ShowByDesc()
        {
            return playersList.OrderByDescending(x=> x.PLayerPoints).ToList();
        }

        
        
        

    }
}
