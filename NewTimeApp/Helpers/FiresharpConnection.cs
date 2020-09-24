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
       
        public FiresharpConnection()
        {

        }

        public static void fireConnection()
        {
            IFirebaseConfig config = new FirebaseConfig()
            {
                AuthSecret = "Onj8rh37hQONO2YXC0YncZnUy6kbXHBtxK9uCoTx",
                BasePath = "https://timetableapp-12161.firebaseio.com/"
            };
        }
    }
}
