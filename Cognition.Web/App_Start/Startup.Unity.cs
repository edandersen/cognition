﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cognition.Shared.Configuration;
using Cognition.Support.Configuration;
using Cognition.Web.Unity;
using Microsoft.Practices.Unity;
using Owin;

namespace Cognition.Web
{
    public partial class Startup
    {
        public static IUnityContainer Container { get; set; }

        public void ConfigureUnity(IAppBuilder app)
        {
            Container = new UnityContainer();

            // set MVC4/5 resolver
            DependencyResolver.SetResolver(new UnityDependencyResolver(Container));

            Container.RegisterType<IAppSettingProvider, AppSettingProvider>();
        }
    }
}