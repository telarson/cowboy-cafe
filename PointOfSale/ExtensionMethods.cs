/* ExtensionMethods.c
 * Author: Tristan Larson
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace CowboyCafe.Extensions
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// returns the first ancestor in the Visual Tree that has the specified type or
        /// null if none is found.
        /// </summary>
        /// <typeparam name="T">The type to search for</typeparam>
        /// <param name="element"></param>
        /// <returns>First ancestor of type T</returns>
        public static T FindAncestor<T>(this DependencyObject element) where T : DependencyObject
        {
            var parent = VisualTreeHelper.GetParent(element);

            if (parent is null) return null;

            if (parent is T) return parent as T;

            return FindAncestor<T>(parent as DependencyObject);
        }
    }
}
