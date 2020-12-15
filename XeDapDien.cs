using System;
using System.Collections.Generic;
using System.Text;

namespace BTĐA
{
    class Xedapdien:Xeco
    {
        public Xedapdien():base()
        {
            
        }
        public Xedapdien(int maXe,string loaixe, string bienSoXe, string hangXe,DateTime ngayGio):base(maXe,loaixe,bienSoXe,hangXe,ngayGio)
        {
            
        }
        public Xedapdien(Xeco xe):base(xe)
        {

        }
    }
}
