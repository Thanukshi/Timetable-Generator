using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTimeApp.Helpers
{
    class FiresharpConnection
    {
        public static void fireConnection()
        {
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "U858DiOG8S2ueYcHd44m4sbY3ctr9XJqmLt2yRRY",
                BasePath = "https://newtimeapp-9c458.firebaseio.com/"
            };
        }
    }
}
