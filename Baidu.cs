using Baidu.Aip.Ocr;
using System;
using System.Collections.Generic;
using System.Text;

namespace 百度云识别
{
   public class BaiAi
    {   // 设置APPID/AK/SK
       
        public string API_KEY = "IOhfBVZTqxMhbWdC7Cx5Z6zd";
        public string SECRET_KEY = "k3XD5PNzFIGu1Id2sLPgjgvZcoKbBmKI";
        public Ocr OcrClien;
        public BaiAi()
        {
            OcrClien = new Ocr(API_KEY, SECRET_KEY);
            OcrClien.Timeout = 60000;  // 修改超时时间
        }
        public BaiAi(string Api_key,string sec_key)
        {

            OcrClien = new Ocr(Api_key, sec_key);
            OcrClien.Timeout = 60000;  // 修改超时时间
        }

    }
}
