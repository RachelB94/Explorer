using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;
using Explorer.Model;

namespace Explorer
{
    class ListView : BaseAdapter
    {

        Activity activity;
        List<Account> account;
        LayoutInflater inflater;

        public override int Count
        {
            get
            {
                return account.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            throw new NotImplementedException();
        }

        //public override View GetView(int position, View convertView, ViewGroup parent)
        //{
        //  inflater = (LayoutInflater)activity.BaseContext.GetSystemService(Context.LayoutInflaterService);
        // View itemView = inflater.Inflate(Resource.Layout.list_item, null);
        //TextView txtUser = itemView.FindViewById<TextView>(Resource.Id.list_item);
        //TextView txtEmail = itemView.FindViewById<TextView>(Resource.Id.List_email);
        //}
    }
}