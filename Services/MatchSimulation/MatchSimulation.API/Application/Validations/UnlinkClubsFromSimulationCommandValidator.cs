﻿using BettingApp.Services.MatchSimulation.API.Application.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BettingApp.Services.MatchSimulation.API.Application.Validations
{
    public class UnlinkClubsFromSimulationCommandValidator : AbstractValidator<UnlinkClubsFromSimulationCommand>
    {
        public UnlinkClubsFromSimulationCommandValidator()
        {
            RuleFor(command => command.SimulationId).NotEmpty();
        }
    }
}
