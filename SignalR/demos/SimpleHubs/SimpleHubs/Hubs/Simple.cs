using System;
using System.Collections.Generic;
using System.Linq;
using SignalR.Hubs;
using System.Threading.Tasks;

namespace SimpleHubs.Hubs
{
    #region Step 1
    public class Simple : Hub
    {
        public void Send(string message)
        {
            Clients.NewMessage(message);
        }
    }
    #endregion

    #region Step 2
    //public class Simple : Hub
    //{
    //    public void Send(string message)
    //    {
    //        Clients.NewMessage(string.Format("[{0}] {1}", GetUserName(), message));
    //    }

    //    private string GetUserName()
    //    {
    //        if (!Context.User.Identity.IsAuthenticated)
    //            return "Guest";

    //        return Context.User.Identity.Name;
    //    }
    //}
    #endregion

    #region Step 3
    //public class Simple : Hub, IConnected, IDisconnect
    //{
    //    private static Dictionary<string, string> Users = new Dictionary<string, string>();

    //    public void Send(string message)
    //    {
    //        Send(message, false);
    //    }

    //    private void Send(string message, bool system)
    //    {
    //        Clients.NewMessage(string.Format("[{0}] {1}", system ? "System" : GetUserName(), message));
    //    }

    //    private string GetUserName()
    //    {
    //        if (!Context.User.Identity.IsAuthenticated)
    //            return "Guest";

    //        return Context.User.Identity.Name;
    //    }

    //    private void EnsureUserInList()
    //    {
    //        if (!Context.User.Identity.IsAuthenticated)
    //            return;

    //        if (!Users.ContainsKey(Context.ConnectionId))
    //        {
    //            Users.Add(Context.ConnectionId, Context.User.Identity.Name);
    //            Send(string.Format("{0} has entered the room", Users[Context.ConnectionId]), true);
    //        }
    //    }

    //    public Task Connect()
    //    {
    //        return Task.Factory.StartNew(() =>
    //        {
    //            EnsureUserInList();
    //        });
    //    }

    //    public Task Reconnect(IEnumerable<string> groups)
    //    {
    //        return Task.Factory.StartNew(() =>
    //        {
    //            EnsureUserInList();
    //        });
    //    }


    //    public Task Disconnect()
    //    {
    //        return Task.Factory.StartNew(() =>
    //        {
    //            if (Users.ContainsKey(Context.ConnectionId))
    //            {
    //                Send(string.Format("{0} has left the room.", Users[Context.ConnectionId]), true);
    //                Users.Remove(Context.ConnectionId);
    //            }
    //        });
    //    }
    //}
    #endregion
}