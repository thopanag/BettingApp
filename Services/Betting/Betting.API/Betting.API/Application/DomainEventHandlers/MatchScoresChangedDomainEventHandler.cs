﻿using BettingApp.Services.Betting.API.Application.IntegrationEvents;
using BettingApp.Services.Betting.API.Application.IntegrationEvents.Events.SignalRHub;
using BettingApp.Services.Betting.Domain.AggregatesModel.BetAggregate;
using BettingApp.Services.Betting.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BettingApp.Services.Betting.API.Application.DomainEventHandlers
{
    public class MatchScoresChangedDomainEventHandler : INotificationHandler<MatchScoresChangedDomainEvent>
    {
        private readonly ILogger<MatchScoresChangedDomainEventHandler> _logger;
        private readonly IBetRepository _repository;
        private readonly IBettingIntegrationEventService _bettingIntgrationEventService;

        public MatchScoresChangedDomainEventHandler(ILogger<MatchScoresChangedDomainEventHandler> logger,
                                             IBetRepository repository,
                                             IBettingIntegrationEventService bettingIntegrationEventService)
        {
            _logger = logger;
            _repository = repository;
            _bettingIntgrationEventService = bettingIntegrationEventService;
        }

        public async Task Handle(MatchScoresChangedDomainEvent matchScoresChangedEvent, CancellationToken cancellationToken)
        {
            var bet = await _repository.GetByMatchIdAsync(matchScoresChangedEvent.MatchId);

            var selection = bet.Selections.FirstOrDefault(s => s.Match.Id.Equals(matchScoresChangedEvent.MatchId));

            var betSelectionMatchScoresChangedIntegrationEvent =
                                            new BetSelectionMatchScoresChangedIntegrationEvent(bet.GamblerId, bet.Id, 
                                                                        selection.Id, selection.Match.HomeClubScore,
                                                                        selection.Match.AwayClubScore);

            // Add a BetSelectionMatchScoresChangedIntegrationEvent to queue to be published latet
            // (receiver is the Betting.SignalRHub service)
            await _bettingIntgrationEventService.AddAndSaveEventAsync(betSelectionMatchScoresChangedIntegrationEvent);
        }
    }
}
