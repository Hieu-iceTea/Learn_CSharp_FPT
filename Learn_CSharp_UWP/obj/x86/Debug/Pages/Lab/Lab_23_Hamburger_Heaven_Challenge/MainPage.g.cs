﻿#pragma checksum "D:\Hieu_iceTea\Learn\SEM3\Learn_CSharp_FPT\Learn_CSharp_UWP\Pages\Lab\Lab_23_Hamburger_Heaven_Challenge\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F1C2773C75BCADDA731985F2D3CD2C57"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Learn_CSharp_UWP.Pages.Lab.Lab_23_Hamburger_Heaven_Challenge
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\Lab\Lab_23_Hamburger_Heaven_Challenge\MainPage.xaml line 59
                {
                    this.SplitViewMenu = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 3: // Pages\Lab\Lab_23_Hamburger_Heaven_Challenge\MainPage.xaml line 65
                {
                    this.listBoxMenu = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.listBoxMenu).SelectionChanged += this.listBox_SelectionChanged;
                }
                break;
            case 4: // Pages\Lab\Lab_23_Hamburger_Heaven_Challenge\MainPage.xaml line 68
                {
                    this.Home_ListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 5: // Pages\Lab\Lab_23_Hamburger_Heaven_Challenge\MainPage.xaml line 81
                {
                    this.Favourites_ListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 6: // Pages\Lab\Lab_23_Hamburger_Heaven_Challenge\MainPage.xaml line 94
                {
                    this.Profile_ListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 7: // Pages\Lab\Lab_23_Hamburger_Heaven_Challenge\MainPage.xaml line 107
                {
                    this.World_ListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 8: // Pages\Lab\Lab_23_Hamburger_Heaven_Challenge\MainPage.xaml line 122
                {
                    this.frame_Content = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            case 9: // Pages\Lab\Lab_23_Hamburger_Heaven_Challenge\MainPage.xaml line 19
                {
                    this.btnMenu = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnMenu).Click += this.btnMenu_Click;
                }
                break;
            case 10: // Pages\Lab\Lab_23_Hamburger_Heaven_Challenge\MainPage.xaml line 26
                {
                    this.btnBack = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnBack).Click += this.btnBack_Click;
                }
                break;
            case 11: // Pages\Lab\Lab_23_Hamburger_Heaven_Challenge\MainPage.xaml line 35
                {
                    this.lblTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Pages\Lab\Lab_23_Hamburger_Heaven_Challenge\MainPage.xaml line 42
                {
                    this.txtSearch = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13: // Pages\Lab\Lab_23_Hamburger_Heaven_Challenge\MainPage.xaml line 50
                {
                    this.btnSearch = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

