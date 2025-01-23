﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Routing;
using WebApiDemo.Constraints;

namespace WebApiDemo
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Web API configuration and services
			var constraintResolver = new DefaultInlineConstraintResolver();
			constraintResolver.ConstraintMap.Add("lastletter",typeof(LastLetter));


			// Web API routes
			config.MapHttpAttributeRoutes(constraintResolver);

			config.Routes.MapHttpRoute(
					name: "DefaultApi",
					routeTemplate: "api/{controller}/{id}",
					defaults: new { id = RouteParameter.Optional }
			);
		}
	}
}
