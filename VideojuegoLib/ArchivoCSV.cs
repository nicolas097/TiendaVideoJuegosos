using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideojuegoLib
{
    public class ArchivoCSV
    {
        public List<VideoJuego> VideoJuegoListFromCSV(string csvPath)
        {

            List<string> lineasCSV = File.ReadAllLines(csvPath).ToList();

            List<VideoJuego> videoAlboCampeon = new List<VideoJuego>();

            foreach (string linea in lineasCSV)
            {
                if (!linea.Contains("id,nombre,plataforma"))
                {

                    VideoJuego vid = new VideoJuego();
                    vid.id = Convert.ToInt32(linea.Split(',')[0]);
                    vid.nombre = linea.Split(',')[1];
                    vid.plataforma = linea.Split(',')[2];
                    videoAlboCampeon.Add(vid);

                }

            }

            return videoAlboCampeon;
        }


        public void SaveCSVFromVideoJuegoList(List<VideoJuego> videoJuego, string csvPath)
        {

            StringBuilder sb = new StringBuilder();
            //es un constructor de cadena 
            sb.AppendLine("id,nombre,plataforma");

            foreach (var item in videoJuego)
            {
                sb.AppendLine(string.Format("{0},{1},{2}", item.id, item.nombre, item.plataforma));
            }

            File.WriteAllText(csvPath, sb.ToString());

        }



    }
}
