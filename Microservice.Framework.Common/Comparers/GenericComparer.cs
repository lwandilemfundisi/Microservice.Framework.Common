using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microservice.Framework.Common
{
    public class GenericComparer<T> : IComparer<T>
    {
        private Func<T, T, int> compareDelegate;

        #region Constructors

        public GenericComparer(Func<T, T, int> compareDelegate)
        {
            this.compareDelegate = compareDelegate;
        }

        #endregion

        #region IComparer members

        public int Compare(T x, T y)
        {
            return compareDelegate(x, y);
        }

        #endregion
    }
}
