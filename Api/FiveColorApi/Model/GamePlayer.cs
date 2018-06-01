﻿using Newtonsoft.Json;

namespace FiveColorApi.Model
{
    public class GamePlayer: PlayerDetails
    {
        #region Properties
        [JsonProperty(PropertyName = "Ready")]
        public bool Ready { get; set; }
        [JsonProperty(PropertyName = "Deck")]
        public Deck Deck { get; set; }
        [JsonProperty(PropertyName = "IsReady")]
        public bool IsReady { get; set; }
        #endregion

        #region Constructors
        public GamePlayer()
        {
            Deck = new Deck();
        }
        public GamePlayer(PlayerDetails playerDetails):this()
        {
            if (playerDetails != null)
            {
                DisplayName = playerDetails.DisplayName;
                FirstName = playerDetails.DisplayName;
                Id = playerDetails.Id;
                LastName = playerDetails.LastName;
            }
        }
        #endregion
    }
}