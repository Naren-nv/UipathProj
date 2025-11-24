using GithubProj_trail.ObjectRepository;
using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

namespace GithubProj_trail
{
    public class Workflow : CodedWorkflow
    {
        [Workflow]
        public void Execute()
        {
        int x = 5, y = 6;
        int sum = x + y;
        Log(sum.ToString);
    }


    }
}