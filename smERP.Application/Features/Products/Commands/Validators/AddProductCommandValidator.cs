﻿using FluentValidation;
using smERP.Application.Features.Products.Commands.Models;
using smERP.SharedKernel.Localizations.Extensions;
using smERP.SharedKernel.Localizations.Resources;

namespace smERP.Application.Features.Products.Commands.Validators;

public class AddProductCommandValidator : AbstractValidator<AddProductCommandModel>
{
    public AddProductCommandValidator()
    {
        RuleFor(c => c.EnglishName)
            .NotEmpty()
            .WithMessage(SharedResourcesKeys.Required_FieldName.Localize(SharedResourcesKeys.NameEn.Localize()));

        RuleFor(c => c.ArabicName)
            .NotEmpty()
            .WithMessage(SharedResourcesKeys.Required_FieldName.Localize(SharedResourcesKeys.NameAr.Localize()));

        RuleFor(c => c.ModelNumber)
            .NotEmpty()
            .WithMessage(SharedResourcesKeys.Required_FieldName.Localize(SharedResourcesKeys.ModelNumber.Localize()));

        RuleFor(command => command.BrandId)
            .GreaterThan(0)
            .WithMessage(SharedResourcesKeys.Required_FieldName.Localize(SharedResourcesKeys.Brand.Localize()));

        RuleFor(command => command.CategoryId)
            .GreaterThan(0)
            .WithMessage(SharedResourcesKeys.Required_FieldName.Localize(SharedResourcesKeys.Category.Localize()));
    }
}