﻿using Grpc.Core;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using ON.Authentication;
using ON.Authorization.Stripe.Web.Helper;
using ON.Fragments.Authorization;
using ON.Fragments.Authorization.Payment.Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stripe;

namespace ON.Authorization.Stripe.Web.Services
{
    public class AccountService
    {
        private readonly ILogger<AccountService> logger;
        private readonly ServiceNameHelper nameHelper;

        public readonly string AccountId;
        public readonly ProductRecord[] Products;

        public AccountService(ServiceNameHelper nameHelper, ILogger<AccountService> logger)
        {
            this.logger = logger;
            this.nameHelper = nameHelper;

            var res = GetDetails();
            AccountId = res.ClientId;
            Products = res.Products.Records.ToArray();
        }

        private GetAccountDetailsResponse GetDetails()
        {
            if (nameHelper.PaymentsServiceChannel == null)
                return null;

            var client = new PaymentsInterface.PaymentsInterfaceClient(nameHelper.PaymentsServiceChannel);
            var reply = client.GetAccountDetails(new GetAccountDetailsRequest());
            return reply;
        }
    }
}
