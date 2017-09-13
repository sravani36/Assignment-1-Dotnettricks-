using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_1.CustomAttributes
{
    public class ValidateCheckBoxAttribute:ValidationAttribute, IClientValidatable
    {
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            return new ModelClientValidationRule[]
            {
                new ModelClientValidationRule{
                    ValidationType="checkbox",
                    ErrorMessage=this.ErrorMessage
                }
            };
        }
    }
}