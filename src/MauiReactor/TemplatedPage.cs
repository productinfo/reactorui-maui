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
public partial interface ITemplatedPage : IPage
{
}

public partial class TemplatedPage<T> : Page<T>, ITemplatedPage where T : Microsoft.Maui.Controls.TemplatedPage, new()
{
    public TemplatedPage()
    {
        TemplatedPageStyles.Default?.Invoke(this);
    }

    public TemplatedPage(Action<T?> componentRefAction) : base(componentRefAction)
    {
        TemplatedPageStyles.Default?.Invoke(this);
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
        if (Theme != null && TemplatedPageStyles.Themes.TryGetValue(Theme, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public partial class TemplatedPage : TemplatedPage<Microsoft.Maui.Controls.TemplatedPage>
{
    public TemplatedPage()
    {
    }

    public TemplatedPage(Action<Microsoft.Maui.Controls.TemplatedPage?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class TemplatedPageExtensions
{
}

public static partial class TemplatedPageStyles
{
    public static Action<ITemplatedPage>? Default { get; set; }
    public static Dictionary<string, Action<ITemplatedPage>> Themes { get; } = [];
}