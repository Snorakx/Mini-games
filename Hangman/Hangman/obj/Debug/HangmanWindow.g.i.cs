﻿#pragma checksum "..\..\HangmanWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "12E0DA9104A483948D1349B636849ED54DB0EECBF1BCFC3ABB0FA3059AC57A9D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Hangman;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Hangman {
    
    
    /// <summary>
    /// HangmanWindow
    /// </summary>
    public partial class HangmanWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\HangmanWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox GuessWord;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\HangmanWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Letter;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\HangmanWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\HangmanWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LabelWord;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\HangmanWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid lowercaseLetters;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\HangmanWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label score;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\HangmanWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label scoreText;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Hangman;component/hangmanwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\HangmanWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\HangmanWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ClickOneLetter);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 12 "..\..\HangmanWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_ClickWord);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GuessWord = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\HangmanWindow.xaml"
            this.GuessWord.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.resetTextboxValue);
            
            #line default
            #line hidden
            
            #line 13 "..\..\HangmanWindow.xaml"
            this.GuessWord.LostFocus += new System.Windows.RoutedEventHandler(this.resetPlaceholder);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Letter = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\HangmanWindow.xaml"
            this.Letter.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.resetTxtboxValue2);
            
            #line default
            #line hidden
            
            #line 18 "..\..\HangmanWindow.xaml"
            this.Letter.LostFocus += new System.Windows.RoutedEventHandler(this.resetPlaceholderLetter);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 23 "..\..\HangmanWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.img = ((System.Windows.Controls.Image)(target));
            return;
            case 7:
            this.LabelWord = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.lowercaseLetters = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            
            #line 28 "..\..\HangmanWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.mainMenuButtonClickFunction);
            
            #line default
            #line hidden
            return;
            case 10:
            this.score = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.scoreText = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

