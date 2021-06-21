﻿using System;

namespace Hyperai.Messages.ConcreteModels
{
    [Serializable]
    public class Face : MessageElement
    {
        public Face(int faceId)
        {
            FaceId = faceId;
        }

        public int FaceId { get; set; }

        public override int GetHashCode()
        {
            return FaceId;
        }

        public override string ToString()
        {
            return $"<FACE {FaceId}>";
        }
    }

    public enum FaceType
    {
        UNKNOWN = 0xFF,
        JINGYA = 0,
        PIEZUI = 1,
        SE = 2,
        FADAI = 3,
        DEYI = 4,
        LIULEI = 5,
        HAIXIU = 6,
        BIZUI = 7,
        SHUI = 8,
        DAKU = 9,
        GANGA = 10,
        FANU = 11,
        TIAOPI = 12,
        CIYA = 13,
        WEIXIAO = 14,
        NANGUO = 15,
        KU = 16,
        ZHUAKUANG = 18,
        TU = 19,
        TOUXIAO = 20,
        KEAI = 21,
        BAIYAN = 22,
        AOMAN = 23,
        JI_E = 24,
        KUN = 25,
        JINGKONG = 26,
        LIUHAN = 27,
        HANXIAO = 28,
        DABING = 29,
        FENDOU = 30,
        ZHOUMA = 31,
        YIWEN = 32,
        YUN = 34,
        ZHEMO = 35,
        SHUAI = 36,
        KULOU = 37,
        QIAODA = 38,
        ZAIJIAN = 39,
        FADOU = 41,
        AIQING = 42,
        TIAOTIAO = 43,
        ZHUTOU = 46,
        YONGBAO = 49,
        DAN_GAO = 53,
        SHANDIAN = 54,
        ZHADAN = 55,
        DAO = 56,
        ZUQIU = 57,
        BIANBIAN = 59,
        KAFEI = 60,
        FAN = 61,
        MEIGUI = 63,
        DIAOXIE = 64,
        AIXIN = 66,
        XINSUI = 67,
        LIWU = 69,
        TAIYANG = 74,
        YUELIANG = 75,
        QIANG = 76,
        RUO = 77,
        WOSHOU = 78,
        SHENGLI = 79,
        FEIWEN = 85,
        NAOHUO = 86,
        XIGUA = 89,
        LENGHAN = 96,
        CAHAN = 97,
        KOUBI = 98,
        GUZHANG = 99,
        QIUDALE = 100,
        HUAIXIAO = 101,
        ZUOHENGHENG = 102,
        YOUHENGHENG = 103,
        HAQIAN = 104,
        BISHI = 105,
        WEIQU = 106,
        KUAIKULE = 107,
        YINXIAN = 108,
        QINQIN = 109,
        XIA = 110,
        KELIAN = 111,
        CAIDAO = 112,
        PIJIU = 113,
        LANQIU = 114,
        PINGPANG = 115,
        SHIAI = 116,
        PIAOCHONG = 117,
        BAOQUAN = 118,
        GOUYIN = 119,
        QUANTOU = 120,
        CHAJIN = 121,
        AINI = 122,
        BU = 123,
        HAO = 124,
        ZHUANQUAN = 125,
        KETOU = 126,
        HUITOU = 127,
        TIAOSHENG = 128,
        HUISHOU = 129,
        JIDONG = 130,
        JIEWU = 131,
        XIANWEN = 132,
        ZUOTAIJI = 133,
        YOUTAIJI = 134,
        SHUANGXI = 136,
        BIANPAO = 137,
        DENGLONG = 138,
        FACAI = 139,
        K_GE = 140,
        GOUWU = 141,
        YOUJIAN = 142,
        SHUAI_QI = 143,
        HECAI = 144,
        QIDAO = 145,
        BAOJIN = 146,
        BANGBANGTANG = 147,
        HE_NAI = 148,
        XIAMIAN = 149,
        XIANGJIAO = 150,
        FEIJI = 151,
        KAICHE = 152,
        GAOTIEZUOCHETOU = 153,
        CHEXIANG = 154,
        GAOTIEYOUCHETOU = 155,
        DUOYUN = 156,
        XIAYU = 157,
        CHAOPIAO = 158,
        XIONGMAO = 159,
        DENGPAO = 160,
        FENGCHE = 161,
        NAOZHONG = 162,
        DASAN = 163,
        CAIQIU = 164,
        ZUANJIE = 165,
        SHAFA = 166,
        ZHIJIN = 167,
        YAO = 168,
        SHOUQIANG = 169,
        QINGWA = 170,
        HEXIE = 184,
        YANGTUO = 185,
        YOULING = 187,
        DAN = 188,
        JUHUA = 190,
        HONGBAO = 192,
        DAXIAO = 193,
        BUKAIXIN = 194,
        LENGMO = 197,
        E = 198,
        HAOBANG = 199,
        BAITUO = 200,
        DIANZAN = 201,
        WULIAO = 202,
        TUOLIAN = 203,
        CHI = 204,
        SONGHUA = 205,
        HAIPA = 206,
        HUACHI = 207,
        XIAOYANGER = 208,
        BIAOLEI = 210,
        WOBUKAN = 211,
        BOBO = 214,
        HULIAN = 215,
        PAITOU = 216,
        CHEYICHE = 217,
        TIANYITIAN = 218,
        CENGYICENG = 219,
        ZHUAIZHATIAN = 220,
        DINGGUAGUA = 221,
        BAOBAO = 222,
        BAOJI = 223,
        KAIQIANG = 224,
        LIAOYILIAO = 225,
        PAIZHUO = 226,
        PAISHOU = 227,
        GONGXI = 228,
        GANBEI = 229,
        CHAOFENG = 230,
        HENG = 231,
        FOXI = 232,
        QIAOYIQIOA = 233,
        JINGDAI = 234,
        CHANDOU = 235,
        KENTOU = 236,
        TOUKAN = 237,
        SHANLIAN = 238,
        YUANLIANG = 239,
        PENLIAN = 24
    }
}
