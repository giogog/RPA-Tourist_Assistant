using System;
using UiPath.Mail.Activities.Api;

namespace Domain.Helpers
{
    public class EmailOptions:GetImapMailOptions
    {
        public DateTime StartDate {get;set;}
        public DateTime EndDate {get;set;}
    }
}