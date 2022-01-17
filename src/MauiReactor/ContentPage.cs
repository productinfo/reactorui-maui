using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using MauiReactor.Animations;
//using MauiReactor.Shapes;
using MauiReactor.Internals;

namespace MauiReactor
{
    public partial interface IContentPage : ITemplatedPage
    {


    }
    public partial class ContentPage<T> : TemplatedPage<T>, IContentPage where T : Microsoft.Maui.Controls.ContentPage, new()
    {
        public ContentPage()
        {

        }

        public ContentPage(Action<T?> componentRefAction)
            : base(componentRefAction)
        {

        }



        protected override void OnUpdate()
        {
            OnBeginUpdate();

            base.OnUpdate();

            OnEndUpdate();
        }

        partial void OnBeginUpdate();
        partial void OnEndUpdate();


    }

    public partial class ContentPage : ContentPage<Microsoft.Maui.Controls.ContentPage>
    {
        public ContentPage()
        {

        }

        public ContentPage(Action<Microsoft.Maui.Controls.ContentPage?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class ContentPageExtensions
    {

    }
}