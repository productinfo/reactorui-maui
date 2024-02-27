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
namespace MauiReactor.Shapes;
public partial interface IShape : IView
{
    object? Fill { get; set; }

    object? Stroke { get; set; }

    object? StrokeThickness { get; set; }

    object? StrokeDashArray { get; set; }

    object? StrokeDashOffset { get; set; }

    object? StrokeLineCap { get; set; }

    object? StrokeLineJoin { get; set; }

    object? StrokeMiterLimit { get; set; }

    object? Aspect { get; set; }
}

public abstract partial class Shape<T> : View<T>, IShape where T : Microsoft.Maui.Controls.Shapes.Shape, new()
{
    protected Shape()
    {
        ShapeStyles.Default?.Invoke(this);
    }

    protected Shape(Action<T?> componentRefAction) : base(componentRefAction)
    {
        ShapeStyles.Default?.Invoke(this);
    }

    object? IShape.Fill { get; set; }

    object? IShape.Stroke { get; set; }

    object? IShape.StrokeThickness { get; set; }

    object? IShape.StrokeDashArray { get; set; }

    object? IShape.StrokeDashOffset { get; set; }

    object? IShape.StrokeLineCap { get; set; }

    object? IShape.StrokeLineJoin { get; set; }

    object? IShape.StrokeMiterLimit { get; set; }

    object? IShape.Aspect { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsIShape = (IShape)this;
        thisAsIShape.Fill = null;
        thisAsIShape.Stroke = null;
        thisAsIShape.StrokeThickness = null;
        thisAsIShape.StrokeDashArray = null;
        thisAsIShape.StrokeDashOffset = null;
        thisAsIShape.StrokeLineCap = null;
        thisAsIShape.StrokeLineJoin = null;
        thisAsIShape.StrokeMiterLimit = null;
        thisAsIShape.Aspect = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIShape = (IShape)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Shape.FillProperty, thisAsIShape.Fill);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Shape.StrokeProperty, thisAsIShape.Stroke);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Shape.StrokeThicknessProperty, thisAsIShape.StrokeThickness);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Shape.StrokeDashArrayProperty, thisAsIShape.StrokeDashArray);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Shape.StrokeDashOffsetProperty, thisAsIShape.StrokeDashOffset);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Shape.StrokeLineCapProperty, thisAsIShape.StrokeLineCap);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Shape.StrokeLineJoinProperty, thisAsIShape.StrokeLineJoin);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Shape.StrokeMiterLimitProperty, thisAsIShape.StrokeMiterLimit);
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.Shapes.Shape.AspectProperty, thisAsIShape.Aspect);
        base.OnUpdate();
        OnEndUpdate();
    }

    protected override void OnAnimate()
    {
        OnBeginAnimate();
        var thisAsIShape = (IShape)this;
        AnimateProperty(Microsoft.Maui.Controls.Shapes.Shape.StrokeThicknessProperty, thisAsIShape.StrokeThickness);
        AnimateProperty(Microsoft.Maui.Controls.Shapes.Shape.StrokeDashOffsetProperty, thisAsIShape.StrokeDashOffset);
        AnimateProperty(Microsoft.Maui.Controls.Shapes.Shape.StrokeMiterLimitProperty, thisAsIShape.StrokeMiterLimit);
        base.OnAnimate();
        OnEndAnimate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (Theme != null && ShapeStyles.Themes.TryGetValue(Theme, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public static partial class ShapeExtensions
{
    static void SetStrokeThickness(object shape, RxAnimation animation) => ((IShape)shape).StrokeThickness = ((RxDoubleAnimation)animation).CurrentValue();
    static void SetStrokeDashOffset(object shape, RxAnimation animation) => ((IShape)shape).StrokeDashOffset = ((RxDoubleAnimation)animation).CurrentValue();
    static void SetStrokeMiterLimit(object shape, RxAnimation animation) => ((IShape)shape).StrokeMiterLimit = ((RxDoubleAnimation)animation).CurrentValue();
    public static T Fill<T>(this T shape, Microsoft.Maui.Controls.Brush fill)
        where T : IShape
    {
        shape.Fill = fill;
        return shape;
    }

    public static T Fill<T>(this T shape, Func<Microsoft.Maui.Controls.Brush> fillFunc)
        where T : IShape
    {
        shape.Fill = new PropertyValue<Microsoft.Maui.Controls.Brush>(fillFunc);
        return shape;
    }

    public static T Stroke<T>(this T shape, Microsoft.Maui.Controls.Brush stroke)
        where T : IShape
    {
        shape.Stroke = stroke;
        return shape;
    }

    public static T Stroke<T>(this T shape, Func<Microsoft.Maui.Controls.Brush> strokeFunc)
        where T : IShape
    {
        shape.Stroke = new PropertyValue<Microsoft.Maui.Controls.Brush>(strokeFunc);
        return shape;
    }

    public static T StrokeThickness<T>(this T shape, double strokeThickness, RxDoubleAnimation? customAnimation = null)
        where T : IShape
    {
        shape.StrokeThickness = strokeThickness;
        shape.AppendAnimatable(Microsoft.Maui.Controls.Shapes.Shape.StrokeThicknessProperty, customAnimation ?? new RxDoubleAnimation(strokeThickness), SetStrokeThickness);
        return shape;
    }

    public static T StrokeThickness<T>(this T shape, Func<double> strokeThicknessFunc)
        where T : IShape
    {
        shape.StrokeThickness = new PropertyValue<double>(strokeThicknessFunc);
        return shape;
    }

    public static T StrokeDashArray<T>(this T shape, Microsoft.Maui.Controls.DoubleCollection strokeDashArray)
        where T : IShape
    {
        shape.StrokeDashArray = strokeDashArray;
        return shape;
    }

    public static T StrokeDashArray<T>(this T shape, Func<Microsoft.Maui.Controls.DoubleCollection> strokeDashArrayFunc)
        where T : IShape
    {
        shape.StrokeDashArray = new PropertyValue<Microsoft.Maui.Controls.DoubleCollection>(strokeDashArrayFunc);
        return shape;
    }

    public static T StrokeDashOffset<T>(this T shape, double strokeDashOffset, RxDoubleAnimation? customAnimation = null)
        where T : IShape
    {
        shape.StrokeDashOffset = strokeDashOffset;
        shape.AppendAnimatable(Microsoft.Maui.Controls.Shapes.Shape.StrokeDashOffsetProperty, customAnimation ?? new RxDoubleAnimation(strokeDashOffset), SetStrokeDashOffset);
        return shape;
    }

    public static T StrokeDashOffset<T>(this T shape, Func<double> strokeDashOffsetFunc)
        where T : IShape
    {
        shape.StrokeDashOffset = new PropertyValue<double>(strokeDashOffsetFunc);
        return shape;
    }

    public static T StrokeLineCap<T>(this T shape, Microsoft.Maui.Controls.Shapes.PenLineCap strokeLineCap)
        where T : IShape
    {
        shape.StrokeLineCap = strokeLineCap;
        return shape;
    }

    public static T StrokeLineCap<T>(this T shape, Func<Microsoft.Maui.Controls.Shapes.PenLineCap> strokeLineCapFunc)
        where T : IShape
    {
        shape.StrokeLineCap = new PropertyValue<Microsoft.Maui.Controls.Shapes.PenLineCap>(strokeLineCapFunc);
        return shape;
    }

    public static T StrokeLineJoin<T>(this T shape, Microsoft.Maui.Controls.Shapes.PenLineJoin strokeLineJoin)
        where T : IShape
    {
        shape.StrokeLineJoin = strokeLineJoin;
        return shape;
    }

    public static T StrokeLineJoin<T>(this T shape, Func<Microsoft.Maui.Controls.Shapes.PenLineJoin> strokeLineJoinFunc)
        where T : IShape
    {
        shape.StrokeLineJoin = new PropertyValue<Microsoft.Maui.Controls.Shapes.PenLineJoin>(strokeLineJoinFunc);
        return shape;
    }

    public static T StrokeMiterLimit<T>(this T shape, double strokeMiterLimit, RxDoubleAnimation? customAnimation = null)
        where T : IShape
    {
        shape.StrokeMiterLimit = strokeMiterLimit;
        shape.AppendAnimatable(Microsoft.Maui.Controls.Shapes.Shape.StrokeMiterLimitProperty, customAnimation ?? new RxDoubleAnimation(strokeMiterLimit), SetStrokeMiterLimit);
        return shape;
    }

    public static T StrokeMiterLimit<T>(this T shape, Func<double> strokeMiterLimitFunc)
        where T : IShape
    {
        shape.StrokeMiterLimit = new PropertyValue<double>(strokeMiterLimitFunc);
        return shape;
    }

    public static T Aspect<T>(this T shape, Microsoft.Maui.Controls.Stretch aspect)
        where T : IShape
    {
        shape.Aspect = aspect;
        return shape;
    }

    public static T Aspect<T>(this T shape, Func<Microsoft.Maui.Controls.Stretch> aspectFunc)
        where T : IShape
    {
        shape.Aspect = new PropertyValue<Microsoft.Maui.Controls.Stretch>(aspectFunc);
        return shape;
    }
}

public static partial class ShapeStyles
{
    public static Action<IShape>? Default { get; set; }
    public static Dictionary<string, Action<IShape>> Themes { get; } = [];
}