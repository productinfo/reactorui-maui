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
public partial interface IStepper : IView
{
    object? Maximum { get; set; }

    object? Minimum { get; set; }

    object? Value { get; set; }

    object? Increment { get; set; }

    Action? ValueChangedAction { get; set; }

    Action<object?, ValueChangedEventArgs>? ValueChangedActionWithArgs { get; set; }
}

public partial class Stepper<T> : View<T>, IStepper where T : Microsoft.Maui.Controls.Stepper, new()
{
    public Stepper()
    {
        StepperStyles.Default?.Invoke(this);
    }

    public Stepper(Action<T?> componentRefAction) : base(componentRefAction)
    {
        StepperStyles.Default?.Invoke(this);
    }

    object? IStepper.Maximum { get; set; }

    object? IStepper.Minimum { get; set; }

    object? IStepper.Value { get; set; }

    object? IStepper.Increment { get; set; }

    Action? IStepper.ValueChangedAction { get; set; }

    Action<object?, ValueChangedEventArgs>? IStepper.ValueChangedActionWithArgs { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsIStepper = (IStepper)this;
        thisAsIStepper.Maximum = null;
        thisAsIStepper.Minimum = null;
        thisAsIStepper.Value = null;
        thisAsIStepper.Increment = null;
        thisAsIStepper.ValueChangedAction = null;
        thisAsIStepper.ValueChangedActionWithArgs = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIStepper = (IStepper)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Stepper.MaximumProperty, thisAsIStepper.Maximum);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Stepper.MinimumProperty, thisAsIStepper.Minimum);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Stepper.ValueProperty, thisAsIStepper.Value);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Stepper.IncrementProperty, thisAsIStepper.Increment);
        base.OnUpdate();
        OnEndUpdate();
    }

    protected override void OnAnimate()
    {
        OnBeginAnimate();
        var thisAsIStepper = (IStepper)this;
        AnimateProperty(Microsoft.Maui.Controls.Stepper.MaximumProperty, thisAsIStepper.Maximum);
        AnimateProperty(Microsoft.Maui.Controls.Stepper.MinimumProperty, thisAsIStepper.Minimum);
        AnimateProperty(Microsoft.Maui.Controls.Stepper.ValueProperty, thisAsIStepper.Value);
        AnimateProperty(Microsoft.Maui.Controls.Stepper.IncrementProperty, thisAsIStepper.Increment);
        base.OnAnimate();
        OnEndAnimate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (Theme != null && StepperStyles.Themes.TryGetValue(Theme, out var styleAction))
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
        var thisAsIStepper = (IStepper)this;
        if (thisAsIStepper.ValueChangedAction != null || thisAsIStepper.ValueChangedActionWithArgs != null)
        {
            NativeControl.ValueChanged += NativeControl_ValueChanged;
        }

        OnAttachingNativeEvents();
        base.OnAttachNativeEvents();
    }

    private void NativeControl_ValueChanged(object? sender, ValueChangedEventArgs e)
    {
        var thisAsIStepper = (IStepper)this;
        thisAsIStepper.ValueChangedAction?.Invoke();
        thisAsIStepper.ValueChangedActionWithArgs?.Invoke(sender, e);
    }

    protected override void OnDetachNativeEvents()
    {
        if (NativeControl != null)
        {
            NativeControl.ValueChanged -= NativeControl_ValueChanged;
        }

        OnDetachingNativeEvents();
        base.OnDetachNativeEvents();
    }
}

public partial class Stepper : Stepper<Microsoft.Maui.Controls.Stepper>
{
    public Stepper()
    {
    }

    public Stepper(Action<Microsoft.Maui.Controls.Stepper?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class StepperExtensions
{
    static void SetMaximum(object stepper, RxAnimation animation) => ((IStepper)stepper).Maximum = ((RxDoubleAnimation)animation).CurrentValue();
    static void SetMinimum(object stepper, RxAnimation animation) => ((IStepper)stepper).Minimum = ((RxDoubleAnimation)animation).CurrentValue();
    static void SetValue(object stepper, RxAnimation animation) => ((IStepper)stepper).Value = ((RxDoubleAnimation)animation).CurrentValue();
    static void SetIncrement(object stepper, RxAnimation animation) => ((IStepper)stepper).Increment = ((RxDoubleAnimation)animation).CurrentValue();
    public static T Maximum<T>(this T stepper, double maximum, RxDoubleAnimation? customAnimation = null)
        where T : IStepper
    {
        stepper.Maximum = maximum;
        stepper.AppendAnimatable(Microsoft.Maui.Controls.Stepper.MaximumProperty, customAnimation ?? new RxDoubleAnimation(maximum), SetMaximum);
        return stepper;
    }

    public static T Maximum<T>(this T stepper, Func<double> maximumFunc)
        where T : IStepper
    {
        stepper.Maximum = new PropertyValue<double>(maximumFunc);
        return stepper;
    }

    public static T Minimum<T>(this T stepper, double minimum, RxDoubleAnimation? customAnimation = null)
        where T : IStepper
    {
        stepper.Minimum = minimum;
        stepper.AppendAnimatable(Microsoft.Maui.Controls.Stepper.MinimumProperty, customAnimation ?? new RxDoubleAnimation(minimum), SetMinimum);
        return stepper;
    }

    public static T Minimum<T>(this T stepper, Func<double> minimumFunc)
        where T : IStepper
    {
        stepper.Minimum = new PropertyValue<double>(minimumFunc);
        return stepper;
    }

    public static T Value<T>(this T stepper, double value, RxDoubleAnimation? customAnimation = null)
        where T : IStepper
    {
        stepper.Value = value;
        stepper.AppendAnimatable(Microsoft.Maui.Controls.Stepper.ValueProperty, customAnimation ?? new RxDoubleAnimation(value), SetValue);
        return stepper;
    }

    public static T Value<T>(this T stepper, Func<double> valueFunc)
        where T : IStepper
    {
        stepper.Value = new PropertyValue<double>(valueFunc);
        return stepper;
    }

    public static T Increment<T>(this T stepper, double increment, RxDoubleAnimation? customAnimation = null)
        where T : IStepper
    {
        stepper.Increment = increment;
        stepper.AppendAnimatable(Microsoft.Maui.Controls.Stepper.IncrementProperty, customAnimation ?? new RxDoubleAnimation(increment), SetIncrement);
        return stepper;
    }

    public static T Increment<T>(this T stepper, Func<double> incrementFunc)
        where T : IStepper
    {
        stepper.Increment = new PropertyValue<double>(incrementFunc);
        return stepper;
    }

    public static T OnValueChanged<T>(this T stepper, Action? valueChangedAction)
        where T : IStepper
    {
        stepper.ValueChangedAction = valueChangedAction;
        return stepper;
    }

    public static T OnValueChanged<T>(this T stepper, Action<object?, ValueChangedEventArgs>? valueChangedActionWithArgs)
        where T : IStepper
    {
        stepper.ValueChangedActionWithArgs = valueChangedActionWithArgs;
        return stepper;
    }
}

public static partial class StepperStyles
{
    public static Action<IStepper>? Default { get; set; }
    public static Dictionary<string, Action<IStepper>> Themes { get; } = [];
}