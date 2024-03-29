﻿using BettingApp.Services.Betslips.API.Application.IntegrationEvents;
using BettingApp.Services.Betslips.API.Application.IntegrationEvents.Events.SignalRHub;
using BettingApp.Services.Betslips.Domain.AggregatesModel.BetslipAggregate;
using BettingApp.Services.Betslips.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BettingApp.Services.Betslips.API.Application.DomainEventHandlers
{
    public class MatchCanceledDomainEventHandler : INotificationHandler<MatchCanceledDomainEvent>
    {
        private readonly ILogger<MatchCanceledDomainEventHandler> _logger;
        private readonly IBetslipRepository _repository;
        private readonly IBetslipsIntegrationEventService _betslipsIntegrationEventService;

        public MatchCanceledDomainEventHandler(
                                            ILogger<MatchCanceledDomainEventHandler> logger,
                                            IBetslipRepository repository,
                                            IBetslipsIntegrationEventService betslipsIntegrationEventService)
        {
            _logger = logger;
            _repository = repository;
            _betslipsIntegrationEventService = betslipsIntegrationEventService;
        }

        public async Task Handle(MatchCanceledDomainEvent matchCanceledEvent, CancellationToken cancellationToken)
        {
            var betslip = await _repository.GetByMatchIdAsync(matchCanceledEvent.MatchId);

            var selection = betslip.Selections.FirstOrDefault(s => s.Match.Id.Equals(matchCanceledEvent.MatchId));

            var selectionMatchCanceledIntegrationEvent = new BetslipSelectionMatchCanceledIntegrationEvent(betslip.GamblerId, 
                                                                                                betslip.Id, selection.Id);

            // Add a SelectionMatchCanceledIntegrationEvent to queue to be published latet
            // (receiver is the Betslips.SignalRHub service)
            await _betslipsIntegrationEventService.AddAndSaveEventAsync(selectionMatchCanceledIntegrationEvent);
        }
    }
}
