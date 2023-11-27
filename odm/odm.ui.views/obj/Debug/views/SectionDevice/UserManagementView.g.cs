﻿#pragma checksum "..\..\..\..\views\SectionDevice\UserManagementView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EB7FCC041B452FED21694D31FC99515251025675968D9DBFE28C6FD62D8257FB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using odm.ui.activities;


namespace odm.ui.activities {
    
    
    /// <summary>
    /// UserManagementView
    /// </summary>
    public partial class UserManagementView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 42 "..\..\..\..\views\SectionDevice\UserManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock policiesCaption;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\views\SectionDevice\UserManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button downloadPoliciesButton;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\views\SectionDevice\UserManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button uploadPoliciesButton;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\views\SectionDevice\UserManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editPoliciesButton;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\views\SectionDevice\UserManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock usersCaption;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\views\SectionDevice\UserManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox usersList;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\..\..\views\SectionDevice\UserManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button createUserButton;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\..\views\SectionDevice\UserManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button modifyUserButton;
        
        #line default
        #line hidden
        
        
        #line 136 "..\..\..\..\views\SectionDevice\UserManagementView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteUserButton;
        
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
            System.Uri resourceLocater = new System.Uri("/odm.ui.views;component/views/sectiondevice/usermanagementview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\views\SectionDevice\UserManagementView.xaml"
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
            this.policiesCaption = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.downloadPoliciesButton = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.uploadPoliciesButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.editPoliciesButton = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.usersCaption = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.usersList = ((System.Windows.Controls.ListBox)(target));
            
            #line 61 "..\..\..\..\views\SectionDevice\UserManagementView.xaml"
            this.usersList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.usersList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.createUserButton = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.modifyUserButton = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.deleteUserButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
