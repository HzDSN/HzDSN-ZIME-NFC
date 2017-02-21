using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.InteropServices;   //for dll import

namespace 读卡器YLE_280U功能演示
{
    //根据YLE280_API.H包装的静态成员，其中我们用Byte类型，不用Char
    public static class RF_YLE280U
    {
        public const int BUFSIZE = 32;          //读写一个扇区用的缓存区大小

        //扩展方法，字节数组转字符串  Byte[]  --->  String
        public static string ToHexString(this IEnumerable<byte> bytes)
        {
            var sb = new StringBuilder();
            foreach (byte b in bytes)
                sb.Append(b.ToString("X2"));
            return sb.ToString();
        }

        /*---------------------------以上是新增的成员------------------------------*/

        public const int M1CARD_M1 = 1;
        public const int M1CARD_M10 = 2;
        public const int M1CARD_MUL = 3;
        public const int M1CARD_M4K = 4;

        public const int YLE280_OK = 0;    /* 操作成功             */
        public const int YLE280_ERROR = -1;   /* 操作错误             */
        public const int YLE280_NOCARD = -2;   /* 没有检测到卡         */
        public const int YLE280_KEYFAIL = -3;   /* 密钥校验错误         */
        public const int YLE280_MORECARD = -4;   /* 检测到多张卡         */
        public const int YLE280_UNKOWNCARD = -5;   /* 未知的卡型           */

        public const int YLE280_NOOPEN = -10;  /* 设备未打开           */
        public const int YLE280_ALREADYOPEN = -11;  /* 设备已经打开         */
        public const int YLE280_NOCONNECT = -12;  /* 磁卡读写机未联机     */
        public const int YLE280_ERRPARAMETER = -13;  /* 错误的调用参数       */
        public const int YLE280_TIMEOUT = -14;  /* 操作已经超时         */
        public const int YLE280_USERBREAK = -15;  /* 用户中断             */
        public const int YLE280_USERESCAPE = -16;  /* 用户按下ESC键中断操作*/
        public const int YLE280_EMPTYDATA = -17;  /* 空的输入缓冲区       */
        public const int YLE280_DECOVERFLOW = -18;  /* 减值不够发生溢出错误 */

        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_Open(int InComPort);
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_Close();
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_Reset();
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_GetReaderCode();
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_GetCardType();
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_GetSerialNo([Out] Byte[] SerialNo);
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_SelectCard([In] Byte[] SerialNo);
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_HaltCard();
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_Request(int InMode);
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_Authentication(int InSectorNo, int InBlockNo, int InMode);
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_TransKey(int InSectorNo, [In] Byte[] InKey);
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_ModifyKey(int InBlockNo, [In] Byte[] InKeyA, [In] Byte[] InKeyB, [In] Byte[] InCtrlWord, int InMode);
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_ReadBlock(int InBlockNo, [Out] Byte[] ReadBuf, int InMode);
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_WriteBlock(int InBlockNo, [In] Byte[] WriteBuf, int InMode);
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_ePurseRead(int InBlockNo, [Out] Byte[] ReadBuf);
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_ePurseToInt([In] Byte[] ReadBuf);
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_ePurseWrite(int InBlockNo, int InValue);
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_ePurseInc(int InBlockNo, int InValue);
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_ePurseDec(int InBlockNo, int InValue);
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_PlayBuzzer(int InTime);
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_BuzzerOn();
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_BuzzerOff();
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_RedLedOn();
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_RedLedOff();
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_GreenLedOn();
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int YLE280_GreenLedOff();
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int UB_Hex2Str([In] Byte[] InHex, int InLen, [Out] Byte OutStr);
        [DllImport("YLE280_API.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int UB_Str2Hex([In] Byte[] InStr, [Out] Byte OutHex);
    }
}
