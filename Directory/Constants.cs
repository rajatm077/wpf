using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Directory {
    class Constants {
        public static readonly XNamespace ns = "http://schemas.microsoft.com/wix/2006/wi";
        public static readonly XNamespace ns2 = "http://schemas.microsoft.com/developer/msbuild/2003";


        public static readonly XName COMPILE_TAG = ns2 + "Compile";

        public static readonly XName PRODUCT_TAG = ns + "Product";
        public static readonly XName DEPENDENCY_TAG = ns + "Dependency";
        public static readonly XName MODULE_TAG = ns + "Module";
        public static readonly XName COMPONENT_TAG = ns + "Component";
        public static readonly XName COMPONENT_GROUP_TAG = ns + "ComponentGroup";
        public static readonly XName COMPONENT_GROUP_REF_TAG = ns + "ComponentGroupRef";
        public static readonly XName UI_TAG = ns + "UI";
        public static readonly XName CUSTOM_TABLE_TAG = ns + "CustomTable";
        public static readonly XName DIRECTORY_TAG = ns + "Directory";
        public static readonly XName FRAGMENT_TAG = ns + "Fragment";
        public static readonly XName PACKAGE_TAG = ns + "Package";
        public static readonly XName FEATURE_TAG = ns + "Feature";
        public static readonly XName FILE_TAG = ns + "File";
        public static readonly XName SHORTCUT_TAG = ns + "Shortcut";
        public static readonly XName PROPERTY_TAG = ns + "Property";
        public static readonly XName CONDITION_TAG = ns + "Condition";
        public static readonly XName CLASS_TAG = ns + "Class";
        public static readonly XName MERGE_TAG = ns + "Merge";
        public static readonly XName MERGE_REF_TAG = ns + "MergeRef";
        public static readonly XName CONTROL_TAG = ns + "Control";
        public static readonly XName BINARY_TAG = ns + "Binary";
        public static readonly XName CUSTOM_ACTION_TAG = ns + "CustomAction";
        public static readonly XName CUSTOM_TAG = ns + "Custom";
        public static readonly XName IES_TAG = ns + "InstallExecuteSequence";
        public static readonly XName ICON_TAG = ns + "Icon";

        public static string WIX_TEMPELATE = "";
        public static string templateFile = "";
        public static string productName = "ProductName";
        //public static string wixExtensions = "\"C:\\Program Files (x86)\\WiX Toolset v3.10\\bin\\WixUIExtension.dll\" \"C:\\Program Files (x86)\\WiX Toolset v3.10\\bin\\WixUtilExtension.dll\"";
        public static ObservableCollection<string> messageList = new ObservableCollection<string>();
        public static string outPath = @"D:\Output\Product.wxs"; //Generated WXS path.
        public static string outFolder = "";
        public static string[] wixPath = { "C:\\Program Files (x86)\\WiX Toolset v3.11\\bin", "C:\\Program Files\\WiX Toolset v3.11\\bin" };
        public static string darkPath = "";
        public static string candlePath = "";
        public static string lightPath = "";
        public static string tempWiXPath = "";
        public static XElement ISFile = null; // Reference to Source file.
        public static XElement WiXFile = null; // Reference to WixTemplate.wxs file.

        //REGEX FOR CAs

        public static readonly string re1 = "((?:[a-z][a-z0-9_]*))";   // Variable Name 1
        public static readonly string re2 = ".*?";	// Non-greedy match on filler
        public static readonly string re3 = "((?:[a-z][a-z0-9_]*).{32,32})";    // Variable Name 2

        public static Regex r = new Regex(re1 + re2 + re3, RegexOptions.IgnoreCase | RegexOptions.Singleline);

    }
}
