﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MPExtended.Services.UserSessionService.Interfaces
{
    [ServiceContract(Namespace = "http://mpextended.github.com")]
    public interface IUserSessionService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        WebResult TestConnection();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        WebUserServiceDescription GetServiceDescription();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        WebResult IsMediaPortalRunning();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        WebResult StartMediaPortal();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        WebResult StartMediaPortalBlocking();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        WebResult SetMediaPortalForeground();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        WebResult SetPowerMode(WebPowerMode powerMode);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        WebResult CloseMediaPortal();
    }
}