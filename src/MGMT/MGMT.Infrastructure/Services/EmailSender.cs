﻿using MGMT.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGMT.Infrastructure.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            // TODO: Wire this up to actual email sending logic via SendGrid, local SMTP, etc.
            return Task.CompletedTask;
        }
    }
}