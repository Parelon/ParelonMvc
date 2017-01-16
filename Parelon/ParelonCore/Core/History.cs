using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ParelonCore.Core
{

    public static class History
    {
        private static List<ViewContext> __history = null;
        private static int currentIndex = -1, count = 0;

        public static int getCount() { return count; }
        public static int getCurrentIndex() { return currentIndex; }
        public static bool hasPrev() { return true; /* return currentIndex > 0; */ }
        public static bool hasNext() { return true; /* return currentIndex < (count - 1); */ }

        public static void addView(ViewContext page)
        {
            //if (__history == null)
            //    __history = new List<ViewContext>();
            ////clear history after current index
            //if (count > 0 && __history[currentIndex] != page)
            //{
            //    __history.Add(page);
            //    count++;
            //    currentIndex++;
            //    if (currentIndex < count - 1)
            //    {
            //        //clear history after current index
            //    }
            //}
            //else
            //{
            //    __history.Add(page);
            //    count++;
            //    currentIndex++;
            //}
        }

        public static ViewContext getPrev() { currentIndex--; return __history[currentIndex]; }
        public static ViewContext getNext() { currentIndex++; return __history[currentIndex]; }

        public static void clearHistory()
        {
            count = 0;
            currentIndex = -1;
            if (__history != null)
                __history.Clear();
        }
    }
}