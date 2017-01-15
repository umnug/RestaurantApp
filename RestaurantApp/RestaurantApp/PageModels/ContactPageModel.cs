using FreshMvvm;
using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RestaurantApp.PageModels
{
    class ContactPageModel : FreshBasePageModel
    {
        public Command CallCommand { get { return new Command(Call); } }

        private void Call(object obj)
        {
            if (CrossMessaging.Current.PhoneDialer.CanMakePhoneCall)
                CrossMessaging.Current.PhoneDialer.MakePhoneCall("555-555-5555");
        }
    }
}
