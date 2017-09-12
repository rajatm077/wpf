using System.Windows.Media;
using System.Windows;
using System.IO;
using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml;
using System.Windows.Media.Imaging;

namespace Directory {
    class GetDirectories {

        public static void check(TreeView treeView) {
            var rootdir = GetProductDirectories();

            treeView.Items.Clear();
            TreeViewItem treeNode = new TreeViewItem();                

            AddImageTextToTreeNode(treeNode, rootdir.Attribute("Id").Value);
            treeView.Items.Add(treeNode);
            BuildNodes(treeNode, rootdir);

        }

        static void AddImageTextToTreeNode(TreeViewItem treeNode, string headerVal) {
            StackPanel stkPanel = new StackPanel { Orientation = Orientation.Horizontal };

            TextBlock txtblock = new TextBlock { Text = headerVal };

            Image img = new Image { Margin = new Thickness { Left = 5, Right = 5, } };


            if (headerVal == "TARGETDIR") {
                img.Source = new BitmapImage(new Uri(@"icons/ComputerIcon.png", UriKind.Relative));
            } else {
                img.Source = new BitmapImage(new Uri(@"icons/FolderIcon.png", UriKind.Relative));
            }

            stkPanel.Children.Add(img);
            stkPanel.Children.Add(txtblock);

            treeNode.Header = stkPanel;
            treeNode.IsExpanded = true;
            treeNode.Margin = new Thickness { Top = 2, Bottom = 2 };
        }

        private static XElement GetProductDirectories() {
            XElement xmlFile = XElement.Load(Path.GetTempPath() + "tempWix.wxs");
            var product = xmlFile.Element(Constants.PRODUCT_TAG);
            var tempDirs = product.Descendants(Constants.DIRECTORY_TAG);

            for (int i = 0; i < tempDirs.Count();) {
                if (tempDirs.ElementAt(i) != null) {
                    string value = tempDirs.ElementAt(i).Attribute("Id").Value;
                    if (value.Split('.').Count() > 1) {
                        tempDirs.ElementAt(i).DescendantNodesAndSelf().Remove();
                    } else {
                        i++;
                    }
                }
            }

            XElement dirs = new XElement(Constants.FRAGMENT_TAG);
            dirs.Add(tempDirs);
            dirs.Save((Path.GetTempPath() + "dirFragment.xml"));
            return dirs.Descendants(Constants.DIRECTORY_TAG).First();
        }

        private static void BuildNodes(TreeViewItem treeNode, XElement rootdir) {

            foreach (var child in rootdir.Elements(Constants.DIRECTORY_TAG)) {
                string headerVal = null;
                if ( child.Attribute("Name") != null) {
                    headerVal = child.Attribute("Name").Value;
                } else {
                    headerVal = "[" + child.Attribute("Id").Value + "]";
                }

                TreeViewItem childTreeNode = new TreeViewItem();
                AddImageTextToTreeNode(childTreeNode, headerVal);

                treeNode.Items.Add(childTreeNode);
                BuildNodes(childTreeNode, child);
            }
        }
    }
}







