using Fashionista.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fashionista.core.Repository
{
   public interface IMailRepository
    {
        public bool SendEmailAsync(MailRequest mailRequest);

    }
}
