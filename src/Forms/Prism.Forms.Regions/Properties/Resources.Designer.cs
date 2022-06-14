﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prism.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Prism.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object must be of type &apos;{0}&apos; in order to use the current region adapter..
        /// </summary>
        internal static string AdapterInvalidTypeException {
            get {
                return ResourceManager.GetString("AdapterInvalidTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot change the region name once is set. The current region name is &apos;{0}&apos;..
        /// </summary>
        internal static string CannotChangeRegionNameException {
            get {
                return ResourceManager.GetString("CannotChangeRegionNameException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create navigation target &apos;{0}&apos;..
        /// </summary>
        internal static string CannotCreateNavigationTarget {
            get {
                return ResourceManager.GetString("CannotCreateNavigationTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; does not implement from IRegionBehavior..
        /// </summary>
        internal static string CanOnlyAddTypesThatInheritIFromRegionBehavior {
            get {
                return ResourceManager.GetString("CanOnlyAddTypesThatInheritIFromRegionBehavior", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CarouselView&apos;s ItemSource property is not empty. 
        ///    This control is being associated with a region, but the control is already bound to something else. 
        ///    If you did not explicitly set the control&apos;s ItemSource property, 
        ///    this exception may be caused by a change in the value of the inherited RegionManager attached property..
        /// </summary>
        internal static string CarouselViewHasItemsSourceException {
            get {
                return ResourceManager.GetString("CarouselViewHasItemsSourceException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CollectionView&apos;s ItemSource property is not empty. 
        ///    This control is being associated with a region, but the control is already bound to something else. 
        ///    If you did not explicitly set the control&apos;s ItemsSource property, this exception may be 
        ///    caused by a change in the value of the inherited RegionManager attached property..
        /// </summary>
        internal static string CollectionViewHasItemsSourceException {
            get {
                return ResourceManager.GetString("CollectionViewHasItemsSourceException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ContentView&apos;s Content property is not empty. 
        ///    This control is being associated with a region, but the control is already bound to something else. 
        ///    If you did not explicitly set the control&apos;s Content property, 
        ///    this exception may be caused by a change in the value of the inherited RegionManager attached property..
        /// </summary>
        internal static string ContentViewHasContentException {
            get {
                return ResourceManager.GetString("ContentViewHasContentException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deactivation is not possible in this type of region..
        /// </summary>
        internal static string DeactiveNotPossibleException {
            get {
                return ResourceManager.GetString("DeactiveNotPossibleException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HostControl cannot have null value when behavior attaches..
        /// </summary>
        internal static string HostControlCannotBeNull {
            get {
                return ResourceManager.GetString("HostControlCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The HostControl property cannot be set after Attach method has been called..
        /// </summary>
        internal static string HostControlCannotBeSetAfterAttach {
            get {
                return ResourceManager.GetString("HostControlCannotBeSetAfterAttach", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Layout&lt;View&gt;&apos;s Children property is not empty. 
        ///    This control is being associated with a region, but the control is already bound to something else. 
        ///    If you did not explicitly set the control&apos;s Children or ItemsSource property, 
        ///    this exception may be caused by a change in the value of the inherited RegionManager attached property..
        /// </summary>
        internal static string LayoutViewHasChildrenException {
            get {
                return ResourceManager.GetString("LayoutViewHasChildrenException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mapping with the given type is already registered: {0}..
        /// </summary>
        internal static string MappingExistsException {
            get {
                return ResourceManager.GetString("MappingExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Navigation cannot proceed until a region is set for the RegionNavigationService..
        /// </summary>
        internal static string NavigationServiceHasNoRegion {
            get {
                return ResourceManager.GetString("NavigationServiceHasNoRegion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The IRegionAdapter for the type {0} is not registered in the region adapter mappings. You can register an IRegionAdapter for this control by overriding the ConfigureRegionAdapterMappings method in the bootstrapper..
        /// </summary>
        internal static string NoRegionAdapterException {
            get {
                return ResourceManager.GetString("NoRegionAdapterException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception has occurred while trying to add a view to region &apos;{0}&apos;. 
        ///    - The most likely causing exception was was: &apos;{1}&apos;.
        ///    But also check the InnerExceptions for more detail or call .GetRootException()..
        /// </summary>
        internal static string OnViewRegisteredException {
            get {
                return ResourceManager.GetString("OnViewRegisteredException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Attach method cannot be called when Region property is null..
        /// </summary>
        internal static string RegionBehaviorAttachCannotBeCallWithNullRegion {
            get {
                return ResourceManager.GetString("RegionBehaviorAttachCannotBeCallWithNullRegion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Region property cannot be set after Attach method has been called..
        /// </summary>
        internal static string RegionBehaviorRegionCannotBeSetAfterAttach {
            get {
                return ResourceManager.GetString("RegionBehaviorRegionCannotBeSetAfterAttach", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occurred while creating a region with name &apos;{0}&apos;. The exception was: {1}..
        /// </summary>
        internal static string RegionCreationException {
            get {
                return ResourceManager.GetString("RegionCreationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The region being added already has a name of &apos;{0}&apos; and cannot be added to the region manager with a different name (&apos;{1}&apos;)..
        /// </summary>
        internal static string RegionManagerWithDifferentNameException {
            get {
                return ResourceManager.GetString("RegionManagerWithDifferentNameException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The region name cannot be null or empty..
        /// </summary>
        internal static string RegionNameCannotBeEmptyException {
            get {
                return ResourceManager.GetString("RegionNameCannotBeEmptyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Region with the given name is already registered: {0}.
        /// </summary>
        internal static string RegionNameExistsException {
            get {
                return ResourceManager.GetString("RegionNameExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This RegionManager does not contain a Region with the name &apos;{0}&apos;..
        /// </summary>
        internal static string RegionNotFound {
            get {
                return ResourceManager.GetString("RegionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The region manager does not contain the {0} region..
        /// </summary>
        internal static string RegionNotInRegionManagerException {
            get {
                return ResourceManager.GetString("RegionNotInRegionManagerException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View already exists in region..
        /// </summary>
        internal static string RegionViewExistsException {
            get {
                return ResourceManager.GetString("RegionViewExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View with name &apos;{0}&apos; already exists in the region..
        /// </summary>
        internal static string RegionViewNameExistsException {
            get {
                return ResourceManager.GetString("RegionViewNameExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ScrollView&apos;s Content property is not empty. 
        ///    This control is being associated with a region, but the control is already bound to something else. 
        ///    If you did not explicitly set the control&apos;s Content property, 
        ///    this exception may be caused by a change in the value of the inherited RegionManager attached property..
        /// </summary>
        internal static string ScrollViewHasContentException {
            get {
                return ResourceManager.GetString("ScrollViewHasContentException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided String argument {0} must not be null or empty..
        /// </summary>
        internal static string StringCannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("StringCannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No BehaviorType with key &apos;{0}&apos; was registered..
        /// </summary>
        internal static string TypeWithKeyNotRegistered {
            get {
                return ResourceManager.GetString("TypeWithKeyNotRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occurred while trying to create region objects. 
        ///    - The most likely causing exception was: &apos;{0}&apos;.
        ///    But also check the InnerExceptions for more detail or call .GetRootException()..
        /// </summary>
        internal static string UpdateRegionException {
            get {
                return ResourceManager.GetString("UpdateRegionException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The region does not contain the specified view..
        /// </summary>
        internal static string ViewNotInRegionException {
            get {
                return ResourceManager.GetString("ViewNotInRegionException", resourceCulture);
            }
        }
    }
}
