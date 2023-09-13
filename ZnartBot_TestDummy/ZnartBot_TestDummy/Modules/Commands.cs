using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace ZnartBot_TestDummy.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {

        private readonly Random _random = new Random();

        [Command("help")]
        public async Task Help()
        {
            await ReplyAsync("Recuerda poner un $ antes de introducir cualquier comando pendejo.\n" +
                "1.- saludo : Manda un saludo a la raza del server \n" +
                "2.- boner : reproduce boner");
        }

        [Command("saludo")]
        public async Task Saludo()
        {
            string serverName = Context.Guild.Name;

            int number = _random.Next(3 + 1);
            switch (number)
            {
                case 1:
                    await ReplyAsync("UN SALUDO A LA BOLA DE **** QUE CONFORMA ***" + serverName + "*** ESPERO QUE SE LA ESTEN PASANDO A TODA MADRE HIJOS DE SU *** MADRE \nFIERRO PARIENTE ***");
                    break;
                    case 2:
                    await ReplyAsync("QUE ONDA ***" + serverName + "*** GRUPO DE *** **** ESPERO QUE SE LA ESTEN PASANDO A TODA MADRE Y SI NO PREPARANSE PARA **** A SU MADRE");
                    break;
                case 3:
                    await ReplyAsync("EL ***" + serverName + "*** ESTA EN MODO ALTERADO ASI QUE PREPAREN ESAS *** *** PARA LA *** *** QUE LES VAMOS A DAR");
                    break;
            }

        }

        [Command("memesong")]

        public async Task Memesong()
        {
            await ReplyAsync("audio no disponible por el momento");
        }


    }
}
