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
public partial interface IFlyoutItem : IShellItem
{
}

public partial class FlyoutItem<T> : ShellItem<T>, IFlyoutItem where T : Microsoft.Maui.Controls.FlyoutItem, new()
{
    public FlyoutItem()
    {
        FlyoutItemStyles.Default?.Invoke(this);
    }

    public FlyoutItem(Action<T?> componentRefAction) : base(componentRefAction)
    {
        FlyoutItemStyles.Default?.Invoke(this);
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
        if (Theme != null && FlyoutItemStyles.Themes.TryGetValue(Theme, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public partial class FlyoutItem : FlyoutItem<Microsoft.Maui.Controls.FlyoutItem>
{
    public FlyoutItem()
    {
    }

    public FlyoutItem(Action<Microsoft.Maui.Controls.FlyoutItem?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class FlyoutItemExtensions
{
}

public static partial class FlyoutItemStyles
{
    public static Action<IFlyoutItem>? Default { get; set; }
    public static Dictionary<string, Action<IFlyoutItem>> Themes { get; } = [];
}