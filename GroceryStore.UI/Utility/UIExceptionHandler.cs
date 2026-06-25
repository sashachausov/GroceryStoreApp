using GroceryStore.Application.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.UI.Utility
{
    public static class UIExceptionHandler
    {
        public static void HandleException(Exception exception)
        {
            string errorMessage;

            switch (exception)
            {
                case ValidationException:
                    errorMessage = exception.Message;
                    break;
                case NotFoundException: 
                    errorMessage = exception.Message;
                    break;
                default:
                    errorMessage = "Unexpected error occured. Please try again.";
                    break;
            }

            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
