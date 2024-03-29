﻿using BettingApp.BuildingBlocks.EventBus.Events;
using BettingApp.Services.Betting.API.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingApp.Services.Betting.API.Application.IntegrationEvents.Events
{
    public class UserCheckedOutIntegrationEvent : IntegrationEvent
    {
        public Guid RequestId { get; }

        public BetslipDTO BetslipDTO { get; }

        public UserCheckedOutIntegrationEvent(Guid requestId, BetslipDTO betslipDto)
        {
            RequestId = requestId;
            BetslipDTO = betslipDto;
        }
    }
}
