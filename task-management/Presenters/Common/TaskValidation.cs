using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace task_management.Presenters.Common
{
    public class TaskValidation
    {

        // methods
        public void Validate(object model)
        {
            String errorMessage = "";
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(model);

            bool isValid = Validator.TryValidateObject(model, context, results, true);
        
            if (!isValid)
            {
                foreach (var result in results)
                {
                      errorMessage += "- " + result.ErrorMessage + "\n";
                }

                throw new Exception(errorMessage);
            }
        }
    }
}
