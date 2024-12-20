﻿using MediatR;
using smERP.Application.Features.Branches.Queries.Models;
using smERP.SharedKernel.Responses;

namespace smERP.Application.Features.Categories.Queries.Models;

public record GetParentCategoriesQuery() : IRequest<IResult<IEnumerable<SelectOption>>>;