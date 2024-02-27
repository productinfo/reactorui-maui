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
public partial interface IDragGestureRecognizer : IGestureRecognizer
{
    object? CanDrag { get; set; }

    Action? DropCompletedAction { get; set; }

    Action<object?, DropCompletedEventArgs>? DropCompletedActionWithArgs { get; set; }

    Action? DragStartingAction { get; set; }

    Action<object?, DragStartingEventArgs>? DragStartingActionWithArgs { get; set; }
}

public partial class DragGestureRecognizer<T> : GestureRecognizer<T>, IDragGestureRecognizer where T : Microsoft.Maui.Controls.DragGestureRecognizer, new()
{
    public DragGestureRecognizer()
    {
        DragGestureRecognizerStyles.Default?.Invoke(this);
    }

    public DragGestureRecognizer(Action<T?> componentRefAction) : base(componentRefAction)
    {
        DragGestureRecognizerStyles.Default?.Invoke(this);
    }

    object? IDragGestureRecognizer.CanDrag { get; set; }

    Action? IDragGestureRecognizer.DropCompletedAction { get; set; }

    Action<object?, DropCompletedEventArgs>? IDragGestureRecognizer.DropCompletedActionWithArgs { get; set; }

    Action? IDragGestureRecognizer.DragStartingAction { get; set; }

    Action<object?, DragStartingEventArgs>? IDragGestureRecognizer.DragStartingActionWithArgs { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsIDragGestureRecognizer = (IDragGestureRecognizer)this;
        thisAsIDragGestureRecognizer.CanDrag = null;
        thisAsIDragGestureRecognizer.DropCompletedAction = null;
        thisAsIDragGestureRecognizer.DropCompletedActionWithArgs = null;
        thisAsIDragGestureRecognizer.DragStartingAction = null;
        thisAsIDragGestureRecognizer.DragStartingActionWithArgs = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIDragGestureRecognizer = (IDragGestureRecognizer)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.DragGestureRecognizer.CanDragProperty, thisAsIDragGestureRecognizer.CanDrag);
        base.OnUpdate();
        OnEndUpdate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (Theme != null && DragGestureRecognizerStyles.Themes.TryGetValue(Theme, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }

    partial void OnAttachingNativeEvents();
    partial void OnDetachingNativeEvents();
    protected override void OnAttachNativeEvents()
    {
        Validate.EnsureNotNull(NativeControl);
        var thisAsIDragGestureRecognizer = (IDragGestureRecognizer)this;
        if (thisAsIDragGestureRecognizer.DropCompletedAction != null || thisAsIDragGestureRecognizer.DropCompletedActionWithArgs != null)
        {
            NativeControl.DropCompleted += NativeControl_DropCompleted;
        }

        if (thisAsIDragGestureRecognizer.DragStartingAction != null || thisAsIDragGestureRecognizer.DragStartingActionWithArgs != null)
        {
            NativeControl.DragStarting += NativeControl_DragStarting;
        }

        OnAttachingNativeEvents();
        base.OnAttachNativeEvents();
    }

    private void NativeControl_DropCompleted(object? sender, DropCompletedEventArgs e)
    {
        var thisAsIDragGestureRecognizer = (IDragGestureRecognizer)this;
        thisAsIDragGestureRecognizer.DropCompletedAction?.Invoke();
        thisAsIDragGestureRecognizer.DropCompletedActionWithArgs?.Invoke(sender, e);
    }

    private void NativeControl_DragStarting(object? sender, DragStartingEventArgs e)
    {
        var thisAsIDragGestureRecognizer = (IDragGestureRecognizer)this;
        thisAsIDragGestureRecognizer.DragStartingAction?.Invoke();
        thisAsIDragGestureRecognizer.DragStartingActionWithArgs?.Invoke(sender, e);
    }

    protected override void OnDetachNativeEvents()
    {
        if (NativeControl != null)
        {
            NativeControl.DropCompleted -= NativeControl_DropCompleted;
            NativeControl.DragStarting -= NativeControl_DragStarting;
        }

        OnDetachingNativeEvents();
        base.OnDetachNativeEvents();
    }
}

public partial class DragGestureRecognizer : DragGestureRecognizer<Microsoft.Maui.Controls.DragGestureRecognizer>
{
    public DragGestureRecognizer()
    {
    }

    public DragGestureRecognizer(Action<Microsoft.Maui.Controls.DragGestureRecognizer?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class DragGestureRecognizerExtensions
{
    public static T CanDrag<T>(this T dragGestureRecognizer, bool canDrag)
        where T : IDragGestureRecognizer
    {
        dragGestureRecognizer.CanDrag = canDrag;
        return dragGestureRecognizer;
    }

    public static T CanDrag<T>(this T dragGestureRecognizer, Func<bool> canDragFunc)
        where T : IDragGestureRecognizer
    {
        dragGestureRecognizer.CanDrag = new PropertyValue<bool>(canDragFunc);
        return dragGestureRecognizer;
    }

    public static T OnDropCompleted<T>(this T dragGestureRecognizer, Action? dropCompletedAction)
        where T : IDragGestureRecognizer
    {
        dragGestureRecognizer.DropCompletedAction = dropCompletedAction;
        return dragGestureRecognizer;
    }

    public static T OnDropCompleted<T>(this T dragGestureRecognizer, Action<object?, DropCompletedEventArgs>? dropCompletedActionWithArgs)
        where T : IDragGestureRecognizer
    {
        dragGestureRecognizer.DropCompletedActionWithArgs = dropCompletedActionWithArgs;
        return dragGestureRecognizer;
    }

    public static T OnDragStarting<T>(this T dragGestureRecognizer, Action? dragStartingAction)
        where T : IDragGestureRecognizer
    {
        dragGestureRecognizer.DragStartingAction = dragStartingAction;
        return dragGestureRecognizer;
    }

    public static T OnDragStarting<T>(this T dragGestureRecognizer, Action<object?, DragStartingEventArgs>? dragStartingActionWithArgs)
        where T : IDragGestureRecognizer
    {
        dragGestureRecognizer.DragStartingActionWithArgs = dragStartingActionWithArgs;
        return dragGestureRecognizer;
    }
}

public static partial class DragGestureRecognizerStyles
{
    public static Action<IDragGestureRecognizer>? Default { get; set; }
    public static Dictionary<string, Action<IDragGestureRecognizer>> Themes { get; } = [];
}