﻿using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;

namespace doubleanimationusingkeyframes
{
    public partial class Page : UserControl
    {
        public Page()
        {
            InitializeComponent();
        }
        // <SnippetDoubleanimationusingkeyframes_cs>
        // When the user clicks the Rectangle, the animation
        // begins.
        private void Pointer_Clicked(object sender, PointerRoutedEventArgs e)
        {
            myStoryboard.Begin();
        }
        // </SnippetDoubleanimationusingkeyframes_cs>
    }
}