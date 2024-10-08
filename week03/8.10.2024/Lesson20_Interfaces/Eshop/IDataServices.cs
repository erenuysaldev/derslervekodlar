using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20_Interfaces.Eshop
{
    internal interface IDataServices
    {
        void Create();//Yeni kayıt ekle
        void Update();//Kayıt güncelle
        void Delete();//Kayıt sil
        void getAll();//Kayıtları listele

    }
}
