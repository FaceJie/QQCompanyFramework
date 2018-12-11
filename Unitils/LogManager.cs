using log4net;
using log4net.Layout;
using log4net.Layout.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using log4net.Core;
using System.IO;

namespace Unitils
{
    public class LogManager
    {
        private static ActionLoggerInfo _message = null;
        private static log4net.ILog Log;
        public static void Debug()
        {
            if (Log.IsDebugEnabled)
            {
                Log.Debug(_message);
            }
        }
        public static void Error()
        {
            if (Log.IsErrorEnabled)
            {
                Log.Error(_message);
            }
        }
        public static void Fatal()
        {
            if (Log.IsFatalEnabled)
            {
                Log.Fatal(_message);
            }
        }
        public static void Info()
        {
            if (Log.IsInfoEnabled)
            {
                Log.Info(_message);
            }
        }
        public static void Warn()
        {
            if (Log.IsWarnEnabled)
            {
                Log.Warn(_message);
            }
        }
        /// <summary>
        /// 写日志，数据库和 C:\\WebServerLogs\\位置，注意给C盘WebServerLogs的读写权限
        /// </summary>
        /// <param name="userId">执行人Id</param>
        /// <param name="userName">执行人名称</param>
        /// <param name="smessage">该用户干了什么</param>
        /// <param name="level">1.Info、2.Warn、3.Error、4.Fatal、default：未知错误</param>
        public static void SaveMessage(string userId, string userName, string smessage,string exception, int level)
        {
            MethodBase method = new System.Diagnostics.StackTrace().GetFrame(1).GetMethod();
            String className = method.ReflectedType.FullName;
            String methodName = method.Name;
            Log = log4net.LogManager.GetLogger(className);
            _message = new ActionLoggerInfo(userId, userName,  smessage, exception);
            switch (level)
            {
                case 1: Info(); break;
                case 2: Warn(); break;
                case 3: Error(); break;
                case 4: Fatal(); break;
                default: break;
            }
        }
    }
    public class ActionLayoutPattern : PatternLayout
    {
        public ActionLayoutPattern()
        {
            this.AddConverter("actionInfo", typeof(ActionConverter));
        }
    }
    public class ActionConverter : PatternLayoutConverter
    {
        protected override void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            var actionInfo = loggingEvent.MessageObject as ActionLoggerInfo;

            if (actionInfo == null)
            {
                writer.Write("");
            }
            else
            {
                switch (this.Option.ToLower())
                {
                    case "userid":
                        writer.Write(actionInfo.UserID);
                        break;
                    case "username":
                        writer.Write(actionInfo.UserName);
                        break;
                    case "message":
                        writer.Write(actionInfo.sMessage);
                        break;
                    case "exception":
                        writer.Write(actionInfo.sException);
                        break;
                    default:
                        writer.Write("");
                        break;
                }
            }
        }
    }
    public class ActionLoggerInfo
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string sMessage { get; set; }
        public string sException { get; set; }
        public ActionLoggerInfo(string userId, string UserName, string smessage,string sException)
        {
            this.UserID = userId;
            this.UserName = UserName;
            this.sMessage = smessage;
            this.sException = sException;
        }
    }
}
