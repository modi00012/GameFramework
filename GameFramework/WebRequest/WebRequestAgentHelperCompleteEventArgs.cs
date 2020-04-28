//------------------------------------------------------------
// Game Framework
// Copyright © 2013-2020 Jiang Yin. All rights reserved.
// Homepage: https://GameFramework.cn/
// Feedback: mailto:ellan@GameFramework.cn
//------------------------------------------------------------

namespace GX.WebRequest
{
    /// <summary>
    /// Web 请求代理辅助器完成事件。
    /// </summary>
    public sealed class WebRequestAgentHelperCompleteEventArgs : GXEventArgs
    {
        private byte[] m_WebResponseBytes;

        /// <summary>
        /// 初始化 Web 请求代理辅助器完成事件的新实例。
        /// </summary>
        public WebRequestAgentHelperCompleteEventArgs()
        {
            m_WebResponseBytes = null;
        }

        /// <summary>
        /// 创建 Web 请求代理辅助器完成事件。
        /// </summary>
        /// <param name="webResponseBytes">Web 响应的数据流。</param>
        /// <returns>创建的 Web 请求代理辅助器完成事件。</returns>
        public static WebRequestAgentHelperCompleteEventArgs Create(byte[] webResponseBytes)
        {
            WebRequestAgentHelperCompleteEventArgs webRequestAgentHelperCompleteEventArgs = ReferencePool.Acquire<WebRequestAgentHelperCompleteEventArgs>();
            webRequestAgentHelperCompleteEventArgs.m_WebResponseBytes = webResponseBytes;
            return webRequestAgentHelperCompleteEventArgs;
        }

        /// <summary>
        /// 清理 Web 请求代理辅助器完成事件。
        /// </summary>
        public override void Clear()
        {
            m_WebResponseBytes = null;
        }

        /// <summary>
        /// 获取 Web 响应的数据流。
        /// </summary>
        /// <returns>Web 响应的数据流。</returns>
        public byte[] GetWebResponseBytes()
        {
            return m_WebResponseBytes;
        }
    }
}
