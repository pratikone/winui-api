---
-api-id: P:Microsoft.UI.Xaml.Controls.NumberBox.SelectionHighlightColor
-api-type: winrt property
---

# Microsoft.UI.Xaml.Controls.NumberBox.SelectionHighlightColor

<!--
public Windows.UI.Xaml.Media.SolidColorBrush SelectionHighlightColor { get; set; }
-->

## -description

Gets or sets the brush used to highlight the selected text.

## -property-value

The brush used to highlight the selected text. The practical default is a brush using the theme resource **TextSelectionHighlightThemeColor**.

## -remarks

The control template sets the default selection highlight color to the system resource **TextSelectionHighlightColorThemeBrush**. To change the selection highlight color for all editable text controls in your app, you can override the **TextSelectionHighlightColorThemeBrush** system resource in App.xaml. This will affect NumberBox, PasswordBox, TextBox, and RichEditBox controls.

## -see-also

[Using brushes to paint backgrounds, foregrounds, and outlines](/windows/apps/design/style/brushes)

## -examples
