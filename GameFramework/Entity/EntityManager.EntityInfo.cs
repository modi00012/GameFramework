//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2020 Jiang Yin. All rights reserved.
// Homepage: https://GameFramework.cn/
// Feedback: mailto:ellan@GameFramework.cn
//------------------------------------------------------------

using System.Collections.Generic;

namespace GX.Entity
{
    internal sealed partial class EntityManager : GXModule, IEntityManager
    {
        /// <summary>
        /// 实体信息。
        /// </summary>
        private sealed class EntityInfo : IReference
        {
            private IEntity m_Entity;
            private EntityStatus m_Status;
            private IEntity m_ParentEntity;
            private List<IEntity> m_ChildEntities;

            public EntityInfo()
            {
                m_Entity = null;
                m_Status = EntityStatus.Unknown;
                m_ParentEntity = null;
                m_ChildEntities = new List<IEntity>();
            }

            public IEntity Entity
            {
                get
                {
                    return m_Entity;
                }
            }

            public EntityStatus Status
            {
                get
                {
                    return m_Status;
                }
                set
                {
                    m_Status = value;
                }
            }

            public IEntity ParentEntity
            {
                get
                {
                    return m_ParentEntity;
                }
                set
                {
                    m_ParentEntity = value;
                }
            }

            public static EntityInfo Create(IEntity entity)
            {
                if (entity == null)
                {
                    throw new GXException("Entity is invalid.");
                }

                EntityInfo entityInfo = ReferencePool.Acquire<EntityInfo>();
                entityInfo.m_Entity = entity;
                entityInfo.m_Status = EntityStatus.WillInit;
                return entityInfo;
            }

            public void Clear()
            {
                m_Entity = null;
                m_Status = EntityStatus.Unknown;
                m_ParentEntity = null;
                m_ChildEntities.Clear();
            }

            public IEntity[] GetChildEntities()
            {
                return m_ChildEntities.ToArray();
            }

            public void GetChildEntities(List<IEntity> results)
            {
                if (results == null)
                {
                    throw new GXException("Results is invalid.");
                }

                results.Clear();
                foreach (IEntity childEntity in m_ChildEntities)
                {
                    results.Add(childEntity);
                }
            }

            public void AddChildEntity(IEntity childEntity)
            {
                if (m_ChildEntities.Contains(childEntity))
                {
                    throw new GXException("Can not add child entity which is already exist.");
                }

                m_ChildEntities.Add(childEntity);
            }

            public void RemoveChildEntity(IEntity childEntity)
            {
                if (!m_ChildEntities.Remove(childEntity))
                {
                    throw new GXException("Can not remove child entity which is not exist.");
                }
            }
        }
    }
}
