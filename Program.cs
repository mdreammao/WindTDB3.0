using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using TDBAPI;
using TDBAPIImp;
using myWindAPI;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

             ETFOption myStore5 = new ETFOption("SH", 20150209, 20170531);
            //Stocks myStore6 = new Stocks("SH", 20150101, 20170531);


            //输出版本信息
            //Console.WriteLine("version:{0}", TDBVersion.GetVersion());
            //Console.Write("请输入IP:\n");
            //string strIP = Console.ReadLine();
            //Console.Write("请输入端口:\n");
            //string strPort = Console.ReadLine();
            //Console.Write("请输入用户名:\n");
            //string strUser = Console.ReadLine();
            //Console.Write("请输入密码名:\n");
            //string strPassword = Console.ReadLine();
#if true
            TDBDataSource tdbSource = new TDBDataSource("114.80.154.34", "6270", "W59289091558", "85638978", 30, 1, 1);
            TDBLoginResult loginRes;
            TDBErrNo nErr = tdbSource.Connect(out loginRes);
#endif
            //////////////////////////////////////////////////////////////////////////
            //代理连接
#if false
             //代理
            string strProxyIp   = "10.100.3.42";
            string strProxyPort = "12345";
            string strProxyUser = "1";
            string strProxyPwd  = "1";
            LibTDBWrap.TDBProxyType nProxyType = LibTDBWrap.TDBProxyType.TDB_PROXY_HTTP11;
            TDBDataSource tdbSource = new TDBDataSource(strIP, strPort, strUser, strPassword, strProxyIp, strProxyPort, strProxyUser, strProxyPwd, nProxyType);
            TDBLoginResult loginRes;
            TDBErrNo nErr = tdbSource.ConnectProxy(out loginRes);
#endif
            //////////////////////////////////////////////////////////////////////////
            //输出登陆结果
            //if (nErr == TDBErrNo.TDB_OPEN_FAILED)
            //{
            //    Console.WriteLine("open failed, reason:{0}", loginRes.m_strInfo);
            //    return;
            //}
            //else
            //{
            //    Console.WriteLine("login ok!market count:{0}", loginRes.m_strMarkets.Length);
            //    Debug.Assert(loginRes.m_nDynDates.Length == loginRes.m_strMarkets.Length);
            //    for (int i = 0; i < loginRes.m_strMarkets.Length; i++)
            //    {
            //        //输出授权的市场，和数据最新日期
            //        Console.WriteLine("market:{0}, dyndate:{1}", loginRes.m_strMarkets[i], loginRes.m_nDynDates[i]);
            //    }
            //}
            

            #region 测试内容
            //Thread.Sleep(3000);//等待3秒，以便查看输出
            //                   //测试输出代码表
            //{
            //    TDBCode[] codeArr1;
            //    TDBErrNo nRetInner = tdbSource.GetCodeTable(loginRes.m_strMarkets[0], out codeArr1);
            //    Console.WriteLine("测试代码表，market:{0}", loginRes.m_strMarkets[0]);

            //    if (nRetInner == TDBErrNo.TDB_SUCCESS)
            //    {
            //        Console.WriteLine("-----------{0}------------", codeArr1.Length);
            //        //输出前10项
            //        for (int i = 0; i < codeArr1.Length && i < 10; i++)
            //        {
            //            Console.WriteLine("windcode:{0}, code:{1}, cnname:{2}, enname:{3}, type:{4}, market:{5}",
            //                codeArr1[i].m_strWindCode, codeArr1[i].m_strCode, codeArr1[i].m_strCNName, codeArr1[i].m_strENName, codeArr1[i].m_nType, codeArr1[i].m_strMarket);
            //        }
            //    }

            //    //输出全部市场的代码表
            //    nRetInner = tdbSource.GetCodeTable("", out codeArr1);
            //    Console.WriteLine("测试所有市场代码表，输出1/1000");
            //    if (nRetInner == TDBErrNo.TDB_SUCCESS)
            //    {
            //        Console.WriteLine("-----------{0}------------", codeArr1.Length);
            //        for (int i = 0; i < codeArr1.Length; i += 1000)
            //        {
            //            Console.WriteLine("windcode:{0}, code:{1}, cnname:{2}, enname:{3}, type:{4}, market:{5}",
            //                codeArr1[i].m_strWindCode, codeArr1[i].m_strCode, codeArr1[i].m_strCNName, codeArr1[i].m_strENName, codeArr1[i].m_nType, codeArr1[i].m_strMarket);
            //        }
            //    }

            //}

            //Thread.Sleep(3000);//等待3秒，以便查看输出
            //                   //测试GetCodeInfo函数
            //{
            //    TDBCode tdbCode = tdbSource.GetCodeInfo("600000.sh", "SH-2-0");

            //    if (tdbCode != null)
            //    {
            //        Console.WriteLine("windcode:{0}, cnname:{1}, enname:{2}, type:{3}", tdbCode.m_strWindCode, tdbCode.m_strCNName, tdbCode.m_strENName, tdbCode.m_nType);
            //    }
            //    else
            //    {
            //        Console.WriteLine("not found!");
            //    }
            //    //测试一个无效的代码
            //    tdbCode = tdbSource.GetCodeInfo("xxxxyyy.sh", "SH-2-0");
            //    if (tdbCode != null)
            //    {
            //        Console.WriteLine("windcode:{0}, cnname:{1}, enname:{2}, type:{3}", tdbCode.m_strWindCode, tdbCode.m_strCNName, tdbCode.m_strENName, tdbCode.m_nType);
            //    }
            //    else
            //    {
            //        Console.WriteLine("not found!");
            //    }
            //}

            //Thread.Sleep(3000);//等待3秒，以便查看输出
            //                   //测试获取K线
            //{
            //    TDBReqKLine reqK = new TDBReqKLine();
            //    reqK.m_strWindCode = "600000.sh";
            //    reqK.m_strMarketKey = "SH-2-0";
            //    reqK.m_nCQFlag = TDBRefillFlag.REFILL_NONE;
            //    reqK.m_nCycType = TDBCycType.CYC_MINUTE;
            //    reqK.m_nCycDef = 1;
            //    reqK.m_nBeginDate = 20151210;
            //    reqK.m_nEndDate = 0;//到今天
            //    TDBKLine[] KLineResult;
            //    TDBErrNo nErrInner = tdbSource.GetKLine(reqK, out KLineResult);

            //    Console.WriteLine("req k line resut:{0}, count:{1}", nErrInner, KLineResult.Length);
            //    if (nErrInner == TDBErrNo.TDB_SUCCESS)
            //    {
            //        Console.WriteLine("-----------------------");
            //        //输出前10根k线
            //        for (int i = 0; i < KLineResult.Length && i < 10; i++)
            //        {
            //            Console.WriteLine("index:{0}, windcode:{1}, date:{2}, time:{3}, close:{4}, volume:{5}, turover:{6}",
            //                i + 1, KLineResult[i].m_strWindCode, KLineResult[i].m_nDate, KLineResult[i].m_nTime,
            //                KLineResult[i].m_nClose, KLineResult[i].m_iVolume, KLineResult[i].m_iTurover);
            //        }
            //    }
            //}

            //Thread.Sleep(3000);//等待3秒，以便查看输出
            //测试获取TICK
            {
                TDBReq reqTick = new TDBReq("1000080.sh", "SH-1-0", 20150325);
                TDBTick[] tickArr;
                TDBErrNo nErrInner = tdbSource.GetTick(reqTick, out tickArr);
                if (nErrInner == TDBErrNo.TDB_SUCCESS)
                {
                    Console.WriteLine("-----------------------");
                    //输出前10条TICK记录
                    for (int i = 0; i < tickArr.Length && i < 500; i++)
                    {
                        Console.WriteLine("index:{0}, windcode:{1}, date:{2}, time:{3}, price:{4}, volume:{5}, turover:{6}, accvolume:{7}, accturover:{8}",
                            i + 1, tickArr[i].m_strWindCode, tickArr[i].m_nDate, tickArr[i].m_nTime, tickArr[i].m_nPrice, tickArr[i].m_iVolume, tickArr[i].m_iTurover, tickArr[i].m_iAccVolume, tickArr[i].m_iAccTurover);
                    }
                }
                //测试买卖盘字段
                for (int i = 0; i < tickArr.Length && i < 300; i++)
                {
                    if (i < 290)
                    {
                        continue;
                    }
                    Console.Write("  m_nAskPrice:");
                    PrintIntArr(tickArr[i].m_nAskPrice);

                    Console.Write("  m_nAskVolume:");
                    PrintUIntArr(tickArr[i].m_nAskVolume);

                    Console.Write("  m_nBidPrice:");
                    PrintIntArr(tickArr[i].m_nBidPrice);

                    Console.Write("  m_nBidVolume:");
                    PrintUIntArr(tickArr[i].m_nBidVolume);
                }
            }

            //Thread.Sleep(3000);//等待3秒，以便查看输出
            //                   //测试期货字段
            //{
            //    TDBReq reqTick = new TDBReq("IC1512.CF", "CF-2-0", 20151210);
            //    TDBTick[] tickArr;
            //    TDBErrNo nErrInner = tdbSource.GetTick(reqTick, out tickArr);
            //    if (nErrInner == TDBErrNo.TDB_SUCCESS)
            //    {
            //        Console.WriteLine("-----------------------");
            //        //输出前10条TICK记录
            //        for (int i = 0; i < tickArr.Length && i < 10; i++)
            //        {
            //            Console.WriteLine("index:{0}, windcode:{1}, date:{2}, time:{3}, price:{4}, volume:{5}, turover:{6}, accvolume:{7}, accturover:{8}",
            //                i + 1, tickArr[i].m_strWindCode, tickArr[i].m_nDate, tickArr[i].m_nTime, tickArr[i].m_nPrice, tickArr[i].m_iVolume, tickArr[i].m_iTurover, tickArr[i].m_iAccVolume, tickArr[i].m_iAccTurover);
            //        }
            //    }
            //    for (int i = 0; i < tickArr.Length && i < 50; i++)
            //    {
            //        if (i < 40)
            //        {
            //            continue;
            //        }
            //        Console.WriteLine("nSettle:{0}", tickArr[i].m_nSettle);
            //        Console.WriteLine("nPosition:{0}", tickArr[i].m_nPosition);
            //        Console.WriteLine("nCurDelta:{0}", tickArr[i].m_nCurDelta);
            //        Console.WriteLine("nPreSettle:{0}", tickArr[i].m_nPreSettle);
            //        Console.WriteLine("nPrePosition:{0}", tickArr[i].m_nPrePosition);
            //    }
            //}

            //Thread.Sleep(3000);//等待3秒，以便查看输出
            //测试指数字段
            //{
            //    TDBReq reqTick = new TDBReq("10000001.SH", "SH-1-1", 20150209);
            //    TDBTick[] tickArr;
            //    TDBErrNo nErrInner = tdbSource.GetTick(reqTick, out tickArr);
            //    if (nErrInner == TDBErrNo.TDB_SUCCESS)
            //    {
            //        Console.WriteLine("-----------------------");
            //        //输出前10条TICK记录
            //        for (int i = 0; i < tickArr.Length && i < 10; i++)
            //        {
            //            Console.WriteLine("index:{0}, windcode:{1}, date:{2}, time:{3}, price:{4}, volume:{5}, turover:{6}, accvolume:{7}, accturover:{8}",
            //                i + 1, tickArr[i].m_strWindCode, tickArr[i].m_nDate, tickArr[i].m_nTime, tickArr[i].m_nPrice, tickArr[i].m_iVolume, tickArr[i].m_iTurover, tickArr[i].m_iAccVolume, tickArr[i].m_iAccTurover);
            //        }
            //    }
            //    for (int i = 0; i < tickArr.Length && i < 50; i++)
            //    {
            //        if (i < 40)
            //        {
            //            continue;
            //        }
            //        Console.WriteLine("nIndex:{0}", tickArr[i].m_nIndex);
            //        Console.WriteLine("nStocks:{0}", tickArr[i].m_nStocks);
            //        Console.WriteLine("nUps:{0}", tickArr[i].m_nUps);
            //        Console.WriteLine("nDowns:{0}", tickArr[i].m_nDowns);
            //        Console.WriteLine("nHoldLines:{0}", tickArr[i].m_nHoldLines);
            //    }
            //}


            //Thread.Sleep(3000);//等待3秒，以便查看输出
            //                   //测试逐笔成交
            //{
            //    TDBReq reqTransaction = new TDBReq("600000.sh", "SH-2-0", 20151210);
            //    TDBTransaction[] transactionArr;
            //    TDBErrNo nErrInner = tdbSource.GetTransaction(reqTransaction, out transactionArr);
            //    //输出前10条记录
            //    Console.WriteLine("-----------{0}------------", transactionArr.Length);
            //    for (int i = 0; i < transactionArr.Length && i < 10; i++)
            //    {
            //        Console.WriteLine("windcode:{0}, date:{1},time:{2}, price:{3},volume:{4},askorder:{5},bidorder:{6}",
            //            transactionArr[i].m_strWindCode, transactionArr[i].m_nDate, transactionArr[i].m_nTime, transactionArr[i].m_nTradePrice,
            //            transactionArr[i].m_nTradeVolume, transactionArr[i].m_nAskOrder, transactionArr[i].m_nBidOrder);
            //    }
            //}

            //Thread.Sleep(3000);//等待3秒，以便查看输出
            //                   //测试逐笔委托
            //{
            //    TDBReq reqOrder = new TDBReq("000001.sz", "sz-2-0", 20151210);
            //    TDBOrder[] orderArr;
            //    TDBErrNo nErrInner = tdbSource.GetOrder(reqOrder, out orderArr);
            //    //输出前10条记录
            //    Console.WriteLine("-----------{0}------------", orderArr.Length);
            //    for (int i = 0; i < orderArr.Length && i < 10; i++)
            //    {
            //        Console.WriteLine("windcode:{0}, date:{1},time:{2}, price:{3},volume:{4}, function code:{5}, order kind:{6}",
            //            orderArr[i].m_strWindCode, orderArr[i].m_nDate, orderArr[i].m_nTime, orderArr[i].m_nOrderPrice,
            //            orderArr[i].m_nOrderVolume, orderArr[i].m_chFunctionCode, orderArr[i].m_chOrderKind);
            //    }
            //}

            //Thread.Sleep(3000);//等待3秒，以便查看输出
            //                   //测试委托队列
            //{
            //    TDBReq reqOrderQueue = new TDBReq("600000.sh", "SH-2-0", 20151210);
            //    TDBOrderQueue[] orderQueueArr;
            //    TDBErrNo nErrInner = tdbSource.GetOrderQueue(reqOrderQueue, out orderQueueArr);
            //    //输出前10条记录
            //    Console.WriteLine("-----------{0}------------", orderQueueArr.Length);
            //    for (int i = 0; i < orderQueueArr.Length && i < 10; i++)
            //    {
            //        Console.WriteLine("windcode:{0}, date:{1},time:{2}, price:{3},side:{4}, order items:{5}, ab items :{6}",
            //            orderQueueArr[i].m_strWindCode, orderQueueArr[i].m_nDate, orderQueueArr[i].m_nTime, orderQueueArr[i].m_nPrice,
            //            orderQueueArr[i].m_nSide, orderQueueArr[i].m_nOrderItems, orderQueueArr[i].m_nABItems);
            //        PrintIntArr(orderQueueArr[i].m_nABVolume);
            //    }
            //}
            #endregion
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("按任意键结束");
            Console.ReadLine();
            //关闭连接
            //tdbSource.DisConnect();
        }
        static void PrintIntArr(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}", nums[i]);
                if (i == nums.Length - 1)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
        static void PrintUIntArr(uint[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}", nums[i]);
                if (i == nums.Length - 1)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
}