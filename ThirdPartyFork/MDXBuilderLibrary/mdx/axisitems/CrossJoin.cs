﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDXBuilderLibrary.mdx;
using MDXBuilderLibrary.mdx.interfaces;
using MDXBuilderLibrary.mdx.Errors;

namespace MDXBuilderLibrary.mdx.axisitems
{
    /// <summary>
    /// 
    /// </summary>
    /// <see cref="http://msdn.microsoft.com/en-us/library/ms144816.aspx"/>
    /// <example>
    /// CrossJoin CrossJoin = new CrossJoin(new MemberAxisItem("[COUNTRY].Members"));
    /// CrossJoin.AddCrossJointTo(new MemberAxisItem("[CITY].Members"));
    /// try
    /// {
    ///     string txt = CrossJoin.Build(); //CrossJoin ([COUNTRY].Members, [CITY].Members)
    /// }
    /// catch (MDXExeption e)
    /// {
    ///     //Do something
    /// }
    /// </example>
    /// 
    /// 
    public class CrossJoin : AbstractAxisItem
    {
        private IMDXAxisItem BaseAxisItem;
        private List<IMDXAxisItem> CrossJoinToList;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="AxisItem"></param>
        public CrossJoin(IMDXAxisItem AxisItem)
        {
            this.BaseAxisItem = AxisItem;
            this.CrossJoinToList = new List<IMDXAxisItem>();
        }
        
        /// <summary>
        /// Add a AxisItem to CrossJoin
        /// </summary>
        /// <param name="AxisItem"></param>
        public CrossJoin AddCrossJointTo(IMDXAxisItem AxisItem)
        {
            if (AxisItem != null)
            {
                this.CrossJoinToList.Add(AxisItem);
                if (this.BaseAxisItem == null)
                    BaseAxisItem = AxisItem;
            }

            return this;
        }

        private static IEnumerable<string> GetValues(List<IMDXAxisItem> list)
        {
            foreach (var item in list)
                yield return item.Build();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <see cref="MDXBuilderLibrary.mdx.interfaces.IMDXAxisItem"/>
        public override string Build()
        {
            if (this.CrossJoinToList == null || this.BaseAxisItem == null || this.CrossJoinToList.Count == 0)
            {
                throw MDXException.WhenBaseNotInit(this);
            }
            return $"{nameof(CrossJoin)} ({string.Join(", ", GetValues(CrossJoinToList))})";
        }
    }
}
