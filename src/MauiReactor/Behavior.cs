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
namespace MauiReactor;
public partial interface IBehavior : IVisualNode
{
}

public abstract partial class Behavior<T> : VisualNode<T>, IBehavior where T : Microsoft.Maui.Controls.Behavior, new()
{
    protected Behavior()
    {
        BehaviorStyles.Default?.Invoke(this);
    }

    protected Behavior(Action<T?> componentRefAction) : base(componentRefAction)
    {
        BehaviorStyles.Default?.Invoke(this);
    }

    internal override void Reset()
    {
        base.Reset();
        OnReset();
    }

    partial void OnReset();
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
    protected override void OnThemeChanged()
    {
        if (Theme != null && BehaviorStyles.Themes.TryGetValue(Theme, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public static partial class BehaviorExtensions
{
}

public static partial class BehaviorStyles
{
    public static Action<IBehavior>? Default { get; set; }
    public static Dictionary<string, Action<IBehavior>> Themes { get; } = [];
}