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
    public partial interface IVerticalStackLayout : IStackBase
    {


    }
    public partial class VerticalStackLayout<T> : StackBase<T>, IVerticalStackLayout where T : Microsoft.Maui.Controls.VerticalStackLayout, new()
    {
        public VerticalStackLayout()
        {

        }

        public VerticalStackLayout(Action<T?> componentRefAction)
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

    public partial class VerticalStackLayout : VerticalStackLayout<Microsoft.Maui.Controls.VerticalStackLayout>
    {
        public VerticalStackLayout()
        {

        }

        public VerticalStackLayout(Action<Microsoft.Maui.Controls.VerticalStackLayout?> componentRefAction)
            : base(componentRefAction)
        {

        }
    }

    public static partial class VerticalStackLayoutExtensions
    {

    }
}