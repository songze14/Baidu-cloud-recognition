﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 百度云识别
{
   public class BaiduOcR
    {
        protected static BaiAi BaiAi { get; set; }
        public BaiduOcR()
        {
            BaiAi = new BaiAi();
        }
        public BaiduOcR(string Api_key, string sec_key)
        {
            BaiAi = new BaiAi( Api_key,  sec_key);
        }
        public  string Ocr(Stream imagestream)
        {
         
            var ocr = BaiAi.OcrClien;
            BinaryReader r = new BinaryReader(imagestream);

            r.BaseStream.Seek(0, SeekOrigin.Begin);    //将文件指针设置到文件开
            var image = r.ReadBytes((int)r.BaseStream.Length);
            var options = new Dictionary<string, object>{
                            {"detect_direction", "true"},
                            {"probability", "true"}
                        };
            var result = ocr.AccurateBasic(image);
            var cc = result["words_result"];
            string resultstr = string.Empty;
            if (cc!=null)
            {
                foreach (var item in cc)
                {
                    resultstr += item["words"]+"\r\n";
                }
            }
            
            
            return resultstr;
        }
    }
}
