using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Threading.Tasks;
using Tourist_Assistant.Service;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace Tourist_Assistant.WorkFlows
{

    public abstract class WorkflowBase : CodedWorkflow
    {
        protected ClickOptions _clickOptions = new ClickOptions{ InteractionMode = NChildInteractionMode.Simulate };
        protected TypeIntoOptions _typeIntoOptions = new TypeIntoOptions{ InteractionMode = NChildInteractionMode.Simulate };
        protected TargetAppOptions _targetAppOptions = new TargetAppOptions{ InteractionMode = NInteractionMode.HardwareEvents ,WindowResize = NWindowResize.None,OpenMode = NAppOpenMode.IfNotOpen,Timeout = 30 };
        protected CheckStateOptions _checkStateOptions = new CheckStateOptions{ Mode = NCheckStateMode.WaitAppear,CheckVisibility=true };
        
        protected void ChangeClickOptions(Action<ClickOptions> clickOptions){
            clickOptions(_clickOptions);
        }
        
        protected void ChangeTypeIntoOptions(Action<TypeIntoOptions> typeIntoOptions){
            typeIntoOptions(_typeIntoOptions);
        }
        
        protected void ChangeTargetAppOptions(Action<TargetAppOptions> targetAppOptions){
            targetAppOptions(_targetAppOptions);
        }
        
        
        public async Task<Dictionary<string, List<string>>> ExecuteMailParse(MailMessage message)
        {
            Log("Parse Email");
            return EmailService.ParseEmailMessage(message);
        } 
    }
}