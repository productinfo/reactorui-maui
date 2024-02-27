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
public partial interface ICollectionView : IReorderableItemsView
{
}

public partial class CollectionView<T> : ReorderableItemsView<T>, ICollectionView where T : Microsoft.Maui.Controls.CollectionView, new()
{
    public CollectionView()
    {
        CollectionViewStyles.Default?.Invoke(this);
    }

    public CollectionView(Action<T?> componentRefAction) : base(componentRefAction)
    {
        CollectionViewStyles.Default?.Invoke(this);
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
        if (Theme != null && CollectionViewStyles.Themes.TryGetValue(Theme, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public partial class CollectionView : CollectionView<Microsoft.Maui.Controls.CollectionView>
{
    public CollectionView()
    {
    }

    public CollectionView(Action<Microsoft.Maui.Controls.CollectionView?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class CollectionViewExtensions
{
}

public static partial class CollectionViewStyles
{
    public static Action<ICollectionView>? Default { get; set; }
    public static Dictionary<string, Action<ICollectionView>> Themes { get; } = [];
}