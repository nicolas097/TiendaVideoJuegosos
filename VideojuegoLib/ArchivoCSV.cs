using System.Text;

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


        public int GenerateId(List<int> VideoJuegoIds)
        {
            //sort ordena de menor a mayor y en caso de ser una lista de tipo string, ordena alfabeticamente la lista   
            VideoJuegoIds.Sort();

            int idSequence = 1;
            foreach (var item in VideoJuegoIds)
            {
                if (idSequence == item)
                {
                    //aumenta de 1 en 1 la lista 
                    idSequence++;
                }
                else
                {
                    return idSequence;
                }
            }
            return idSequence;
        }


        public void AddVideoJuego(VideoJuego vid, List<VideoJuego> ListaAgregacion)
        {

            if (ListaAgregacion.Count > 0)
            {
                vid.id = GenerateId(ListaAgregacion.Select(s => s.id).ToList());
                ListaAgregacion.Add(vid);
            }

        }


        public bool DeleteVideoJuego(VideoJuego vid, List<VideoJuego> ListaEliminacion)
        {

            foreach (var juego in ListaEliminacion)
            {
                if (juego.nombre == vid.nombre)
                {
                    ListaEliminacion.Remove(juego);
                    return true;
                }
            }
            return false;   
        }



        public bool SearchVideoJuego(VideoJuego video, List<VideoJuego> ListaDeBusqueda)
        {
            foreach (var juego in ListaDeBusqueda)
            {
                if (juego.nombre == video.nombre)
                {
                    //ListaDeBusqueda.Exists(video => video == juego); 
                    return true;
                    
                }
            }
            return false;
        }
    }
}
