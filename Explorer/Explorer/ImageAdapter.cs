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
using Java.IO;
using Android.Graphics;

namespace Explorer
{
    class ImageAdapter: BaseAdapter
    {
        Context context;

        public ImageAdapter(Context c)
        {
            context = c;
        }

        public override int Count
        {
            get
            {
                
                    return picsId.Length;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ImageView i = new ImageView(context);
            i.SetImageResource(picsId[position]);
            i.LayoutParameters = new Gallery.LayoutParams(400, 400);
            i.SetScaleType(ImageView.ScaleType.FitXy);
            return i;
        }

      

        int[] picsId =
        {
           Resource.Drawable.ant,
           Resource.Drawable.aut
            
        };



    }
    }
