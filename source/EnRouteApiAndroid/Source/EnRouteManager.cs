﻿using System;
using Android.Content;
using Glympse.Toolbox;
using Glympse.EnRoute;

namespace Glympse.EnRoute.Android
{
    public class EnRouteManager : GEnRouteManager
    {
        private com.glympse.enroute.android.api.GEnRouteManager _raw;

        private CommonSource _source;

        public EnRouteManager(com.glympse.enroute.android.api.GEnRouteManager raw)
        {
            _raw = raw;
            _source = new CommonSource(_raw);
        }

        /**
         * GEnRouteManager section
         */ 

        public bool login(string username, string password)
        {
            return _raw.login(username, password);
        }

        public bool login(string token, long expiresIn)
        {
            return _raw.login(token, expiresIn);
        }

        public void logout(int reason)
        {
            _raw.logout(reason);
        }

        public bool start()
        {
            return _raw.start();
        }

        public void stop()
        {
            _raw.stop();
        }           
            
        public bool isStarted()
        {
            return _raw.isStarted();
        }

        public void setActive(bool active)
        {
            _raw.setActive(active);
        }

        public bool isActive()
        {
            return _raw.isActive();
        }

        public void refresh()
        {
            _raw.refresh();
        }

        public GOrganization getOrganization()
        {
            return (GOrganization)ClassBinder.bind(_raw.getOrganization());
        }

        public GAgent getLoggedInAgent()
        {
            return (GAgent)ClassBinder.bind(_raw.getLoggedInAgent());
        }

        public string getEnRouteToken()
        {
            return _raw.getEnRouteToken();
        }

        public GTaskManager getTaskManager()
        {
            return (GTaskManager)ClassBinder.bind(_raw.getTaskManager());
        }

        /**
         * GSource section
         */

        public bool addListener(GListener listener)
        {
            return _source.addListener(listener);

        }            

        public bool removeListener(GListener listener)
        {
            return _source.removeListener(listener);
        }

        /**
         * GCommon section
         */

        public object raw()
        {
            return _raw;
        }
    }
}

