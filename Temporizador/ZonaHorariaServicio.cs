using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temporizador
{
    public class ZonaHorariaServicio
    {
        public DateTime TomarFechaHoraActual (string ZonaHorariaId)
        {
            var zonaHoraria = TimeZoneInfo.FindSystemTimeZoneById(ZonaHorariaId);
            return TimeZoneInfo.ConvertTime(DateTime.Now, zonaHoraria);
        }
    }
}
