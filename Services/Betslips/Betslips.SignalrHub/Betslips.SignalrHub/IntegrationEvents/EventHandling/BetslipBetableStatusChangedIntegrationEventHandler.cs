﻿using BettingApp.BuildingBlocks.EventBus.Abstractions;
using BettingApp.Services.Betslips.SignalrHub.IntegrationEvents.Events;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingApp.Services.Betslips.SignalrHub.IntegrationEvents.EventHandling
{
    public class BetslipBetableStatusChangedIntegrationEventHandler
        : IIntegrationEventHandler<BetslipBetableStatusChangedIntegrationEvent>
    {
        private readonly ILogger<BetslipBetableStatusChangedIntegrationEventHandler> _logger;
        private readonly IHubContext<BetslipsHub> _hubContext;

        public BetslipBetableStatusChangedIntegrationEventHandler(
                                                    ILogger<BetslipBetableStatusChangedIntegrationEventHandler> logger,
                                                    IHubContext<BetslipsHub> hubContext)
        {
            _logger = logger;
            _hubContext = hubContext;
        }

        public async Task Handle(BetslipBetableStatusChangedIntegrationEvent @event)
        {
            _logger.LogInformation("----- Handling integration event: {IntegrationEventId} at {AppName} - ({@IntegrationEvent})", @event.Id, Program.AppName, @event);

            await _hubContext.Clients
                            .Group(@event.GamblerId)
                            .SendAsync("BetslipBetableStatusChanged", new
                            {
                                BetslipId = @event.BetslipId,
                                IsBetable = @event.NewIsBetable
                            });
        }
    }
}
