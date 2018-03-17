using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FSys;
using CipherModule.Fake;

namespace $safeprojectname$.Act
{
    class ItemControl
    {
        public void Encrypt(string ServiceName,string URL,string Name,string Passwd,string Mail,string TEL,string Memo)
        {
            Writer writer = new Writer();

            if(FileSt.Exists(Paths.Directory[0] + ServiceName))
                writer.Open(Paths.Directory[0] +  ServiceName,Writer.Mode.Open);
            else
                writer.Open(Paths.Directory[0] + ServiceName, Writer.Mode.Create);



            string tmp = ServiceName + ',' + URL + ',' + Name + ',' + Passwd + ',' + Mail + ',' + TEL + ',' + Memo;

            string Iv = SimpleRandom.Create();


            writer.Write(GeneralPurpose.Cipher.Encrypt(Configuration.EncryptKey,Iv,tmp) + ',' + Iv);

            writer.Close();
        }


        public string Decrypt(string ServiceName)
        {

            string tmp;


            Reader reader = new Reader();

            reader.Open(Paths.Directory[0] + ServiceName);

            tmp = reader.Read();

            reader.Close();


            tmp = GeneralPurpose.Cipher.Decrypt(Configuration.EncryptKey,tmp.Split(',')[1],tmp.Split(',')[0]);

            return tmp;
        }

        public void Delete(string ServiceName)
        {
            FileSt.Delete(Paths.Directory[0] + ServiceName);
        }

        public string[] Items
        {
            get
            {
                FSysDirectory.List list = new FSysDirectory.List();

                return list.Files(Paths.Directory[0]);
            }
        }


    }
}
