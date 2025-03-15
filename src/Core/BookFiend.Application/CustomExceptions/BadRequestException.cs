﻿using FluentValidation.Results;

namespace BookFiend.Application.CustomExceptions
{
        public class BadRequestException : Exception
        {
            public BadRequestException(string message) : base(message)
            {
                
            }

        public BadRequestException(string message, ValidationResult validationResult) : base(message)
        {
            ValidationErrors = validationResult.ToDictionary();
        }

        public IDictionary<string, string[]> ValidationErrors { get; set; }
    }
}
