using Fashionista.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Service
{
   public interface IMailService
    {
        public bool SendEmailAsync(MailRequest mailRequest);

    }
}
