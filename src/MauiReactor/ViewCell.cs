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
public partial interface IViewCell : ICell
{
}

public partial class ViewCell<T> : Cell<T>, IViewCell where T : Microsoft.Maui.Controls.ViewCell, new()
{
    public ViewCell()
    {
        ViewCellStyles.Default?.Invoke(this);
    }

    public ViewCell(Action<T?> componentRefAction) : base(componentRefAction)
    {
        ViewCellStyles.Default?.Invoke(this);
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
        if (Theme != null && ViewCellStyles.Themes.TryGetValue(Theme, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public partial class ViewCell : ViewCell<Microsoft.Maui.Controls.ViewCell>
{
    public ViewCell()
    {
    }

    public ViewCell(Action<Microsoft.Maui.Controls.ViewCell?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class ViewCellExtensions
{
}

public static partial class ViewCellStyles
{
    public static Action<IViewCell>? Default { get; set; }
    public static Dictionary<string, Action<IViewCell>> Themes { get; } = [];
}