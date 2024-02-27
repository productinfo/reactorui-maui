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
public partial interface ITabBar : IShellItem
{
}

public partial class TabBar<T> : ShellItem<T>, ITabBar where T : Microsoft.Maui.Controls.TabBar, new()
{
    public TabBar()
    {
        TabBarStyles.Default?.Invoke(this);
    }

    public TabBar(Action<T?> componentRefAction) : base(componentRefAction)
    {
        TabBarStyles.Default?.Invoke(this);
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
        if (Theme != null && TabBarStyles.Themes.TryGetValue(Theme, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public partial class TabBar : TabBar<Microsoft.Maui.Controls.TabBar>
{
    public TabBar()
    {
    }

    public TabBar(Action<Microsoft.Maui.Controls.TabBar?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class TabBarExtensions
{
}

public static partial class TabBarStyles
{
    public static Action<ITabBar>? Default { get; set; }
    public static Dictionary<string, Action<ITabBar>> Themes { get; } = [];
}