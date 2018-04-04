using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSys.Group;


namespace SCLIP.Act.Configuration
{
    partial class Control
    {


        private Command _command = new Command();
        


        internal void Setup()
        {
            if (DirectoryControl.Exists(Act.Paths.AppDataLocal))
                return;


            for (int i = 0; i < Act.Paths.Direcotyrs.Length; i++)
                DirectoryControl.Create(Act.Paths.Direcotyrs[i]);



            Console.WriteLine("LISENCE");

            //Download
            Console.WriteLine();




            int tmp;

            do
            {
                Console.Write(Environment.NewLine + "Agree (y/n) : ");

                tmp = _command.YesNo(_command.Cmd() );

                if (tmp == 0)
                    Environment.Exit(tmp);


            } while (tmp == 012);



            for(; ; )
            {
                string Strtmp = null;

                Console.Write( Environment.NewLine + "Password : ");
             
            }

        }



        //------

        internal void Save(string Str,Enum Target)
        {
            switch(Target)
            {
                case TargetChannel.LoginKey:
                    break;

                case TargetChannel.LoginIv:
                    break;

                case TargetChannel.LoginSalt:
                    break;

                case TargetChannel.EncryptKey:
                    break;
            }
        }

        internal string Load(Enum Target)
        {
            switch (Target)
            {
                case TargetChannel.LoginKey:
                    return null;
                    
                case TargetChannel.LoginIv:
                    return null;
                    
                case TargetChannel.LoginSalt:
                    return null;
                    
                case TargetChannel.EncryptKey:
                    return null;
                    
                default:
                    return null;
            }
        }

    }
}
