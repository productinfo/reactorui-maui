// <auto-generated />
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using MauiReactor.Animations;
using MauiReactor.Shapes;
using MauiReactor.Internals;

#nullable enable
namespace MauiReactor
{
    public partial interface IFlyoutBase : IElement
    {
    }

    public abstract partial class FlyoutBase<T> : Element<T>, IFlyoutBase where T : Microsoft.Maui.Controls.FlyoutBase, new()
    {
        protected FlyoutBase()
        {
        }

        protected FlyoutBase(Action<T?> componentRefAction) : base(componentRefAction)
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
        partial void OnBeginAnimate();
        partial void OnEndAnimate();
    }

    public static partial class FlyoutBaseExtensions
    {
    }
}