---
-api-id: T:Microsoft.UI.Xaml.Media.Animation.ColorKeyFrame
-api-type: winrt class
---

<!-- Class syntax.
public class ColorKeyFrame : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Media.Animation.IColorKeyFrame
-->

# Microsoft.UI.Xaml.Media.Animation.ColorKeyFrame

## -description
Provides a base class for specific animation key-frame techniques that define an animation segment with a [Color](/uwp/api/windows.ui.color) target value. Derived classes each provide a different key-frame interpolation method for a [Color](/uwp/api/windows.ui.color) value that is provided for a [ColorAnimationUsingKeyFrames](coloranimationusingkeyframes.md) animation.

## -remarks
### **ColorKeyFrame** derived classes

ColorKeyFrame is the parent class for several immediately derived classes that define the interpolation behavior for the typed keyframe.

+ [DiscreteColorKeyFrame](discretecolorkeyframe.md)
+ [EasingColorKeyFrame](easingcolorkeyframe.md)
+ [LinearColorKeyFrame](linearcolorkeyframe.md)
+ [SplineColorKeyFrame](splinecolorkeyframe.md)


## -examples

## -see-also
[DependencyObject](../microsoft.ui.xaml/dependencyobject.md)