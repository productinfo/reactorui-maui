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
public partial interface IImageCell : ITextCell
{
    object? ImageSource { get; set; }
}

public partial class ImageCell<T> : TextCell<T>, IImageCell where T : Microsoft.Maui.Controls.ImageCell, new()
{
    public ImageCell()
    {
        ImageCellStyles.Default?.Invoke(this);
    }

    public ImageCell(Action<T?> componentRefAction) : base(componentRefAction)
    {
        ImageCellStyles.Default?.Invoke(this);
    }

    object? IImageCell.ImageSource { get; set; }

    internal override void Reset()
    {
        base.Reset();
        var thisAsIImageCell = (IImageCell)this;
        thisAsIImageCell.ImageSource = null;
        OnReset();
    }

    partial void OnReset();
    protected override void OnUpdate()
    {
        OnBeginUpdate();
        Validate.EnsureNotNull(NativeControl);
        var thisAsIImageCell = (IImageCell)this;
        SetPropertyValue(NativeControl, Microsoft.Maui.Controls.ImageCell.ImageSourceProperty, thisAsIImageCell.ImageSource);
        base.OnUpdate();
        OnEndUpdate();
    }

    partial void OnBeginUpdate();
    partial void OnEndUpdate();
    partial void OnBeginAnimate();
    partial void OnEndAnimate();
    protected override void OnThemeChanged()
    {
        if (Theme != null && ImageCellStyles.Themes.TryGetValue(Theme, out var styleAction))
        {
            styleAction(this);
        }

        base.OnThemeChanged();
    }
}

public partial class ImageCell : ImageCell<Microsoft.Maui.Controls.ImageCell>
{
    public ImageCell()
    {
    }

    public ImageCell(Action<Microsoft.Maui.Controls.ImageCell?> componentRefAction) : base(componentRefAction)
    {
    }
}

public static partial class ImageCellExtensions
{
    public static T ImageSource<T>(this T imageCell, Microsoft.Maui.Controls.ImageSource imageSource)
        where T : IImageCell
    {
        imageCell.ImageSource = imageSource;
        return imageCell;
    }

    public static T ImageSource<T>(this T imageCell, Func<Microsoft.Maui.Controls.ImageSource> imageSourceFunc)
        where T : IImageCell
    {
        imageCell.ImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(imageSourceFunc);
        return imageCell;
    }

    public static T ImageSource<T>(this T imageCell, string file)
        where T : IImageCell
    {
        imageCell.ImageSource = Microsoft.Maui.Controls.ImageSource.FromFile(file);
        return imageCell;
    }

    public static T ImageSource<T>(this T imageCell, Func<string> action)
        where T : IImageCell
    {
        imageCell.ImageSource = new PropertyValue<Microsoft.Maui.Controls.ImageSource>(() => Microsoft.Maui.Controls.ImageSource.FromFile(action()));
        return imageCell;
    }

    public static T ImageSource<T>(this T imageCell, string resourceName, Assembly sourceAssembly)
        where T : IImageCell
    {
        imageCell.ImageSource = Microsoft.Maui.Controls.ImageSource.FromResource(resourceName, sourceAssembly);
        return imageCell;
    }

    public static T ImageSource<T>(this T imageCell, Uri imageUri)
        where T : IImageCell
    {
        imageCell.ImageSource = Microsoft.Maui.Controls.ImageSource.FromUri(imageUri);
        return imageCell;
    }

    public static T ImageSource<T>(this T imageCell, Uri imageUri, bool cachingEnabled, TimeSpan cacheValidity)
        where T : IImageCell
    {
        imageCell.ImageSource = new UriImageSource
        {
            Uri = imageUri,
            CachingEnabled = cachingEnabled,
            CacheValidity = cacheValidity
        };
        return imageCell;
    }

    public static T ImageSource<T>(this T imageCell, Func<Stream> imageStream)
        where T : IImageCell
    {
        imageCell.ImageSource = Microsoft.Maui.Controls.ImageSource.FromStream(imageStream);
        return imageCell;
    }
}

public static partial class ImageCellStyles
{
    public static Action<IImageCell>? Default { get; set; }
    public static Dictionary<string, Action<IImageCell>> Themes { get; } = [];
}