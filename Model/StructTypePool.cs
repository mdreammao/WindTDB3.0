using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myWindAPI
{
    /// <summary>
    /// 存储股票基本信息结构体。
    /// </summary>
    struct stockFormat
    {
        public string name;
        public string code;
        public string market;
    }

    /// <summary>
    /// 股票数据格式。
    /// </summary>
    struct stockShot
    {
        public int id, CurrDelta, PreDelta, OpenInterest, PreOpenInterest;
        public string stkcd, tdate, ndate, ttime, LocalRecTime, TradeStatus;
        public double cp, S1, S2, S3, S4, S5, S6, S7, S8, S9, S10, B1, B2, B3, B4, B5, B6, B7, B8, B9, B10, SV1, SV2, SV3, SV4, SV5, SV6, SV7, SV8, SV9, SV10, BV1, BV2, BV3, BV4, BV5, BV6, BV7, BV8, BV9, BV10, hp, lp, HighLimit, LowLimit, ts, tt, OPNPRC, PRECLOSE, Settle, PrevSettle;
    }

    /// <summary>
    /// 期权数据格式。
    /// </summary>
    struct ETFOptionShot
    {
        public int id, CurrDelta, PreDelta, OpenInterest, PreOpenInterest;
        public string stkcd, tdate,ndate, ttime, LocalRecTime, TradeStatus;
        public double cp, S1, S2, S3, S4, S5, S6, S7, S8, S9, S10, B1, B2, B3, B4, B5, B6, B7, B8, B9, B10, SV1, SV2, SV3, SV4, SV5, SV6, SV7, SV8, SV9, SV10, BV1, BV2, BV3, BV4, BV5, BV6, BV7, BV8, BV9, BV10, hp, lp, HighLimit, LowLimit, ts, tt, OPNPRC, PRECLOSE, Settle, PrevSettle;
    }



    /// <summary>
    /// 存储商品期货基本信息的结构体。
    /// </summary>
    struct ETFOptionFormat
    {
        public string contractName;
        public string code;
        public string market;
        public int startDate;
        public int endDate;
    }


    /// <summary>
    /// 商品期货数据格式。
    /// </summary>
    struct bondShot
    {
        public int id, CurrDelta, PreDelta, OpenInterest, PreOpenInterest;
        public string stkcd, tdate, ndate,ttime, LocalRecTime, TradeStatus;
        public double cp, S1, S2, S3, S4, S5, S6, S7, S8, S9, S10, B1, B2, B3, B4, B5, B6, B7, B8, B9, B10, SV1, SV2, SV3, SV4, SV5, SV6, SV7, SV8, SV9, SV10, BV1, BV2, BV3, BV4, BV5, BV6, BV7, BV8, BV9, BV10, hp, lp, HighLimit, LowLimit, ts, tt, OPNPRC, PRECLOSE, Settle, PrevSettle;
    }



    /// <summary>
    /// 存储商品期货基本信息的结构体。
    /// </summary>
    struct bondFormat
    {
        public string contractName;
        public string code;
        public string market;
        public int startDate;
        public int endDate;
    }

    /// <summary>
    /// 商品期货数据格式。
    /// </summary>
    struct commodityShot
    {
        public int id,CurrDelta,PreDelta,OpenInterest,PreOpenInterest;
        public string stkcd, tdate,ndate,ttime,LocalRecTime,TradeStatus;
        public double cp, S1, S2, S3, S4, S5, S6, S7, S8, S9, S10, B1, B2, B3, B4, B5, B6, B7, B8, B9, B10, SV1, SV2, SV3, SV4, SV5, SV6, SV7, SV8, SV9, SV10, BV1, BV2, BV3, BV4, BV5, BV6, BV7, BV8, BV9, BV10, hp, lp, HighLimit, LowLimit, ts, tt, OPNPRC, PRECLOSE, Settle, PrevSettle;
    }
    
    
    
    /// <summary>
    /// 存储商品期货基本信息的结构体。
    /// </summary>
    struct commodityFormat
    {
        public string contractName;
        public string code;
        public string market;
        public int startDate;
        public int endDate;
    }
    
    /// <summary>
    /// 存储期权基本信息的结构体。
    /// </summary>
    struct optionFormat
    {
        public int optionCode;
        public string optionName;
        public int startDate;
        public int endDate;
        public string optionType;
        public string executeType;
        public double strike;
        public string market;
    }

    /// <summary>
    /// 存储期权数据的结构体。包含30多个字段。
    /// </summary>
    struct optionDataFormat
    {
        public int optionCode;
        public string optionType;
        public double strike;
        public int startDate;
        public int endDate;
        public int date;
        public int time;
        public int tick;
        public double underlyingPrice;
        public double volumn;
        public double turnover;
        public double accVolumn;
        public double accTurnover;
        public double open;
        public double high;
        public double low;
        public double lastPrice;
        public double preSettle;
        public double preClose;
        public double[] ask, askv, askVolatility,askDelta,bid, bidv,bidVolatility,bidDelta;
        public double openMargin;
        public double midVolatility,midDelta;
    }

    /// <summary>
    /// 需要提取TDB数据的品种信息。
    /// </summary>
    struct TDBdataInformation
    {
        public string market;
        public int startDate;
        public int endDate;
        public string type;
    }
    /// <summary>
    /// 记录TDB连接信息的结构体。
    /// </summary>
    struct TDBsource
    {
        public string IP;
        public string port;
        public string account;
        public string password;
        public TDBsource(string IP, string port, string account, string password)
        {
            this.IP = IP;
            this.port = port;
            this.account = account;
            this.password = password;
        }
    }
}
