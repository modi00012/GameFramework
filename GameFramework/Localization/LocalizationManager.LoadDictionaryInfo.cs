﻿//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2020 Jiang Yin. All rights reserved.
// Homepage: https://GameFramework.cn/
// Feedback: mailto:ellan@GameFramework.cn
//------------------------------------------------------------

namespace GX.Localization
{
    internal sealed partial class LocalizationManager : GXModule, ILocalizationManager
    {
        private sealed class LoadDictionaryInfo : IReference
        {
            private LoadType m_LoadType;
            private object m_UserData;

            public LoadDictionaryInfo()
            {
                m_LoadType = LoadType.TextFromAsset;
                m_UserData = null;
            }

            public LoadType LoadType
            {
                get
                {
                    return m_LoadType;
                }
            }

            public object UserData
            {
                get
                {
                    return m_UserData;
                }
            }

            public static LoadDictionaryInfo Create(LoadType loadType, object userData)
            {
                LoadDictionaryInfo loadDictionaryInfo = ReferencePool.Acquire<LoadDictionaryInfo>();
                loadDictionaryInfo.m_LoadType = loadType;
                loadDictionaryInfo.m_UserData = userData;
                return loadDictionaryInfo;
            }

            public void Clear()
            {
                m_LoadType = LoadType.TextFromAsset;
                m_UserData = null;
            }
        }
    }
}
