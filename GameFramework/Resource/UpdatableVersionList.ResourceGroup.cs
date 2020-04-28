﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2020 Jiang Yin. All rights reserved.
// Homepage: https://GameFramework.cn/
// Feedback: mailto:ellan@GameFramework.cn
//------------------------------------------------------------

namespace GX.Resource
{
    public partial struct UpdatableVersionList
    {
        /// <summary>
        /// 资源组。
        /// </summary>
        public struct ResourceGroup
        {
            private static readonly int[] EmptyIntArray = new int[] { };

            private readonly string m_Name;
            private readonly int[] m_ResourceIndexes;

            /// <summary>
            /// 初始化资源组的新实例。
            /// </summary>
            /// <param name="name">资源组名称。</param>
            /// <param name="resourceIndexes">资源组包含的资源索引集合。</param>
            public ResourceGroup(string name, int[] resourceIndexes)
            {
                if (name == null)
                {
                    throw new GXException("Name is invalid.");
                }

                m_Name = name;
                m_ResourceIndexes = resourceIndexes ?? EmptyIntArray;
            }

            /// <summary>
            /// 获取资源组名称。
            /// </summary>
            public string Name
            {
                get
                {
                    return m_Name;
                }
            }

            /// <summary>
            /// 获取资源组包含的资源索引集合。
            /// </summary>
            /// <returns>资源组包含的资源索引集合。</returns>
            public int[] GetResourceIndexes()
            {
                return m_ResourceIndexes;
            }
        }
    }
}
