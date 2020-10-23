using FluentValidation;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Validator
{
    public class InputValidator : AbstractValidator<Podcast>
    {
        public InputValidator()
        {
            RuleFor(pod => pod.Namn).NotEmpty(); 
        }
    }

}
