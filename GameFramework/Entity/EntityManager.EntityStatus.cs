//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2020 Jiang Yin. All rights reserved.
// Homepage: https://GameFramework.cn/
// Feedback: mailto:ellan@GameFramework.cn
//------------------------------------------------------------

namespace GX.Entity
{
    internal sealed partial class EntityManager : GXModule, IEntityManager
    {
        /// <summary>
        /// 实体状态。
        /// </summary>
        private enum EntityStatus : byte
        {
            Unknown = 0,
            WillInit,
            Inited,
            WillShow,
            Showed,
            WillHide,
            Hidden,
            WillRecycle,
            Recycled
        }
    }
}
