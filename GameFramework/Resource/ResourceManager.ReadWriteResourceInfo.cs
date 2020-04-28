//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2020 Jiang Yin. All rights reserved.
// Homepage: https://GameFramework.cn/
// Feedback: mailto:ellan@GameFramework.cn
//------------------------------------------------------------

namespace GX.Resource
{
    internal sealed partial class ResourceManager : GXModule, IResourceManager
    {
        private struct ReadWriteResourceInfo
        {
            private readonly LoadType m_LoadType;
            private readonly int m_Length;
            private readonly int m_HashCode;

            public ReadWriteResourceInfo(LoadType loadType, int length, int hashCode)
            {
                m_LoadType = loadType;
                m_Length = length;
                m_HashCode = hashCode;
            }

            public LoadType LoadType
            {
                get
                {
                    return m_LoadType;
                }
            }

            public int Length
            {
                get
                {
                    return m_Length;
                }
            }

            public int HashCode
            {
                get
                {
                    return m_HashCode;
                }
            }
        }
    }
}
