﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LawnBattle
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "EventListing",
                url: "events/list/{id}",
                defaults: new { controller = "events", action = "index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "EventsTournaments",
                url: "events/{eventSlug}/tournaments/{action}",
                defaults: new { controller = "tournaments", action = "index", eventSlug = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "EventsPlayers",
                url: "events/{eventSlug}/players/{action}",
                defaults: new { controller = "players", action = "index", eventSlug = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "EventSlug",
                url: "events/{id}",
                defaults: new { controller = "events", action = "eventBySlug", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}