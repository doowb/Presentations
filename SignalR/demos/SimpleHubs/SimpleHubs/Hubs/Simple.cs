using System;
using System.Collections.Generic;
using System.Linq;
using SignalR.Hubs;
using System.Threading.Tasks;

namespace SimpleHubs.Hubs
{
    public class Simple : Hub //, IConnected
    {
        private static List<string> Users = new List<string>();

        public void Send(string message)
        {
            Clients.NewMessage(message);
            //Clients.NewMessage(string.Format("[{0}] {1}", GetUserName(), message));
        }

        //private string GetUserName()
        //{
        //    if (!Context.User.Identity.IsAuthenticated)
        //        return "Guest";

        //    return Context.User.Identity.Name;
        //}

        //private void EnsureUserInList()
        //{
        //    if (!Context.User.Identity.IsAuthenticated)
        //        return;

        //    if (!Users.Contains(Context.User.Identity.Name))
        //        Users.Add(Context.User.Identity.Name);
        //}

        //public Task Connect()
        //{
        //    EnsureUserInList();
        //    return null;
        //}

        //public Task Reconnect(IEnumerable<string> groups)
        //{
        //    EnsureUserInList();
        //    return null;
        //}

    }
}