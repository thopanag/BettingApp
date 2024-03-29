﻿using BettingApp.BuildingBlocks.EventBus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingApp.Services.Sportsbook.SignalrHub.IntegrationEvents.Events
{
    public class SportsbookMatchCurrentMinuteChangedIntegrationEvent : IntegrationEvent
    {
        public string MatchId { get; }

        public string NewCurrentMinute { get; }

        public SportsbookMatchCurrentMinuteChangedIntegrationEvent(string matchId, string newCurrentMinute)
        {
            MatchId = matchId;
            NewCurrentMinute = newCurrentMinute;
        }
    }
}
